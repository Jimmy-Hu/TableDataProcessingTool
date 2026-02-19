using ClosedXML.Excel;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableDataProcessingTool2.CSharpFiles
{
    [ProtoContract]
    public class BlockStructure : BaseClass
    {
        [ProtoMember(1)]
        private List<CellStructure> TableArray = new List<CellStructure>();
        [ProtoMember(2)]
        private int xsize = 0;
        [ProtoMember(3)]
        private int ysize = 0;

        public BlockStructure()
        {
            this.TableArray = new List<CellStructure>();
        }

        public BlockStructure(BlockStructure BlockStructureInput)
        {
            this.TableArray = BlockStructureInput.TableArray;
        }

        //  Is generic constructor in non-generic class supported?
        //  https://stackoverflow.com/a/3606951/6667035
        //  Cannot have a generic constructor in a non-generic class in C#

        public BlockStructure(dynamic x, dynamic y)
        {
            if (x > 0 && y > 0)
            {
                xsize = (int)x;
                ysize = (int)y;
                for (int i = 0; i < x * y; i++)
                {
                    TableArray.Add(new CellStructure(""));
                }
            }
        }

        public BlockStructure(dynamic x, dynamic y, CellStructure InitialValue)
        {
            if (x > 0 && y > 0)
            {
                xsize = (int)x;
                ysize = (int)y;
                for (int i = 0; i < x * y; i++)
                {
                    TableArray.Add(InitialValue);
                }
            }
        }

        public BlockStructure(List<CellStructure> input, dynamic xsize_input, dynamic ysize_input)
        {
            TableArray = input;
            xsize = (int)xsize_input;
            ysize = (int)ysize_input;
        }

        public CellStructure GetCell(dynamic x, dynamic y)
        {
            try
            {
                return TableArray[(int)y * xsize + (int)x];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"x = {x}, y = {y} Index invalid");
                return new CellStructure();
            }
        }

        public CellStructure GetCell<T1, T2>(Tuple<T1, T2> Location)
            where T1 : struct, IConvertible
            where T2 : struct, IConvertible
        {
            return GetCell(Location.Item1, Location.Item2);
        }

        public List<CellStructure> GetCells(List<Tuple<uint, uint>> Location)
        {
            List<CellStructure> output = new List<CellStructure>();
            foreach (var item in Location)
            {
                output.Add(this.GetCell(item));
            }
            return output;
        }

        public List<List<CellStructure>> GetCells(List<List<Tuple<uint, uint>>> Location)
        {
            List<List<CellStructure>> output = new List<List<CellStructure>>();
            foreach (var item in Location)
            {
                output.Add(this.GetCells(item));
            }
            return output;
        }

        public IEnumerable<CellStructure> GetCells(IEnumerable<Tuple<uint, uint>> Location)
        {
            foreach (var each in Location)
            {
                yield return GetCell(each);
            }
        }

        public System.Collections.IEnumerable GetCells(System.Collections.IEnumerable Location)
        {
            foreach (var each in Location)
            {
                if (each is IEnumerable<Tuple<uint, uint>> InnerLocation)
                {
                    yield return GetCells(InnerLocation);
                }
                else if (each is System.Collections.IEnumerable enumerable)
                {
                    yield return GetCells(enumerable);
                }
            }
        }

        /// <summary>
        /// Update ALL CellStructure.
        /// </summary>
        /// <param name="CellStructureInput">Target Cell</param>
        /// <returns></returns>
        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput)
        {
            bool ReturnBool = true;
            Parallel.For(0, this.GetBlockSizeY(), y =>
            {
                Parallel.For(0, this.GetBlockSizeX(), x =>
                {
                    if (this.SetCell(CellStructureInput, x, y).Item1.Equals(false))
                    {
                        ReturnBool = false;
                    }
                });
            });
            return new Tuple<bool, BlockStructure>(ReturnBool, this);
        }

        /// <summary>
        /// SetCell method
        /// </summary>
        /// <param name="CellStructureInput"></param>
        /// <param name="LocationX"></param>
        /// <param name="LocationY"></param>
        /// <returns>
        /// The first return value represent operation success or failed.
        /// The second return value is the execution result.
        /// </returns>
        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, dynamic LocationX, dynamic LocationY)
        {
            try
            {
                if ((int)LocationX > GetBlockSizeX() || (int)LocationY > GetBlockSizeY())
                {
                    Console.WriteLine("Out Of Boundary!");
                    return new Tuple<bool, BlockStructure>(false, this);
                }
                TableArray[(int)LocationY * xsize + (int)LocationX] = CellStructureInput;
                return new Tuple<bool, BlockStructure>(true, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new Tuple<bool, BlockStructure>(false, this);
            }
        }

        public Tuple<bool, BlockStructure> SetCell<T1, T2>(CellStructure CellStructureInput, Tuple<T1, T2> Location)
            where T1 : struct, IConvertible
            where T2 : struct, IConvertible
        {
            this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public BlockStructure AddLabel(System.Drawing.Point TopLeftLocation, uint SizeX, uint SizeY, string LabelInput)
        {
            Parallel.For(0, SizeY, (y, stateY) =>
            {
                Parallel.For(0, SizeX, (x, stateX) =>
                {
                    SetCell(GetCell(TopLeftLocation.X + x, TopLeftLocation.Y + y).AddLabel(LabelInput), TopLeftLocation.X + x, TopLeftLocation.Y + y);
                });
            });
            return this;
        }

        public BlockStructure AddLabel(List<Tuple<int, int>> Locations, string LabelInput)
        {
            foreach (var EachLocation in Locations)
            {
                AddLabel(EachLocation, 1, 1, LabelInput);
            }
            return this;
        }

        public BlockStructure AddLabel(Tuple<int, int> TopLeftLocation, int SizeX, int SizeY, string LabelInput)
        {
            return AddLabel(
                new System.Drawing.Point(TopLeftLocation.Item1, TopLeftLocation.Item2),
                (uint)SizeX,
                (uint)SizeY,
                LabelInput);
        }

        public BlockStructure AddLabel(System.Drawing.Point TopLeftLocation, int SizeX, int SizeY, string LabelInput)
        {
            return this.AddLabel(
                TopLeftLocation,
                (uint)SizeX,
                (uint)SizeY,
                LabelInput);
        }

        public BlockStructure AddTopRow()
        {
            return this.ConcatenateVerticalInverse(new BlockStructure(1, 1), true);
        }

        public BlockStructure ConcatenateHorizontal(BlockStructure BlockStructureInput)
        {
            if (this.GetBlockSizeY().Equals(BlockStructureInput.GetBlockSizeY()).Equals(false))
            {
                return new BlockStructure();
            }
            var ReturnObject = new BlockStructure(this.GetBlockSizeX() + BlockStructureInput.GetBlockSizeX(), this.GetBlockSizeY());
            Parallel.For(0, this.GetBlockSizeY(), (y, stateY) =>
            {
                Parallel.For(0, this.GetBlockSizeX(), (x, stateX) =>
                {
                    ReturnObject.SetCell(this.GetCell(x, y), x, y);
                });
            });
            Parallel.For(0, BlockStructureInput.GetBlockSizeY(), (y, stateY) =>
            {
                Parallel.For(0, BlockStructureInput.GetBlockSizeX(), (x, stateX) =>
                {
                    ReturnObject.SetCell(BlockStructureInput.GetCell(x, y), x + this.GetBlockSizeX(), y);
                });
            });

            return ReturnObject;
        }

        public BlockStructure ConcatenateHorizontal(BlockStructure BlockStructureInput, bool EnhancedMode)
        {
            if (EnhancedMode && this.GetBlockSizeY() < BlockStructureInput.GetBlockSizeY())
            {
                return this.ConcatenateVertical(new BlockStructure(this.GetBlockSizeX(), BlockStructureInput.GetBlockSizeY() - this.GetBlockSizeY())).ConcatenateHorizontal(BlockStructureInput);
            }
            else if (EnhancedMode && this.GetBlockSizeY() > BlockStructureInput.GetBlockSizeY())
            {
                return this.ConcatenateHorizontal(BlockStructureInput.ConcatenateVertical(new BlockStructure(BlockStructureInput.GetBlockSizeX(), this.GetBlockSizeY() - BlockStructureInput.GetBlockSizeY())));
            }
            else
            {
                return this.ConcatenateHorizontal(BlockStructureInput);
            }
        }

        public BlockStructure ConcatenateHorizontal(BlockStructure BlockStructureInput, ClosedXML.Excel.XLColor NewBackGroundColor)
        {
            if (this.GetBlockSizeY().Equals(BlockStructureInput.GetBlockSizeY()).Equals(false))
            {
                return new BlockStructure();
            }
            var ReturnObject = new BlockStructure(this.GetBlockSizeX() + BlockStructureInput.GetBlockSizeX(), this.GetBlockSizeY());
            Parallel.For(0, this.GetBlockSizeY(), (y, stateY) =>
            {
                Parallel.For(0, this.GetBlockSizeX(), (x, stateX) =>
                {
                    ReturnObject.SetCell(this.GetCell(x, y), x, y);
                });
            });
            Parallel.For(0, BlockStructureInput.GetBlockSizeY(), (y, stateY) =>
            {
                Parallel.For(0, BlockStructureInput.GetBlockSizeX(), (x, stateX) =>
                {
                    ReturnObject.SetCell(BlockStructureInput.GetCell(x, y).SetBackGroundColor(NewBackGroundColor), x + this.GetBlockSizeX(), y);
                });
            });

            return ReturnObject;
        }

        public BlockStructure ConcatenateHorizontal(List<BlockStructure> BlockStructuresInput)
        {
            var ReturnObject = new BlockStructure(this);
            foreach (var EachBlockStructure in BlockStructuresInput)
            {
                ReturnObject = ReturnObject.ConcatenateHorizontal(EachBlockStructure);
            }
            return ReturnObject;
        }

        public BlockStructure ConcatenateHorizontalInverse(BlockStructure BlockStructureInput)
        {
            return BlockStructureInput.ConcatenateHorizontal(this);
        }

        public BlockStructure ConcatenateHorizontalInverse(BlockStructure BlockStructureInput, bool EnhancedMode = true)
        {
            return BlockStructureInput.ConcatenateHorizontal(this, true);
        }

        public BlockStructure ConcatenateVertical(BlockStructure BlockStructureInput)
        {
            if (this.GetBlockSizeX().Equals(BlockStructureInput.GetBlockSizeX()).Equals(false))
            {
                return new BlockStructure();
            }
            var ReturnObject = new BlockStructure(this.GetBlockSizeX(), this.GetBlockSizeY() + BlockStructureInput.GetBlockSizeY());
            Parallel.For(0, this.GetBlockSizeY(), (y, stateY) =>
            {
                Parallel.For(0, this.GetBlockSizeX(), (x, stateX) =>
                {
                    ReturnObject.SetCell(this.GetCell(x, y), x, y);
                });
            });
            Parallel.For(0, BlockStructureInput.GetBlockSizeY(), (y, stateY) =>
            {
                Parallel.For(0, BlockStructureInput.GetBlockSizeX(), (x, stateX) =>
                {
                    ReturnObject.SetCell(BlockStructureInput.GetCell(x, y), x, y + this.GetBlockSizeY());
                });
            });
            return ReturnObject;
        }

        /// <summary>
        /// if this.GetBlockSizeX() is not enough, SizeX would be extended in EnhancedMode=true
        /// </summary>
        /// <param name="BlockStructureInput"></param>
        /// <param name="EnhancedMode"></param>
        /// <returns></returns>
        public BlockStructure ConcatenateVertical(BlockStructure BlockStructureInput, bool EnhancedMode = true)
        {
            if (EnhancedMode && (this.GetBlockSizeX() < BlockStructureInput.GetBlockSizeX()))
            {
                return this.ConcatenateHorizontal(new BlockStructure((uint)(BlockStructureInput.GetBlockSizeX() - this.GetBlockSizeX()), (uint)this.GetBlockSizeY())).ConcatenateVertical(BlockStructureInput);
            }
            else if (EnhancedMode && (this.GetBlockSizeX() > BlockStructureInput.GetBlockSizeX()))
            {
                return this.ConcatenateVertical(BlockStructureInput.ConcatenateHorizontal(new BlockStructure(this.GetBlockSizeX() - BlockStructureInput.GetBlockSizeX(), BlockStructureInput.GetBlockSizeY())));
            }
            else
            {
                return this.ConcatenateVertical(BlockStructureInput);
            }
        }

        public BlockStructure ConcatenateVertical(BlockStructure BlockStructureInput, ClosedXML.Excel.XLColor NewBackGroundColor)
        {
            if (this.GetBlockSizeX().Equals(BlockStructureInput.GetBlockSizeX()).Equals(false))
            {
                return new BlockStructure();
            }
            var ReturnObject = new BlockStructure(this.GetBlockSizeX(), this.GetBlockSizeY() + BlockStructureInput.GetBlockSizeY());
            Parallel.For(0, this.GetBlockSizeY(), (y, stateY) =>
            {
                Parallel.For(0, this.GetBlockSizeX(), (x, stateX) =>
                {
                    ReturnObject.SetCell(this.GetCell(x, y), x, y);
                });
            });
            Parallel.For(0, BlockStructureInput.GetBlockSizeY(), (y, stateY) =>
            {
                Parallel.For(0, BlockStructureInput.GetBlockSizeX(), (x, stateX) =>
                {
                    ReturnObject.SetCell(BlockStructureInput.GetCell(x, y).SetBackGroundColor(NewBackGroundColor), x, y + this.GetBlockSizeY());
                });
            });
            return ReturnObject;
        }

        public BlockStructure ConcatenateVerticalInverse(BlockStructure BlockStructureInput)
        {
            return BlockStructureInput.ConcatenateVertical(this);
        }

        public BlockStructure ConcatenateVerticalInverse(BlockStructure BlockStructureInput, bool EnhancedMode = true)
        {
            return BlockStructureInput.ConcatenateVertical(this, EnhancedMode);
        }

        //    Reference: https://codereview.stackexchange.com/a/255308/231235
        public BlockStructure Convert<TResult>(Converter<CellStructure, TResult> converter)
            where TResult : unmanaged
        {
            if (this.TableArray is null)
            {
                throw new ArgumentNullException(nameof(this.TableArray));
            }

            if (converter is null)
            {
                throw new ArgumentNullException(nameof(converter));
            }

            TableArray.ConvertAll(converter);
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TargetString"></param>
        /// <returns>
        /// int:                                #Objects which content including TargetString
        /// List<Tuple<uint, uint></uint>>:        Location X and Y of objects which content including TargetString
        /// </returns>
        public Tuple<int, List<Tuple<uint, uint>>> Contains(string TargetString)
        {
            var TargetObjectLocation = new List<Tuple<uint, uint>>();

            Parallel.For(0, this.GetBlockSizeY(), (y, state) =>
            {
                for (uint x = 0; x < this.GetBlockSizeX(); x++)
                {
                    try
                    {
                        if (this.GetCell(x, y).GetString().Contains(TargetString))
                        {
                            TargetObjectLocation.Add(new Tuple<uint, uint>(x, (uint)y));
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            });

            return new Tuple<int, List<Tuple<uint, uint>>>(TargetObjectLocation.Count, TargetObjectLocation);
        }

        public int Count()
        {
            return this.GetBlockSizeX() * this.GetBlockSizeY();
        }

        public BlockStructure DeepClone()
        {
            return BaseClass.DeepClone(this); ;
        }

        public byte[] Serialize()
        {
            return BaseClass.Serialize(this);
        }

        public BlockStructure GetBottomRow()
        {
            return this.GetRow(this.GetBlockSizeY() - 1);
        }

        public BlockStructure GetColumn(int ColumnIndex)
        {
            return this.SubBlock(new Tuple<int, int>(ColumnIndex, 0), 1, this.GetBlockSizeY());
        }

        public BlockStructure GetTopRow()
        {
            return this.GetRow(0);
        }

        /// <summary>
        /// GetTopRows method usage example
        /// 
        /// BlockStructure1.Print()
        /// A1    B1    C1    D1    E1    
        /// A2    B2    C2    D2    E2    
        /// A3    B3    C3    D3    E3    
        /// A4    B4    C4    D4    E4    
        /// A5    B5    C5    D5    E5    
        /// 
        /// BlockStructure1.GetTopRows(2).Print()
        /// A1    B1    C1    D1    E1    
        /// A2    B2    C2    D2    E2    
        /// 
        /// </summary>
        /// <param name="RowCount"></param>
        /// <returns></returns>
        public BlockStructure GetTopRows(int RowCount)
        {
            BlockStructure ReturnObject = new BlockStructure();
            if (RowCount >= 1)
            {
                ReturnObject = this.GetRow(0);
            }
            for (int i = 1; i < RowCount; i++)
            {
                ReturnObject = ReturnObject.ConcatenateVertical(this.GetRow(i));
            }
            return ReturnObject;
        }

        public BlockStructure GetRow(int RowIndex)
        {
            return this.SubBlock(new Tuple<int, int>(0, RowIndex), this.GetBlockSizeX(), 1);
        }

        public List<BlockStructure> GetRows(IEnumerable<int> RowIndexes)
        {
            List<BlockStructure> ReturnObject = new List<BlockStructure>();
            foreach (var item in RowIndexes)
            {
                ReturnObject.Add(this.GetRow(item));
            }
            return ReturnObject;
        }

        public bool IsEmpty()
        {
            for (long rowIndex = 0; rowIndex < this.GetBlockSizeY(); rowIndex++)
            {
                for (long columnIndex = 0; columnIndex < this.GetBlockSizeX(); columnIndex++)
                {
                    if (!String.IsNullOrEmpty(this.GetCell(columnIndex, rowIndex).GetString()))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public double Maximum()
        {
            var output = GetCell(0, 0).GetDouble().Value;
            for (int y = 0; y < this.GetBlockSizeY(); y++)
            {
                for (int x = 0; x < this.GetBlockSizeX(); x++)
                {
                    if (output < GetCell(x, y).GetDouble().Value)
                    {
                        output = GetCell(x, y).GetDouble().Value;
                    }
                }
            }
            return output;
        }

        public BlockStructure Paste(Tuple<int, int> location, BlockStructure plane)
        {
            var output = new BlockStructure(
                Math.Max(location.Item1 + plane.GetBlockSizeX(), GetBlockSizeX()),
                Math.Max(location.Item2 + plane.GetBlockSizeY(), GetBlockSizeY())
                );
            for (int y = 0; y < GetBlockSizeY(); y++)
            {
                for (int x = 0; x < GetBlockSizeX(); x++)
                {
                    output.SetCell(GetCell(x, y), x, y);
                }
            }

            for (int x = 0; x < plane.GetBlockSizeX(); x++)
            {
                for (int y = 0; y < plane.GetBlockSizeY(); y++)
                {
                    output = output.SetCell(plane.GetCell(x, y), location.Item1 + x, location.Item2 + y).Item2;
                }
            }
            return output;
        }

        public BlockStructure Paste(in Tuple<int, int> location, in CellStructure cellStructure)
        {
            return Paste(location, new BlockStructure(1, 1, cellStructure));
        }

        public BlockStructure PasteLeftToRight(in Tuple<int, int> location, in List<CellStructure> input)
        {
            var output = this;
            for (int i = 0; i < input.Count; i++)
            {
                output = output.Paste(new Tuple<int, int>(location.Item1 + i, location.Item2), input[i]);
            }
            return output;
        }

        public BlockStructure RemoveBottomRows(in int Count)
        {
            //    this = this.SubBlock(new Tuple<int, int>(0, 0), this.GetBlockSizeX(), this.GetBlockSizeY() - Count);
            TableArray = SubBlock(new Tuple<int, int>(0, 0), this.GetBlockSizeX(), this.GetBlockSizeY() - Count).TableArray;
            return this;
        }

        public BlockStructure RemoveLeftColumns(in int Count)
        {
            //    this = this.SubBlock(new Tuple<int, int>(Count, 0), this.GetBlockSizeX() - Count, this.GetBlockSizeY());
            TableArray = SubBlock(new Tuple<int, int>(Count, 0), this.GetBlockSizeX() - Count, this.GetBlockSizeY()).TableArray;
            return this;
        }

        public BlockStructure RemoveRightColumns(in int Count)
        {
            //    this = this.SubBlock(new Tuple<int, int>(0, 0), this.GetBlockSizeX() - Count, this.GetBlockSizeY());
            TableArray = SubBlock(new Tuple<int, int>(0, 0), this.GetBlockSizeX() - Count, this.GetBlockSizeY()).TableArray;
            return this;
        }

        public BlockStructure RemoveTopRows(in int Count)
        {
            //    this = this.SubBlock(new Tuple<int, int>(0, Count), this.GetBlockSizeX(), this.GetBlockSizeY() - Count);
            TableArray = SubBlock(new Tuple<int, int>(0, Count), this.GetBlockSizeX(), this.GetBlockSizeY() - Count).TableArray;
            return this;
        }

        public BlockStructure RemoveRow(int index)
        {
            if (index < 0 || index >= GetBlockSizeY())
                throw new ArgumentOutOfRangeException(nameof(index));

            BlockStructure bottomPart = SubBlock(new Tuple<int, int>(0, index + 1), GetBlockSizeX(), GetBlockSizeY() - index - 1);
            if (index == 0)
            {
                return bottomPart;
            }

            BlockStructure topPart = SubBlock(new Tuple<int, int>(0, 0), GetBlockSizeX(), index);
            if (index == (GetBlockSizeY() - 1))
            {
                return topPart;
            }
            return topPart.ConcatenateVertical(bottomPart);
        }

        public BlockStructure RemoveColumn(int index)
        {
            if (index < 0 || index >= GetBlockSizeX())
                throw new ArgumentOutOfRangeException(nameof(index));

            BlockStructure rightPart = SubBlock(new Tuple<int, int>(index + 1, 0), GetBlockSizeX() - index - 1, GetBlockSizeY());
            if (index == 0)
            {
                return rightPart;
            }
            BlockStructure leftPart = SubBlock(new Tuple<int, int>(0, 0), index, GetBlockSizeY());
            if (index == (GetBlockSizeX() - 1))
            {
                return leftPart;
            }
            return leftPart.ConcatenateHorizontal(rightPart);
        }

        public BlockStructure InsertRow(int index, CellStructure initialCell = null)
        {
            if (index < 0 || index > GetBlockSizeY())
                throw new ArgumentOutOfRangeException(nameof(index));

            // Initialize the new row with default or provided cells
            CellStructure cell = initialCell ?? new CellStructure("");
            BlockStructure newRow = new BlockStructure(GetBlockSizeX(), 1, cell);

            // If the block is empty, return the new row directly
            if (GetBlockSizeY() == 0)
            {
                return newRow;
            }

            BlockStructure bottomPart = SubBlock(new Tuple<int, int>(0, index), GetBlockSizeX(), GetBlockSizeY() - index);

            // If the index is 0, we can directly concatenate the new row with the bottom part
            if (index == 0)
            {
                return newRow.ConcatenateVertical(bottomPart);
            }

            // Split the original block into parts above and below the insertion point
            BlockStructure topPart = SubBlock(new Tuple<int, int>(0, 0), GetBlockSizeX(), index);
            
            // Concatenate the parts with the new row in between
            return topPart.ConcatenateVertical(newRow).ConcatenateVertical(bottomPart);
        }

        public BlockStructure InsertColumn(int index, CellStructure initialCell = null)
        {
            if (index < 0 || index > GetBlockSizeX())
                throw new ArgumentOutOfRangeException(nameof(index));

            // Initialize the new column with default or provided cells
            CellStructure cell = initialCell ?? new CellStructure("");
            BlockStructure newColumn = new BlockStructure(1, GetBlockSizeY(), cell);

            // If the block is empty, return the new column directly
            if (GetBlockSizeX() == 0)
            {
                return newColumn;
            }

            BlockStructure rightPart = SubBlock(new Tuple<int, int>(index, 0), GetBlockSizeX() - index, GetBlockSizeY());

            // If the index is 0, we can directly concatenate the new column with the right part
            if (index == 0)
            {
                return newColumn.ConcatenateHorizontal(rightPart);
            }

            // Split the original block into parts left and right of the insertion point
            BlockStructure leftPart = SubBlock(new Tuple<int, int>(0, 0), index, GetBlockSizeY());
            
            // Concatenate the parts with the new column in between
            return leftPart.ConcatenateHorizontal(newColumn).ConcatenateHorizontal(rightPart);
        }

        public BlockStructure SubBlock(in System.Drawing.Point Location, in uint SizeX, in uint SizeY)
        {
            return SubBlock(Location, (int)SizeX, (int)SizeY);
        }

        public BlockStructure SubBlock(System.Drawing.Point Location, int SizeX, int SizeY)
        {
            return SubBlock(new Tuple<int, int>(Location.X, Location.Y), SizeX, SizeY);
        }

        public BlockStructure SubBlock(Tuple<int, int> Location, uint SizeX, uint SizeY)
        {
            return SubBlock(new Tuple<int, int>((int)Location.Item1, (int)Location.Item2), (int)SizeX, (int)SizeY);
        }

        public BlockStructure SubBlock(Tuple<int, int> Location, int SizeX, int SizeY)
        {
            var ReturnObject = new BlockStructure(SizeX, SizeY);
            Parallel.For(0, SizeY, (y, stateY) =>
            {
                Parallel.For(0, SizeX, (x, stateX) =>
                {
                    ReturnObject.SetCell(GetCell(Location.Item1 + x, Location.Item2 + y), x, y);
                });
            });
            return ReturnObject;
        }

        /// <summary>
        /// Determine the similarity of two BlockStructure
        /// if BlockStructureInput is totally as same as this, return 1.
        /// if the contents of some of cells in BlockStructureInput is as same as those (with same location) in this,
        /// return SameCellCount / TotalCells
        /// </summary>
        /// <param name="BlockStructureInput"></param>
        /// <returns></returns>
        public double Similarity(BlockStructure BlockStructureInput)
        {
            if (this.GetBlockSizeX().Equals(BlockStructureInput.GetBlockSizeX()).Equals(false) ||
                this.GetBlockSizeY().Equals(BlockStructureInput.GetBlockSizeY()).Equals(false)
                )            //    Size is different
            {
                return 0;
            }

            double TotalCells = GetBlockSizeX() * GetBlockSizeY();
            double SameCellCount = 0;

            for (int y = 0; y < GetBlockSizeY(); y++)
            {
                for (int x = 0; x < GetBlockSizeX(); x++)
                {
                    if (GetCell(x, y).Equals(BlockStructureInput.GetCell(x, y)))
                    {
                        SameCellCount = SameCellCount + 1;
                    }
                }
            }

            return SameCellCount / TotalCells;
        }

        public double SimilarityWithoutBlank(BlockStructure BlockStructureInput)
        {
            if (this.GetBlockSizeX().Equals(BlockStructureInput.GetBlockSizeX()).Equals(false) ||
                this.GetBlockSizeY().Equals(BlockStructureInput.GetBlockSizeY()).Equals(false)
                )            //    Size is different
            {
                return 0;
            }

            //    Count #non-blank cells
            double TotalNotBlankCells = 0;
            for (int y = 0; y < this.GetBlockSizeY(); y++)
            {
                for (int x = 0; x < this.GetBlockSizeX(); x++)
                {
                    if (this.GetCell(x, y).IsNullOrEmpty().Equals(false))
                    {
                        TotalNotBlankCells = TotalNotBlankCells + 1;
                    }
                }
            }

            double SameCellCount = 0;
            for (int y = 0; y < this.GetBlockSizeY(); y++)
            {
                for (int x = 0; x < this.GetBlockSizeX(); x++)
                {
                    if (this.GetCell(x, y).Equals(BlockStructureInput.GetCell(x, y)) &&
                        this.GetCell(x, y).IsNullOrEmpty().Equals(false)
                        )
                    {
                        SameCellCount = SameCellCount + 1;
                    }
                }
            }

            return SameCellCount / TotalNotBlankCells;
        }

        public double Sum()
        {
            double output = 0;
            for (int y = 0; y < GetBlockSizeY(); y++)
            {
                for (int x = 0; x < GetBlockSizeX(); x++)
                {
                    output = output + GetCell(x, y).GetDouble().GetValueOrDefault(0);
                }
            }
            return output;
        }

        //  SumHorizontal method
        public BlockStructure SumHorizontal()
        {
            BlockStructure output = new BlockStructure(1, GetBlockSizeY());
            for (int y = 0; y < GetBlockSizeY(); y++)
            {
                output.SetCell(
                    new CellStructure(
                        SubBlock(new Point(0, y), GetBlockSizeX(), 1).Sum().ToString()),
                    0,
                    y);
            }
            return output;
        }

        //  ElementWiseAdd method
        public BlockStructure ElementWiseAdd(BlockStructure input)
        {
            if (input == null) throw new ArgumentNullException("input is null!");
            if ((GetBlockSizeX() != input.GetBlockSizeX()) ||
                (GetBlockSizeY() != input.GetBlockSizeY()))
            {
                throw new ArgumentException("Block size mismatch!");
            }
            BlockStructure output = new BlockStructure(GetBlockSizeX(), GetBlockSizeY());
            for (int y = 0; y < GetBlockSizeY(); y++)
            {
                for (int x = 0; x < GetBlockSizeX(); x++)
                {
                    output.SetCell(
                        new CellStructure(
                            (GetCell(x, y).GetDouble().GetValueOrDefault(0) +
                             input.GetCell(x, y).GetDouble().GetValueOrDefault(0)).ToString()
                            ),
                        x,
                        y
                        );
                }
            }
            return output;
        }

        //  ElementWiseSubtract method
        public BlockStructure ElementWiseSubtract(BlockStructure input)
        {
            if (input == null) throw new ArgumentNullException("input is null!");
            if ((GetBlockSizeX() != input.GetBlockSizeX()) ||
                (GetBlockSizeY() != input.GetBlockSizeY()))
            {
                throw new ArgumentException("Block size mismatch!");
            }
            BlockStructure output = new BlockStructure(GetBlockSizeX(), GetBlockSizeY());
            for (int y = 0; y < GetBlockSizeY(); y++)
            {
                for (int x = 0; x < GetBlockSizeX(); x++)
                {
                    output.SetCell(
                        new CellStructure(
                            (GetCell(x, y).GetDouble().GetValueOrDefault(0) -
                             input.GetCell(x, y).GetDouble().GetValueOrDefault(0)).ToString()
                            ),
                        x,
                        y
                        );
                }
            }
            return output;
        }

        //  ElementWiseMultiply method
        public BlockStructure ElementWiseMultiply(BlockStructure input)
        {
            if (input == null) throw new ArgumentNullException("input is null!");
            if ((GetBlockSizeX() != input.GetBlockSizeX()) ||
                (GetBlockSizeY() != input.GetBlockSizeY()))
            {
                throw new ArgumentException("Block size mismatch!");
            }
            BlockStructure output = new BlockStructure(GetBlockSizeX(), GetBlockSizeY());
            for (int y = 0; y < GetBlockSizeY(); y++)
            {
                for (int x = 0; x < GetBlockSizeX(); x++)
                {
                    output.SetCell(
                        new CellStructure(
                            (GetCell(x, y).GetDouble().GetValueOrDefault(0) *
                             input.GetCell(x, y).GetDouble().GetValueOrDefault(0)).ToString()
                            ),
                        x,
                        y
                        );
                }
            }
            return output;
        }

        public BlockStructure Multiply(double input)
        {
            return ElementWiseMultiply(
                new BlockStructure(
                    GetBlockSizeX(),
                    GetBlockSizeY(),
                    new CellStructure(input.ToString())
                    ));
        }

        //  ElementWiseDivide method
        public BlockStructure ElementWiseDivide(BlockStructure input)
        {
            if (input == null) throw new ArgumentNullException("input is null!");
            if ((GetBlockSizeX() != input.GetBlockSizeX()) ||
                (GetBlockSizeY() != input.GetBlockSizeY()))
            {
                throw new ArgumentException("Block size mismatch!");
            }
            BlockStructure output = new BlockStructure(GetBlockSizeX(), GetBlockSizeY());
            for (int y = 0; y < GetBlockSizeY(); y++)
            {
                for (int x = 0; x < GetBlockSizeX(); x++)
                {
                    output.SetCell(
                        new CellStructure(
                            (GetCell(x, y).GetDouble().GetValueOrDefault(0) /
                             input.GetCell(x, y).GetDouble().GetValueOrDefault(0)).ToString()
                            ),
                        x,
                        y
                        );
                }
            }
            return output;
        }

        public List<BlockStructure> ToColumnList()
        {
            List<BlockStructure> ReturnObject = new List<BlockStructure>();
            for (int ColumnIndex = 0; ColumnIndex < GetBlockSizeX(); ColumnIndex++)
            {
                ReturnObject.Add(GetColumn(ColumnIndex));
            }
            return ReturnObject;
        }

        public List<BlockStructure> ToColumnListWithFiltering(Func<BlockStructure, bool> Filter)
        {
            return ToColumnList().Where(Filter).ToList();
        }

        public void ShowDataGridView(ref DataGridView DataGridViewInput)
        {
            DataGridViewInput.ClearSelection();
            DataGridViewInput.CurrentCell = null;
            DataGridViewInput.Enabled = false;
            DataGridViewInput.Rows.Clear();
            DataGridViewInput.Columns.Clear();

            //    Construct Columns
            DataGridViewInput.ColumnCount = GetBlockSizeX();
            for (int ConstructColumns = 0; ConstructColumns < DataGridViewInput.ColumnCount; ConstructColumns++)
            {
                DataGridViewInput.Columns[ConstructColumns].Name = ConstructColumns.ToString();
            }

            //    Update grids on UI (string)
            for (uint y = 0; y < this.GetBlockSizeY(); y++)
            {
                List<string> RowData = new List<string>();
                for (uint x = 0; x < GetBlockSizeX(); x++)
                {
                    RowData.Add(GetCell(x, y).GetString());
                }
                DataGridViewInput.Rows.Add(RowData.ToArray());
            }

            var NewDataGridView = DataGridViewInput;
            Parallel.For(0, GetBlockSizeY(), (y, StateY) =>
            {
                Parallel.For(0, GetBlockSizeX(), (x, StateX) =>
                {
                    if (GetCell(x, y).IsBackGroundColorUsed())
                    {
                        DataGridViewCell TargetCell = NewDataGridView.Rows[(int)y].Cells[(int)x];
                        XLColor xLColor = GetCell(x, y).GetBackGroundColor();
                        TargetCell.Style.BackColor = System.Drawing.Color.FromArgb(
                            xLColor.Color.ToArgb());
                    }
                });
            });
            DataGridViewInput = NewDataGridView;
            DataGridViewInput.Enabled = true;
        }

        public void FromDataGridView(ref DataGridView dataGridView)
        {
            xsize = dataGridView.Columns.Count;
            ysize = dataGridView.Rows.Count;
            for (int y = 0; y < ysize; y++)
            {
                for (int x = 0; x < xsize; x++)
                {
                    if (!(dataGridView.Rows[y].Cells[x].Value == null))
                    {
                        SetCell(new CellStructure(dataGridView.Rows[y].Cells[x].Value.ToString()), x, y);
                    }
                    else
                    {
                        SetCell(new CellStructure(), x, y);
                    }
                }
            }
        }

        public List<BlockStructure> ToRowList()
        {
            List<BlockStructure> ReturnObject = new List<BlockStructure>();
            for (int RowIndex = 0; RowIndex < this.GetBlockSizeY(); RowIndex++)
            {
                ReturnObject.Add(this.GetRow(RowIndex));
            }
            return ReturnObject;
        }

        public List<BlockStructure> ToRowListWithFiltering(Func<BlockStructure, bool> Filter)
        {
            return this.ToRowList().Where(Filter).ToList();
        }

        public int GetBlockSizeX()
        {
            return xsize;
        }

        public int GetBlockSizeY()
        {
            return ysize;
        }

        public Tuple<int, List<Tuple<uint, uint>>> GetLocationsByLabelContains(string LabelInput)
        {
            var TargetObjectLocation = new List<Tuple<uint, uint>>();
            for (int y = 0; y < GetBlockSizeY(); y++)
            {
                for (uint x = 0; x < GetBlockSizeX(); x++)
                {
                    if (GetCell(x, y).IsLabelContains(LabelInput))
                    {
                        TargetObjectLocation.Add(new Tuple<uint, uint>(x, (uint)y));
                    }
                }
            }
            return new Tuple<int, List<Tuple<uint, uint>>>(TargetObjectLocation.Count, TargetObjectLocation);
        }

        public Tuple<int, List<Tuple<uint, uint>>> GetLocationsByLabel(string LabelInput)
        {
            var TargetObjectLocation = new List<Tuple<uint, uint>>();
            for (uint y = 0; y < GetBlockSizeY(); y++)
            {
                for (uint x = 0; x < GetBlockSizeX(); x++)
                {
                    if (GetCell(x, y).IsLabelExist(LabelInput))
                    {
                        TargetObjectLocation.Add(new Tuple<uint, uint>(x, y));
                    }
                }
            }
            return new Tuple<int, List<Tuple<uint, uint>>>(TargetObjectLocation.Count, TargetObjectLocation);
        }

        public void Print()
        {
            for (uint y = 0; y < GetBlockSizeY(); y++)
            {
                for (uint x = 0; x < GetBlockSizeX(); x++)
                {
                    Console.Write(GetCell(x, y).GetString() + "\t");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Find method
        /// </summary>
        /// <param name="TargetString"></param>
        /// <returns>
        /// int:                                    #Found objects
        /// List<Tuple<uint, uint></uint>>:         Location X and Y of found objects
        /// </returns>
        public Tuple<int, List<Tuple<uint, uint>>> Find(string TargetString)
        {
            var TargetObjectLocation = new List<Tuple<uint, uint>>();
            if (false)               //    Use serial method
            {
                for (int y = 0; y < GetBlockSizeY(); y++)
                {
                    for (uint x = 0; x < GetBlockSizeX(); x++)
                    {
                        if (GetCell(x, y).GetString().Equals(TargetString))
                        {
                            TargetObjectLocation.Add(new Tuple<uint, uint>(x, (uint)y));
                        }
                    }
                }
            }
            else
            {
                Parallel.For(0, GetBlockSizeY(), (y, state) =>
                {
                    for (uint x = 0; x < GetBlockSizeX(); x++)
                    {
                        if (GetCell(x, y).GetString().Equals(TargetString))
                        {
                            TargetObjectLocation.Add(new Tuple<uint, uint>(x, (uint)y));
                        }
                    }
                });
            }
            return new Tuple<int, List<Tuple<uint, uint>>>(TargetObjectLocation.Count, TargetObjectLocation);
        }



        public BlockStructure RemoveLabelsContains(string LabelInput)
        {
            Parallel.For(0, GetBlockSizeY(), (y, state) =>
            {
                for (uint x = 0; x < GetBlockSizeX(); x++)
                {
                    SetCell(GetCell(x, y).RemoveLabelsContains(LabelInput), x, y);
                }
            });
            return this;
        }

        public BlockStructure RemoveLabel(string LabelInput)
        {
            Parallel.For(0, this.GetBlockSizeY(), (y, state) =>
            {
                for (uint x = 0; x < this.GetBlockSizeX(); x++)
                {
                    this.SetCell(this.GetCell(x, y).RemoveLabel(LabelInput), x, y);
                }
            });
            return this;
        }

        //  WriteCSV method
        public void WriteCSV(string filename)
        {
            StringBuilder output = new StringBuilder();

            for (uint y = 0; y < this.GetBlockSizeY(); y++)
            {
                for (uint x = 0; x < this.GetBlockSizeX(); x++)
                {
                    output.Append(this.GetCell(x, y).GetString() + ",");
                }
                output.AppendLine();
            }
            File.WriteAllText(filename, output.ToString());
        }

        public void WriteExcel(string filename, string workbookname = "Sheet1")
        {
            // Create Workbook
            IXLWorkbook workbook = new XLWorkbook();

            // Create Table
            IXLWorksheet worksheet = workbook.Worksheets.Add(workbookname);
            for (int y = 0; y < this.GetBlockSizeY(); y++)
            {
                for (int x = 0; x < this.GetBlockSizeX(); x++)
                {
                    worksheet.Cell(x + 1, y + 1).Value = GetCell(y, x).GetString();
                }
            }

            // Save
            workbook.SaveAs(filename);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            for (uint y = 0; y < this.GetBlockSizeY(); y++)
            {
                for (uint x = 0; x < this.GetBlockSizeX(); x++)
                {
                    output.Append(this.GetCell(x, y).GetString() + "\t");
                }
                output.AppendLine();
            }
            return output.ToString();
        }

        public override bool Equals(object obj)
        {
            var Instance = obj as BlockStructure;
            if (Instance == null)
            {
                return false;
            }
            if (Instance.GetBlockSizeX().Equals(this.GetBlockSizeX()).Equals(false))
            {
                return false;
            }
            if (Instance.GetBlockSizeY().Equals(this.GetBlockSizeY()).Equals(false))
            {
                return false;
            }
            for (uint y = 0; y < this.GetBlockSizeY(); y++)
            {
                for (uint x = 0; x < this.GetBlockSizeX(); x++)
                {
                    if (this.GetCell(x, y).GetString().Equals(
                        Instance.GetCell(x, y).GetString()
                        ).Equals(false))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            //  Based on https://stackoverflow.com/a/61000527/6667035
            byte[] encoded = System.Security.Cryptography.SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(this.ToString()));
            return BitConverter.ToInt32(encoded, 0);
        }
    }
}
