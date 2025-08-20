using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableDataProcessingTool2.CSharpFiles
{
    public class FileConverter
    {
        public FileConverter(string Filename, string OutputFolder)
        {
            string OutputFilename =
                OutputFolder +
                "\\" + System.IO.Path.GetFileNameWithoutExtension(Filename) + ".sheets2";
            //  Reference: https://stackoverflow.com/a/58074654/6667035
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            new CSharpFiles.SheetFileStructure(Filename).Save(OutputFilename);
}
