using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableDataProcessingTool.CSharpFiles
{
    [Serializable]
    public class SheetStructure : BaseClass
    {
        private uint SheetIndex = 0;
        private string SheetName = "New Sheet";
        private BlockStructure BlockStructureObject;

        public SheetStructure(BlockStructure BlockStructureInput)
        {
            this.BlockStructureObject = BlockStructureInput;
        }
        public SheetStructure(uint SheetSizeXInput, uint SheetSizeYInput)
        {
            this.BlockStructureObject = new BlockStructure(SheetSizeXInput, SheetSizeYInput);
        }


        public SheetStructure(uint SheetIndexInput, uint SheetSizeXInput, uint SheetSizeYInput)
        {
            this.SheetIndex = SheetIndexInput;
            this.SheetName = "New Sheet";
            this.BlockStructureObject = new BlockStructure(SheetSizeXInput, SheetSizeYInput);
        }

        public SheetStructure(uint SheetIndexInput, string SheetNameInput, uint SheetSizeXInput, uint SheetSizeYInput)
        {
            this.SheetIndex = SheetIndexInput;
            this.SheetName = SheetNameInput;
            this.BlockStructureObject = new BlockStructure(SheetSizeXInput, SheetSizeYInput);
        }
        public SheetStructure(uint SheetIndexInput, string SheetNameInput, BlockStructure BlockStructureInput)
        {
            this.SheetIndex = SheetIndexInput;
            this.SheetName = SheetNameInput;
            this.BlockStructureObject = BlockStructureInput;
        }

        public SheetStructure DeepClone()
        {
            return (SheetStructure)DeepClone(this);
        }

        public int GetSizeX()
        {
            return this.BlockStructureObject.GetBlockSizeX();
        }

        public int GetSizeY()
        {
            return this.BlockStructureObject.GetBlockSizeY();
        }

        public BlockStructure GetBlockStructure()
        {
            return this.BlockStructureObject;
        }

        public SheetStructure SetBlockStructure(BlockStructure BlockStructureInput)
        {
            this.BlockStructureObject = BlockStructureInput;
            return this;
        }

        public string GetSheetName()
        {
            return this.SheetName;
        }

        public SheetStructure SetSheetName(string InputSheetName)
        {
            this.SheetName = InputSheetName;
            return this;
        }
        public void Print()
        {
            Console.WriteLine("SheetIndex:\t" + SheetIndex.ToString());
            Console.WriteLine("SheetName:\t" + SheetName);
            this.BlockStructureObject.Print();
        }

    }
}
