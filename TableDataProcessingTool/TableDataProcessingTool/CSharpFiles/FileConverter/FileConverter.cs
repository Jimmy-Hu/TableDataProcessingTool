using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableDataProcessingTool.CSharpFiles
{
	public class FileConverter
	{
		public FileConverter(string Filename, string OutputFolder)
		{
			string OutputFilename =
				OutputFolder +
				"\\" + System.IO.Path.GetFileNameWithoutExtension(Filename) + ".sheets";

			new CSharpFiles.SheetFileStructure(Filename).Save(OutputFilename);
		}
	}
}
