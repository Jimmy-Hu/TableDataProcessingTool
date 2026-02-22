#define _WINDOWS
using ClosedXML.Excel;
using ExcelDataReader;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableDataProcessingTool2.CSharpFiles
{
    [Serializable]
    [ProtoContract]
    public class SheetFileStructure : BaseClass
    {
        [ProtoMember(1)]
        private string Filename = "";
        [ProtoMember(2)]
        private List<SheetStructure> SheetStructures;

        public SheetFileStructure(string FilenameInput)
        {
            //  Reference: https://stackoverflow.com/a/58074654/6667035
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            if (System.IO.Path.GetExtension(FilenameInput).Equals(".sheets2"))
            {
                var LoadedData = ReadFromBinaryFile<Tuple<string, List<SheetStructure>>>(FilenameInput);
                this.Filename = LoadedData.Item1;
                this.SheetStructures = LoadedData.Item2;
                return;
            }
            this.Filename = FilenameInput;
            this.SheetStructures = new List<SheetStructure>();
            if (File.Exists(this.Filename))                        //    File is existed
            {
                var TabelReadFromFile = ReadXLSXFile(this.Filename);
                XLWorkbook? styleWorkbook = null;
                bool isModernExcel = System.IO.Path.GetExtension(FilenameInput).Equals(".xlsx", StringComparison.OrdinalIgnoreCase) ||
                                     System.IO.Path.GetExtension(FilenameInput).Equals(".xlsm", StringComparison.OrdinalIgnoreCase);
                if (isModernExcel)
                {
                    styleWorkbook = new XLWorkbook(FilenameInput);
                }
                for (int LoopNumberForTableCount = 0; LoopNumberForTableCount < TabelReadFromFile.Tables.Count; LoopNumberForTableCount++)
                {
                    var NewSheetStructure = TableToSheetStructure((uint)LoopNumberForTableCount, TabelReadFromFile.Tables[LoopNumberForTableCount].TableName, TabelReadFromFile.Tables[LoopNumberForTableCount]);

                    #if _WINDOWS
                    //    Read attributes of each cell
                    FileInfo InputFileInfo = new FileInfo(FilenameInput);
                    if (InputFileInfo.Extension.Equals(".xlsx") ||
                        InputFileInfo.Extension.Equals(".xlsm") ||
                        InputFileInfo.Extension.Equals(".xls"))
                    {
                        CSharpFiles.BlockStructure NewBlockStructure =
                            NewSheetStructure.GetBlockStructure();
                        
                        //    Start a Excel application
                        Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                        try
                        {
                            var ExcelWorkbook = ExcelApp.Workbooks.Open(
                            FilenameInput
                            );
                            /*
                            Parallel.For(0, NewBlockStructure.GetBlockSizeX(), (LoopNumberX, StateX) =>
                            {
                                Parallel.For(0, NewBlockStructure.GetBlockSizeY(), (LoopNumberY, StateY) =>
                                {
                                    System.Drawing.Color SystemDrawingColor =
                                        GetBackgroundColor(ExcelWorkbook, NewSheetStructure.GetSheetName(), (uint)LoopNumberX, (uint)LoopNumberY);
                                    NewBlockStructure.GetCell(LoopNumberX, LoopNumberY).SetBackGroundColor(XLColor.FromArgb(
                                        SystemDrawingColor.A, SystemDrawingColor.R, SystemDrawingColor.G, SystemDrawingColor.B));
                                });
                            });
                            */
                            /*
                            for (int LoopNumberX = 0; LoopNumberX < NewBlockStructure.GetBlockSizeX(); LoopNumberX++)
                            {
                                for (int LoopNumberY = 0; LoopNumberY < NewBlockStructure.GetBlockSizeY(); LoopNumberY++)
                                {
                                    System.Drawing.Color SystemDrawingColor =
                                        GetBackgroundColor(ExcelWorkbook, NewSheetStructure.GetSheetName(), (uint)LoopNumberX, (uint)LoopNumberY);
                                    NewBlockStructure.GetCell(LoopNumberX, LoopNumberY).SetBackGroundColor(XLColor.FromArgb(
                                        SystemDrawingColor.A, SystemDrawingColor.R, SystemDrawingColor.G, SystemDrawingColor.B));
                                }
                            }
                            */

                            NewSheetStructure.SetBlockStructure(NewBlockStructure);
                            ExcelWorkbook.Close(false);
                            KillExcelApplication();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Excel program error!");
                        }
                        
                    }
                    #endif
                    this.SheetStructures.Add(NewSheetStructure);
                }
            }
        }

        public SheetFileStructure Add(SheetStructure NewSheetStructure)
        {
            this.SheetStructures.Add(NewSheetStructure);
            return this;
        }

        public SheetFileStructure Clear()
        {
            this.SheetStructures.Clear();
            return this;
        }

        public SheetFileStructure DeepClone()
        {
            return (SheetFileStructure)DeepClone(this);
        }

        public void Print()
        {
            foreach (var EachSheet in this.GetSheetStructures())
            {
                EachSheet.Print();
                Console.WriteLine("================================================");
            }
        }

        private System.Data.DataSet ReadXLSXFile(string Filename)
        {
            string file = Filename;
            if (File.Exists(file))
            {
                var extension = Path.GetExtension(file).ToLower();
                Console.WriteLine("Read file: " + file);
                using (var stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    //    Perform file reading process based on file type
                    ExcelDataReader.IExcelDataReader reader = null;
                    if (extension == ".xls")
                    {
                        Console.WriteLine(" => XLS format");
                        reader = ExcelDataReader.ExcelReaderFactory.CreateBinaryReader(stream, new ExcelDataReader.ExcelReaderConfiguration()
                        {
                            FallbackEncoding = Encoding.GetEncoding("big5")
                        });
                    }
                    else if (extension == ".xlsx" || extension.Equals(".xlsm"))
                    {
                        Console.WriteLine(" => XLSX format / XLSM format");
                        reader = ExcelDataReader.ExcelReaderFactory.CreateOpenXmlReader(stream);
                    }
                    else if (extension == ".csv")
                    {
                        Console.WriteLine(" => CSV format");
                        reader = ExcelDataReader.ExcelReaderFactory.CreateCsvReader(stream, new ExcelDataReader.ExcelReaderConfiguration()
                        {
                            FallbackEncoding = Encoding.GetEncoding("big5")
                        });
                    }
                    else if (extension == ".txt")
                    {
                        Console.WriteLine(" => Text(Tab Separated) format");
                        reader = ExcelDataReader.ExcelReaderFactory.CreateCsvReader(stream, new ExcelDataReader.ExcelReaderConfiguration()
                        {
                            FallbackEncoding = Encoding.GetEncoding("big5"),
                            AutodetectSeparators = new char[] { '\t' }
                        });
                    }

                    //    Unknown file format handling
                    if (reader == null)
                    {
                        Console.WriteLine("Unknown file type：" + extension);
                    }

                    Console.WriteLine(" => Generating Result...");

                    System.Data.DataSet ds;
                    using (reader)
                    {
                        ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            UseColumnDataType = false,
                            ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                            {
                                //    Read title of data
                                UseHeaderRow = false
                            }
                        });

                        return ds;

                    }
                }
                Console.WriteLine("Process finished...");
            }
            else
            {
                Console.WriteLine("File " + file + " does not exist!");
                return new System.Data.DataSet();
            }
        }

        private string GetDataFromDataSet(System.Data.DataSet DataSetInput, int SheetNumber, int RowNumber, int ColumnNumber)
        {
            try
            {
                 return DataSetInput.Tables[SheetNumber].Rows[RowNumber][ColumnNumber].ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }
        /*
        #if _WINDOWS
        private System.Drawing.Color GetBackgroundColor(
            Microsoft.Office.Interop.Excel.Workbook WorkbookObject, 
            string SheetName,
            uint LocationX,
            uint LocationY
            )
        {
            try
            {
                Microsoft.Office.Interop.Excel.Worksheet ExcelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)WorkbookObject.Worksheets[SheetName];
                return System.Drawing.ColorTranslator.FromOle(
                    System.Convert.ToInt32(ExcelWorksheet.Cells[LocationY + 1, LocationX + 1].Interior.Color)
                    );
            }
            catch (Exception)
            {
                return System.Drawing.Color.Transparent;
            }
        }
        #endif

        #if _WINDOWS
        private Microsoft.Office.Interop.Excel.Borders GetBorders(
            Microsoft.Office.Interop.Excel.Workbook WorkbookObject,
            string SheetName,
            uint LocationX,
            uint LocationY
            )
        {
            try
            {
                Microsoft.Office.Interop.Excel.Worksheet ExcelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)WorkbookObject.Worksheets[SheetName];
                return ExcelWorksheet.Cells[LocationY + 1, LocationX + 1].Borders;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endif
        */

        private SheetStructure TableToSheetStructure(uint SheetIndexInput, string SheetNameInput, System.Data.DataTable DataTableInput)
        {
            uint ColumnSize = 0;
            uint RowSize = (uint)DataTableInput.Rows.Count;

            foreach (System.Data.DataRow row in DataTableInput.Rows)//y
            {
                foreach (System.Data.DataColumn col in DataTableInput.Columns)//x
                {
                    if (ColumnSize < DataTableInput.Columns.Count)
                    {
                        ColumnSize = (uint)DataTableInput.Columns.Count;
                    }
                }
            }

            var BlockStructureObject = new BlockStructure(ColumnSize, RowSize);
            uint LoopNumberY = 0;
            foreach (System.Data.DataRow row in DataTableInput.Rows)//y
            {
                uint LoopNumberX = 0;
                foreach (System.Data.DataColumn col in DataTableInput.Columns)//x
                {
                    var Result = BlockStructureObject.SetCell(new CellStructure(row[col.ColumnName].ToString()), LoopNumberX, LoopNumberY);
                    if (!Result.Item1)
                    {
                        Console.WriteLine($"Failed to set cell at ({LoopNumberX}, {LoopNumberY}): " + Result.Item2);
                        throw new Exception($"Failed to set cell at ({LoopNumberX}, {LoopNumberY}): " + Result.Item2);
                    }
                    BlockStructureObject = Result.Item2;
                    LoopNumberX = LoopNumberX + 1;
                }
                LoopNumberY = LoopNumberY + 1;
            }
            return new SheetStructure(SheetIndexInput, SheetNameInput, BlockStructureObject);
        }

        public SheetStructure GetSheetStructure(int Index)
        {
            if (Index < this.SheetStructures.Count)
            {
                return this.SheetStructures[Index];
            }
            return null;
        }

        public SheetStructure GetSheetStructureByName(string NameInput)
        {
            foreach (var EachSheetStructure in this.SheetStructures)
            {
                if (EachSheetStructure.GetSheetName().Equals(NameInput).Equals(true))
                {
                    return EachSheetStructure;
                }
            }
            return null;
        }

        public List<SheetStructure> GetSheetStructures()
        {
            return this.SheetStructures;
        }
        public SheetFileStructure SetSheetStructures(List<SheetStructure> SheetStructuresInput)
        {
            this.SheetStructures = SheetStructuresInput;
            return this;
        }
        public void SaveFileForced()
        {
            SaveFileForced(this.Filename);
        }
        public void SaveFileForced(string InputFilename)
        {
            //    Reference: https://github.com/closedxml/closedxml
            using (var workbook = new ClosedXML.Excel.XLWorkbook())
            {
                foreach (var EachSheet in this.SheetStructures)
                {
                    //    Create new worksheet
                    var worksheet = workbook.Worksheets.Add(EachSheet.GetSheetName());

                    //    Write data to the worksheet
                    for (uint LoopNumberY = 0; LoopNumberY < EachSheet.GetSizeY(); LoopNumberY++)
                    {
                        for (uint LoopNumberX = 0; LoopNumberX < EachSheet.GetSizeX(); LoopNumberX++)
                        {
                            try
                            {
                                if (EachSheet.GetBlockStructure().GetCell(LoopNumberX, LoopNumberY).IsBackGroundColorUsed().Equals(true))
                                {
                                    ClosedXMLWriteData(ref worksheet, (int)LoopNumberY, (int)LoopNumberX,
                                    EachSheet.GetBlockStructure().GetCell(LoopNumberX, LoopNumberY).GetString(),
                                    EachSheet.GetBlockStructure().GetCell(LoopNumberX, LoopNumberY).GetBackGroundColor());
                                }
                                else
                                {
                                    ClosedXMLWriteData(ref worksheet, (int)LoopNumberY, (int)LoopNumberX,
                                    EachSheet.GetBlockStructure().GetCell(LoopNumberX, LoopNumberY).GetString());
                                }
                                
                            }
                            catch (Exception)
                            {

                                //throw;
                            }
                        }
                        
                    }
                }
                if (this.SheetStructures.Count.Equals(0))            //    no any worksheet
                {
                    //    Create new worksheet
                    var worksheet = workbook.Worksheets.Add("New Sheet");
                }

                //    Save file
                SaveWorkbookForced(workbook, InputFilename);
            }
        }

        /// <summary>
        /// Index start from 0
        /// </summary>
        /// <param name="Row"></param>
        /// <param name="Column"></param>
        /// <param name="DataInput"></param>
        private void ClosedXMLWriteData(ref ClosedXML.Excel.IXLWorksheet WorkSheetInput, int Row, int Column, string DataInput)
        {
            WorkSheetInput.Cell(Row + 1, Column + 1).Value = DataInput;
        }
        private void ClosedXMLWriteData(
            ref ClosedXML.Excel.IXLWorksheet WorkSheetInput,
            int Row,
            int Column,
            string DataInput,
            ClosedXML.Excel.XLColor BackGroundColor)
        {
            WorkSheetInput.Cell(Row + 1, Column + 1).Value = DataInput;
            WorkSheetInput.Cell(Row + 1, Column + 1).Style.Fill.BackgroundColor = BackGroundColor;
        }

        private void SaveWorkbookForced(ClosedXML.Excel.XLWorkbook xLWorkbook, string Filename)
        {
            try
            {
                xLWorkbook.SaveAs(Filename);
            }
            catch (Exception)
            {
                KillExcelApplication();
                System.Threading.Thread.Sleep(500);                 //    Add delay for waiting Excel closing
                xLWorkbook.SaveAs(Filename);
            }
        }

        private void KillExcelApplication()
        {
            KillApplication("Excel");
        }

        private void KillApplication(in string ApplicationName)
        {
            try
            {
                foreach (var process in System.Diagnostics.Process.GetProcessesByName(ApplicationName))
                {
                    process.Kill();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        public void Save(string Filename)
        {
            WriteToBinaryFile<Tuple<string, List<SheetStructure>>>(
                Filename,
                new Tuple<string, List<SheetStructure>>(this.Filename, this.SheetStructures)
                );
        }

        public void Load(string Filename)
        {
            var LoadedData = ReadFromBinaryFile<Tuple<string, List<SheetStructure>>>(Filename);
            this.Filename = LoadedData.Item1;
            this.SheetStructures = LoadedData.Item2;
        }

        /// <summary>
        /// WriteToBinaryFile method that serializes an object to a binary file using Protobuf-net.
        /// Writes the given object instance to a binary file.
        /// </summary>
        /// <typeparam name="T">The type of object being written to the XML file.</typeparam>
        /// <param name="filePath">The file path to write the object instance to.</param>
        /// <param name="objectToWrite">The object instance to write to the XML file.</param>
        /// <param name="append">If false the file will be overwritten if it already exists. If true the contents will be appended to the file.</param>
        private static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            var bytes = Serialize<T>(objectToWrite);
            if (bytes == null) return; // Add safety check

            if (append)
            {
                File.AppendAllBytes(filePath, bytes);
            }
            else
            {
                File.WriteAllBytes(filePath, bytes);
            }
        }

        /// <summary>
        /// Reads an object instance from a binary file.
        /// Reference: https://stackoverflow.com/a/22425211/6667035
        /// </summary>
        /// <typeparam name="T">The type of object to read from the XML.</typeparam>
        /// <param name="filePath">The file path to read the object instance from.</param>
        /// <returns>Returns a new instance of the object read from the binary file.</returns>
        private static T ReadFromBinaryFile<T>(string filePath)
        {
            var bytes = File.ReadAllBytes(filePath);
            return Deserialize<T>(bytes);
        }
    }
}
