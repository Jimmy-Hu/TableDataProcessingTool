using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableDataProcessingTool.CSharpFiles
{
    [Serializable]
    public class BlockStructure : BaseClass
    {
        private Array TableArray;
        
        public BlockStructure()
        {
            this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
        }

        public BlockStructure(BlockStructure BlockStructureInput)
        {
            this.TableArray = BlockStructureInput.TableArray;
        }

        //    Is generic constructor in non-generic class supported?
        //    https://stackoverflow.com/a/3606951/6667035

        public BlockStructure(sbyte SheetSizeXInput, sbyte SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(sbyte SheetSizeXInput, sbyte SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(byte SheetSizeXInput, sbyte SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(byte SheetSizeXInput, sbyte SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(short SheetSizeXInput, sbyte SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(short SheetSizeXInput, sbyte SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(ushort SheetSizeXInput, sbyte SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(ushort SheetSizeXInput, sbyte SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(int SheetSizeXInput, sbyte SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(int SheetSizeXInput, sbyte SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(uint SheetSizeXInput, sbyte SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(uint SheetSizeXInput, sbyte SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(sbyte SheetSizeXInput, byte SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(sbyte SheetSizeXInput, byte SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(byte SheetSizeXInput, byte SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(byte SheetSizeXInput, byte SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(short SheetSizeXInput, byte SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(short SheetSizeXInput, byte SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(ushort SheetSizeXInput, byte SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(ushort SheetSizeXInput, byte SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(int SheetSizeXInput, byte SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(int SheetSizeXInput, byte SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(uint SheetSizeXInput, byte SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(uint SheetSizeXInput, byte SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(sbyte SheetSizeXInput, short SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(sbyte SheetSizeXInput, short SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(byte SheetSizeXInput, short SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(byte SheetSizeXInput, short SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(short SheetSizeXInput, short SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(short SheetSizeXInput, short SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(ushort SheetSizeXInput, short SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(ushort SheetSizeXInput, short SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(int SheetSizeXInput, short SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(int SheetSizeXInput, short SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(uint SheetSizeXInput, short SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(uint SheetSizeXInput, short SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(sbyte SheetSizeXInput, ushort SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(sbyte SheetSizeXInput, ushort SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(byte SheetSizeXInput, ushort SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(byte SheetSizeXInput, ushort SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(short SheetSizeXInput, ushort SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(short SheetSizeXInput, ushort SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(ushort SheetSizeXInput, ushort SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(ushort SheetSizeXInput, ushort SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(int SheetSizeXInput, ushort SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(int SheetSizeXInput, ushort SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(uint SheetSizeXInput, ushort SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(uint SheetSizeXInput, ushort SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(sbyte SheetSizeXInput, int SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(sbyte SheetSizeXInput, int SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(byte SheetSizeXInput, int SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(byte SheetSizeXInput, int SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(short SheetSizeXInput, int SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(short SheetSizeXInput, int SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(ushort SheetSizeXInput, int SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(ushort SheetSizeXInput, int SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(int SheetSizeXInput, int SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(int SheetSizeXInput, int SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(uint SheetSizeXInput, int SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(uint SheetSizeXInput, int SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(sbyte SheetSizeXInput, uint SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(sbyte SheetSizeXInput, uint SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(byte SheetSizeXInput, uint SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(byte SheetSizeXInput, uint SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(short SheetSizeXInput, uint SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(short SheetSizeXInput, uint SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(ushort SheetSizeXInput, uint SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(ushort SheetSizeXInput, uint SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(int SheetSizeXInput, uint SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(int SheetSizeXInput, uint SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(uint SheetSizeXInput, uint SheetSizeYInput)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(new CellStructure(""));
        }

        public BlockStructure(uint SheetSizeXInput, uint SheetSizeYInput, CellStructure InitialValue)
        {
            if (SheetSizeXInput < 0 || SheetSizeYInput < 0)
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), 1, 1);
            }
            else
            {
                this.TableArray = Array.CreateInstance(typeof(CellStructure), SheetSizeXInput + 1, SheetSizeYInput + 1);
            }
            this.SetCell(InitialValue);
        }

        public BlockStructure(string InputString)
        {
            return;
        }

        public BlockStructure(Array input)
        {
            this.TableArray = input;
        }

        public BlockStructure AddLabel(List<Tuple<int, int>> Locations, string LabelInput)
        {
            foreach (var EachLocation in Locations)
            {
                this.AddLabel(EachLocation, 1, 1, LabelInput);
            }
            return this;
        }

        public BlockStructure AddLabel(Tuple<int, int> TopLeftLocation, int SizeX, int SizeY, string LabelInput)
        {
            return this.AddLabel(
                new System.Drawing.Point(TopLeftLocation.Item1, TopLeftLocation.Item2),
                (uint)SizeX,
                (uint)SizeY,
                LabelInput);
        }
        /*
        public BlockStructure AddLabel<T1, T2>(Tuple<T1, T2> TopLeftLocation, int SizeX, int SizeY, string LabelInput)
             where T1 : IConvertible
             where T2 : IConvertible
        {
            return this.AddLabel(
                new System.Drawing.Point(TopLeftLocation.Item1.ToInt32(), (int)TopLeftLocation.Item2.ToInt32()),
                (uint)SizeX,
                (uint)SizeY,
                LabelInput);
        }
        */

        public BlockStructure AddLabel(System.Drawing.Point TopLeftLocation, int SizeX, int SizeY, string LabelInput)
        {
            return this.AddLabel(
                TopLeftLocation,
                (uint)SizeX,
                (uint)SizeY,
                LabelInput);
        }

        public BlockStructure AddLabel(System.Drawing.Point TopLeftLocation, uint SizeX, uint SizeY, string LabelInput)
        {
            Parallel.For(0, SizeY, (LoopNumberY, stateY) =>
            {
                Parallel.For(0, SizeX, (LoopNumberX, stateX) =>
                {
                    this.SetCell(this.GetCell(TopLeftLocation.X + LoopNumberX, TopLeftLocation.Y + LoopNumberY).AddLabel(LabelInput), TopLeftLocation.X + LoopNumberX, TopLeftLocation.Y + LoopNumberY);
                });
            });
            return this;
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
            Parallel.For(0, this.GetBlockSizeY(), (LoopNumberY, stateY) =>
            {
                Parallel.For(0, this.GetBlockSizeX(), (LoopNumberX, stateX) =>
                {
                    ReturnObject.SetCell(this.GetCell(LoopNumberX, LoopNumberY), LoopNumberX, LoopNumberY);
                });
            });
            Parallel.For(0, BlockStructureInput.GetBlockSizeY(), (LoopNumberY, stateY) =>
            {
                Parallel.For(0, BlockStructureInput.GetBlockSizeX(), (LoopNumberX, stateX) =>
                {
                    ReturnObject.SetCell(BlockStructureInput.GetCell(LoopNumberX, LoopNumberY), LoopNumberX + this.GetBlockSizeX(), LoopNumberY);
                });
            });

            return ReturnObject;
        }

        public BlockStructure ConcatenateHorizontal(BlockStructure BlockStructureInput, bool EnhancedMode)
        {
            if (EnhancedMode.Equals(true) && this.GetBlockSizeY() < BlockStructureInput.GetBlockSizeY())
            {
                return this.ConcatenateVertical(new BlockStructure(this.GetBlockSizeX(), BlockStructureInput.GetBlockSizeY() - this.GetBlockSizeY())).ConcatenateHorizontal(BlockStructureInput);
            }
            else if (EnhancedMode.Equals(true) && this.GetBlockSizeY() > BlockStructureInput.GetBlockSizeY())
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
            Parallel.For(0, this.GetBlockSizeY(), (LoopNumberY, stateY) =>
            {
                Parallel.For(0, this.GetBlockSizeX(), (LoopNumberX, stateX) =>
                {
                    ReturnObject.SetCell(this.GetCell(LoopNumberX, LoopNumberY), LoopNumberX, LoopNumberY);
                });
            });
            Parallel.For(0, BlockStructureInput.GetBlockSizeY(), (LoopNumberY, stateY) =>
            {
                Parallel.For(0, BlockStructureInput.GetBlockSizeX(), (LoopNumberX, stateX) =>
                {
                    ReturnObject.SetCell(BlockStructureInput.GetCell(LoopNumberX, LoopNumberY).SetBackGroundColor(NewBackGroundColor), LoopNumberX + this.GetBlockSizeX(), LoopNumberY);
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
            Parallel.For(0, this.GetBlockSizeY(), (LoopNumberY, stateY) =>
            {
                Parallel.For(0, this.GetBlockSizeX(), (LoopNumberX, stateX) =>
                {
                    ReturnObject.SetCell(this.GetCell(LoopNumberX, LoopNumberY), LoopNumberX, LoopNumberY);
                });
            });
            Parallel.For(0, BlockStructureInput.GetBlockSizeY(), (LoopNumberY, stateY) =>
            {
                Parallel.For(0, BlockStructureInput.GetBlockSizeX(), (LoopNumberX, stateX) =>
                {
                    ReturnObject.SetCell(BlockStructureInput.GetCell(LoopNumberX, LoopNumberY), LoopNumberX, LoopNumberY + this.GetBlockSizeY());
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
            if (EnhancedMode.Equals(true) && (this.GetBlockSizeX() < BlockStructureInput.GetBlockSizeX()))
            {
                return this.ConcatenateHorizontal(new BlockStructure((uint)(BlockStructureInput.GetBlockSizeX() - this.GetBlockSizeX()), (uint)this.GetBlockSizeY())).ConcatenateVertical(BlockStructureInput);
            }
            else if (EnhancedMode.Equals(true) && (this.GetBlockSizeX() > BlockStructureInput.GetBlockSizeX()))
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
            Parallel.For(0, this.GetBlockSizeY(), (LoopNumberY, stateY) =>
            {
                Parallel.For(0, this.GetBlockSizeX(), (LoopNumberX, stateX) =>
                {
                    ReturnObject.SetCell(this.GetCell(LoopNumberX, LoopNumberY), LoopNumberX, LoopNumberY);
                });
            });
            Parallel.For(0, BlockStructureInput.GetBlockSizeY(), (LoopNumberY, stateY) =>
            {
                Parallel.For(0, BlockStructureInput.GetBlockSizeX(), (LoopNumberX, stateX) =>
                {
                    ReturnObject.SetCell(BlockStructureInput.GetCell(LoopNumberX, LoopNumberY).SetBackGroundColor(NewBackGroundColor), LoopNumberX, LoopNumberY + this.GetBlockSizeY());
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
        public BlockStructure Convert<T, TResult>(Converter<T, TResult> converter)
            where T : CellStructure
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

            long[] dimensions = new long[this.TableArray.Rank];
            for (int i = 0; i < this.TableArray.Rank; i++)
                dimensions[i] = this.TableArray.GetLongLength(i);

            Array result = Array.CreateInstance(typeof(TResult), dimensions);
            TResult[] tmp = new TResult[1];
            int offset = 0;
            int itemSize = System.Runtime.InteropServices.Marshal.SizeOf(typeof(TResult));
            foreach (T item in this.TableArray)
            {
                tmp[0] = converter(item);
                Buffer.BlockCopy(tmp, 0, result, offset * itemSize, itemSize);
                offset++;
            }
            return new BlockStructure(result);
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
            /*
            for (int LoopNumberY = 0; LoopNumberY < this.GetBlockSizeY(); LoopNumberY++)
            {
                for (uint LoopNumberX = 0; LoopNumberX < this.GetBlockSizeX(); LoopNumberX++)
                {
                    if (this.GetCell(LoopNumberX, LoopNumberY).GetString().Contains(TargetString))
                    {
                        TargetObjectLocation.Add(new Tuple<uint, uint>(LoopNumberX, (uint)LoopNumberY));
                    }
                }
            }
            */

            Parallel.For(0, this.GetBlockSizeY(), (LoopNumberY, state) =>
            {
                for (uint LoopNumberX = 0; LoopNumberX < this.GetBlockSizeX(); LoopNumberX++)
                {
                    if (this.GetCell(LoopNumberX, LoopNumberY).GetString().Contains(TargetString))
                    {
                        TargetObjectLocation.Add(new Tuple<uint, uint>(LoopNumberX, (uint)LoopNumberY));
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
            return (BlockStructure)DeepClone(this);
        }

        public BlockStructure GetBottomRow()
        {
            return this.GetRow(this.GetBlockSizeY() - 1);
        }

        public CellStructure GetCell(int LocationX, int LocationY)
        {
            return GetCell((uint)LocationX, (uint)LocationY);
        }

        public CellStructure GetCell(long LocationX, long LocationY)
        {
            return GetCell((uint)LocationX, (uint)LocationY);
        }

        public CellStructure GetCell(uint LocationX, uint LocationY)
        {
            if (LocationX <= this.TableArray.GetUpperBound(0) &&
                LocationX >= this.TableArray.GetLowerBound(0) &&
                LocationY <= this.TableArray.GetUpperBound(1) &&
                LocationY >= this.TableArray.GetLowerBound(1))
            {
                /*
                CellStructure.CellStructure ReturnOjbect = new CellStructure.CellStructure(
                    this.TableArray.GetValue(LocationX, LocationY).ToString());
                return ReturnOjbect;
                */
                return (CellStructure)this.TableArray.GetValue(LocationX, LocationY);
            }
            else
            {
                Console.WriteLine("Index invalid");
                throw new ArgumentOutOfRangeException("Index invalid");
            }
        }

        public CellStructure GetCell(int locationX, Tuple<sbyte, sbyte> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<byte, sbyte> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<short, sbyte> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<ushort, sbyte> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<char, sbyte> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<int, sbyte> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<uint, sbyte> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<sbyte, byte> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<byte, byte> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<short, byte> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<ushort, byte> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<char, byte> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<int, byte> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<uint, byte> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<sbyte, short> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<byte, short> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<short, short> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<ushort, short> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<char, short> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<int, short> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<uint, short> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<sbyte, ushort> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<byte, ushort> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<short, ushort> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<ushort, ushort> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<char, ushort> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<int, ushort> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<uint, ushort> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<sbyte, char> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<byte, char> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<short, char> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<ushort, char> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<char, char> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<int, char> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<uint, char> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<sbyte, int> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<byte, int> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<short, int> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<ushort, int> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<char, int> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<int, int> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<uint, int> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<sbyte, uint> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<byte, uint> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<short, uint> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<ushort, uint> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<char, uint> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<int, uint> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public CellStructure GetCell(Tuple<uint, uint> Location)
        {
            return GetCell((uint)Location.Item1, (uint)Location.Item2);
        }

        public List<CellStructure> GetCells(List<Tuple<uint, uint>> Location)
        {
            List<CellStructure> ReturnObject = new List<CellStructure>();
            foreach (var EachLocation in Location)
            {
                ReturnObject.Add(this.GetCell(EachLocation));
            }
            return ReturnObject;
        }

        public List<List<CellStructure>> GetCells(List<List<Tuple<uint, uint>>> Location)
        {
            List<List<CellStructure>> ReturnObject = new List<List<CellStructure>>();
            foreach (var item in Location)
            {
                ReturnObject.Add(this.GetCells(item));
            }
            return ReturnObject;
        }

        public IEnumerable<CellStructure> GetCells(IEnumerable<Tuple<uint, uint>> Location)
        {
            foreach (var EachLocation in Location)
            {
                yield return GetCell(EachLocation);
            }
        }

        public System.Collections.IEnumerable GetCells(System.Collections.IEnumerable Location)
        {
            foreach (var EachLocation in Location)
            {
                if (EachLocation is IEnumerable<Tuple<uint, uint>> InnerLocation)
                {
                    yield return GetCells(InnerLocation);
                }
                else if (EachLocation is System.Collections.IEnumerable enumerable)
                {
                    yield return GetCells(enumerable);
                }
            }
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
            for (int LoopNumber = 1; LoopNumber < RowCount; LoopNumber++)
            {
                ReturnObject = ReturnObject.ConcatenateVertical(this.GetRow(LoopNumber));
            }
            return ReturnObject;
        }

        public BlockStructure GetRow(int RowIndex)
        {
            return this.SubBlock(new Tuple<int, int>(0, RowIndex), this.GetBlockSizeX(), 1);
        }

        public List<BlockStructure> GetRows(List<int> RowIndexes)
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
                    if(output < GetCell(x, y).GetDouble().Value)
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
                Math.Max(location.Item1 + plane.GetBlockSizeX(), this.GetBlockSizeX()), 
                Math.Max(location.Item2 + plane.GetBlockSizeY(), this.GetBlockSizeY())
                );
            for (int y = 0; y < this.GetBlockSizeY(); y++)
            {
                for (int x = 0; x < this.GetBlockSizeX(); x++)
                {
                    output.SetCell(this.GetCell(x, y), x, y);
                }
            }
            /*
            Parallel.For(0, this.GetBlockSizeY(), (LoopNumberY, stateY) =>
            {
                Parallel.For(0, this.GetBlockSizeX(), (LoopNumberX, stateX) =>
                {
                    output.SetCell(this.GetCell(LoopNumberX, LoopNumberY), LoopNumberX, LoopNumberY);
                });
            });
            */

            for (int x = 0; x < plane.GetBlockSizeX(); x++)
            {
                for (int y = 0; y < plane.GetBlockSizeY(); y++)
                {
                    output = output.SetCell(plane.GetCell(x, y), location.Item1 + x, location.Item2 + y).Item2;
                }
            }
            /*
            Parallel.For(0, plane.GetBlockSizeX(), (LoopNumberY, stateY) =>
            {
                Parallel.For(0, plane.GetBlockSizeY(), (LoopNumberX, stateX) =>
                {
                    output = output.SetCell(plane.GetCell(LoopNumberX, LoopNumberY), location.Item1 + LoopNumberX, location.Item2 + LoopNumberY).Item2;
                });
            });
            */
            return output;
        }

        public BlockStructure Paste(in Tuple<int, int> location, in CellStructure cellStructure)
        {
            return this.Paste(location, new BlockStructure(1, 1, cellStructure));
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
            this.TableArray = this.SubBlock(new Tuple<int, int>(0, 0), this.GetBlockSizeX(), this.GetBlockSizeY() - Count).TableArray;
            return this;
        }

        public BlockStructure RemoveLeftColumns(in int Count)
        {
            //    this = this.SubBlock(new Tuple<int, int>(Count, 0), this.GetBlockSizeX() - Count, this.GetBlockSizeY());
            this.TableArray = this.SubBlock(new Tuple<int, int>(Count, 0), this.GetBlockSizeX() - Count, this.GetBlockSizeY()).TableArray;
            return this;
        }

        public BlockStructure RemoveRightColumns(in int Count)
        {
            //    this = this.SubBlock(new Tuple<int, int>(0, 0), this.GetBlockSizeX() - Count, this.GetBlockSizeY());
            this.TableArray = this.SubBlock(new Tuple<int, int>(0, 0), this.GetBlockSizeX() - Count, this.GetBlockSizeY()).TableArray;
            return this;
        }

        public BlockStructure RemoveTopRows(in int Count)
        {
            //    this = this.SubBlock(new Tuple<int, int>(0, Count), this.GetBlockSizeX(), this.GetBlockSizeY() - Count);
            this.TableArray = this.SubBlock(new Tuple<int, int>(0, Count), this.GetBlockSizeX(), this.GetBlockSizeY() - Count).TableArray;
            return this;
        }

        public BlockStructure SubBlock(in System.Drawing.Point Location, in uint SizeX, in uint SizeY)
        {
            return this.SubBlock(Location, (int)SizeX, (int)SizeY);
        }

        public BlockStructure SubBlock(System.Drawing.Point Location, int SizeX, int SizeY)
        {
            return this.SubBlock(new Tuple<int, int>(Location.X, Location.Y), SizeX, SizeY);
        }

        public BlockStructure SubBlock(Tuple<int, int> Location, uint SizeX, uint SizeY)
        {
            return this.SubBlock(new Tuple<int, int>((int)Location.Item1, (int)Location.Item2), (int)SizeX, (int)SizeY);
        }

        public BlockStructure SubBlock(Tuple<int, int> Location, int SizeX, int SizeY)
        {
            var ReturnObject = new BlockStructure(SizeX, SizeY);
            Parallel.For(0, SizeY, (LoopNumberY, stateY) =>
            {
                Parallel.For(0, SizeX, (LoopNumberX, stateX) =>
                {
                    ReturnObject.SetCell(this.GetCell(Location.Item1 + LoopNumberX, Location.Item2 + LoopNumberY), LoopNumberX, LoopNumberY);
                });
            });
            return ReturnObject;
        }

        /// <summary>
        /// Update ALL CellStructure.
        /// </summary>
        /// <param name="CellStructureInput"></param>
        /// <returns></returns>
        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput)
        {
            bool ReturnBool = true;
            Parallel.For(0, this.GetBlockSizeY(), LoopNumberY => 
            {
                Parallel.For(0, this.GetBlockSizeX(), LoopNumberX =>
                {
                    if (this.SetCell(CellStructureInput, LoopNumberX, LoopNumberY).Item1.Equals(false))
                    {
                        ReturnBool = false;
                    }
                });
            });
            return new Tuple<bool, BlockStructure>(ReturnBool, this);
        }

        /*
        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, T2 LocationX, T1 LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }
        */

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, sbyte LocationX, sbyte LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, sbyte LocationX, byte LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, sbyte LocationX, short LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, sbyte LocationX, ushort LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, sbyte LocationX, char LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, sbyte LocationX, int LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, sbyte LocationX, long LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, sbyte LocationX, ulong LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, sbyte LocationX, uint LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, byte LocationX, sbyte LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, byte LocationX, byte LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, byte LocationX, short LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, byte LocationX, ushort LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, byte LocationX, char LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, byte LocationX, int LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, byte LocationX, long LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, byte LocationX, ulong LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, byte LocationX, uint LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, short LocationX, sbyte LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, short LocationX, byte LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, short LocationX, short LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, short LocationX, ushort LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, short LocationX, char LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, short LocationX, int LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, short LocationX, long LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, short LocationX, ulong LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, short LocationX, uint LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, ushort LocationX, sbyte LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, ushort LocationX, byte LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, ushort LocationX, short LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, ushort LocationX, ushort LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, ushort LocationX, char LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, ushort LocationX, int LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, ushort LocationX, long LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, ushort LocationX, ulong LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, ushort LocationX, uint LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, char LocationX, sbyte LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, char LocationX, byte LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, char LocationX, short LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, char LocationX, ushort LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, char LocationX, char LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, char LocationX, int LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, char LocationX, long LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, char LocationX, ulong LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, char LocationX, uint LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, int LocationX, sbyte LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, int LocationX, byte LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, int LocationX, short LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, int LocationX, ushort LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, int LocationX, char LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, int LocationX, int LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, int LocationX, long LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, int LocationX, ulong LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, int LocationX, uint LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, long LocationX, sbyte LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, long LocationX, byte LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, long LocationX, short LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, long LocationX, ushort LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, long LocationX, char LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, long LocationX, int LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, long LocationX, long LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, long LocationX, ulong LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, long LocationX, uint LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, ulong LocationX, sbyte LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, ulong LocationX, byte LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, ulong LocationX, short LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, ulong LocationX, ushort LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, ulong LocationX, char LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, ulong LocationX, int LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, ulong LocationX, long LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, ulong LocationX, ulong LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, ulong LocationX, uint LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, uint LocationX, sbyte LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, uint LocationX, byte LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, uint LocationX, short LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, uint LocationX, ushort LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, uint LocationX, char LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, uint LocationX, int LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, uint LocationX, long LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, LocationX, (uint)LocationY);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, uint LocationX, ulong LocationY)
        {
            this.SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
            return SetCell(CellStructureInput, (uint)LocationX, (uint)LocationY);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CellStructureInput"></param>
        /// <param name="LocationX"></param>
        /// <param name="LocationY"></param>
        /// <returns>
        /// The first return value represent operation success or failed.
        /// The second return value is the execution result.
        /// </returns>
        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, uint LocationX, uint LocationY)
        {
            if (LocationX <= this.TableArray.GetUpperBound(0) &&
                LocationX >= this.TableArray.GetLowerBound(0) &&
                LocationY <= this.TableArray.GetUpperBound(1) &&
                LocationY >= this.TableArray.GetLowerBound(1))
            {
                this.TableArray.SetValue(CellStructureInput, LocationX, LocationY);
                return new Tuple<bool, BlockStructure>(true, this);
            }
            else
            {
                return new Tuple<bool, BlockStructure>(false, this); ;
            }

        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<sbyte, sbyte> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<byte, sbyte> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<short, sbyte> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<ushort, sbyte> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<char, sbyte> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<int, sbyte> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<uint, sbyte> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<sbyte, byte> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<byte, byte> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<short, byte> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<ushort, byte> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<char, byte> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<int, byte> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<uint, byte> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<sbyte, short> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<byte, short> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<short, short> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<ushort, short> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<char, short> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<int, short> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<uint, short> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<sbyte, ushort> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<byte, ushort> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<short, ushort> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<ushort, ushort> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<char, ushort> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<int, ushort> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<uint, ushort> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<sbyte, char> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<byte, char> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<short, char> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<ushort, char> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<char, char> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<int, char> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<uint, char> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<sbyte, int> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<byte, int> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<short, int> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<ushort, int> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<char, int> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<int, int> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<uint, int> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<sbyte, uint> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<byte, uint> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<short, uint> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<ushort, uint> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<char, uint> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<int, uint> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
        }

        public Tuple<bool, BlockStructure> SetCell(CellStructure CellStructureInput, Tuple<uint, uint> Location)
        {
            this.SetCell(CellStructureInput, (uint)Location.Item1, (uint)Location.Item2);
            return this.SetCell(CellStructureInput, Location.Item1, Location.Item2);
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

            double TotalCells = this.GetBlockSizeX() * this.GetBlockSizeY();
            double SameCellCount = 0;

            for (int LoopNumberY = 0; LoopNumberY < this.GetBlockSizeY(); LoopNumberY++)
            {
                for (int LoopNumberX = 0; LoopNumberX < this.GetBlockSizeX(); LoopNumberX++)
                {
                    if (this.GetCell(LoopNumberX, LoopNumberY).Equals(BlockStructureInput.GetCell(LoopNumberX, LoopNumberY)))
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
            for (int LoopNumberY = 0; LoopNumberY < this.GetBlockSizeY(); LoopNumberY++)
            {
                for (int LoopNumberX = 0; LoopNumberX < this.GetBlockSizeX(); LoopNumberX++)
                {
                    if (this.GetCell(LoopNumberX, LoopNumberY).IsNullOrEmpty().Equals(false))
                    {
                        TotalNotBlankCells = TotalNotBlankCells + 1;
                    }
                }
            }

            double SameCellCount = 0;
            for (int LoopNumberY = 0; LoopNumberY < this.GetBlockSizeY(); LoopNumberY++)
            {
                for (int LoopNumberX = 0; LoopNumberX < this.GetBlockSizeX(); LoopNumberX++)
                {
                    if (this.GetCell(LoopNumberX, LoopNumberY).Equals(BlockStructureInput.GetCell(LoopNumberX, LoopNumberY)) &&
                        this.GetCell(LoopNumberX, LoopNumberY).IsNullOrEmpty().Equals(false)
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
            double ReturnResult = 0;
            for (int LoopNumberY = 0; LoopNumberY < this.GetBlockSizeY(); LoopNumberY++)
            {
                for (int LoopNumberX = 0; LoopNumberX < this.GetBlockSizeX(); LoopNumberX++)
                {
                    ReturnResult = ReturnResult + this.GetCell(LoopNumberX, LoopNumberY).GetDouble().GetValueOrDefault(0);
                }
            }
            return ReturnResult;
        }

        public List<BlockStructure> ToColumnList()
        {
            List<BlockStructure> ReturnObject = new List<BlockStructure>();
            for (int ColumnIndex = 0; ColumnIndex < this.GetBlockSizeX(); ColumnIndex++)
            {
                ReturnObject.Add(this.GetColumn(ColumnIndex));
            }
            return ReturnObject;
        }

        public List<BlockStructure> ToColumnListWithFiltering(Func<BlockStructure, bool> Filter)
        {
            return this.ToColumnList().Where(Filter).ToList();
        }

        public void ShowDataGridView(ref DataGridView DataGridViewInput)
        {
            DataGridViewInput.Rows.Clear();
            DataGridViewInput.Columns.Clear();

            //    Construct Columns
            DataGridViewInput.ColumnCount = this.GetBlockSizeX();
            for (int ConstructColumns = 0; ConstructColumns < DataGridViewInput.ColumnCount; ConstructColumns++)
            {
                DataGridViewInput.Columns[ConstructColumns].Name = ConstructColumns.ToString();
            }

            //    Update grids on UI (string)
            for (uint LoopNumberY = 0; LoopNumberY < this.GetBlockSizeY(); LoopNumberY++)
            {
                List<string> RowData = new List<string>();
                for (uint LoopNumberX = 0; LoopNumberX < this.GetBlockSizeX(); LoopNumberX++)
                {
                    RowData.Add(this.GetCell(LoopNumberX, LoopNumberY).GetString());
                }
                DataGridViewInput.Rows.Add(RowData.ToArray());
            }

            var NewDataGridView = DataGridViewInput;
            Parallel.For(0, this.GetBlockSizeY(), (LoopNumberY, StateY) =>
            {
                Parallel.For(0, this.GetBlockSizeX(), (LoopNumberX, StateX) =>
                {
                    if (this.GetCell(LoopNumberX, LoopNumberY).IsBackGroundColorUsed())
                    {
                        DataGridViewCell TargetCell = NewDataGridView.Rows[(int)LoopNumberY].Cells[(int)LoopNumberX];
                        XLColor xLColor = this.GetCell(LoopNumberX, LoopNumberY).GetBackGroundColor();
                        TargetCell.Style.BackColor = System.Drawing.Color.FromArgb(
                            xLColor.Color.ToArgb());
                    }
                });
            });
            DataGridViewInput = NewDataGridView;
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
            return this.TableArray.GetUpperBound(0) - this.TableArray.GetLowerBound(0);
        }

        public int GetBlockSizeY()
        {
            return this.TableArray.GetUpperBound(1) - this.TableArray.GetLowerBound(1);
        }

        public Tuple<int, List<Tuple<uint, uint>>> GetLocationsByLabelContains(string LabelInput)
        {
            var TargetObjectLocation = new List<Tuple<uint, uint>>();
            for (int LoopNumberY = 0; LoopNumberY < this.GetBlockSizeY(); LoopNumberY++)
            {
                for (uint LoopNumberX = 0; LoopNumberX < this.GetBlockSizeX(); LoopNumberX++)
                {
                    if (this.GetCell(LoopNumberX, LoopNumberY).IsLabelContains(LabelInput).Equals(true))
                    {
                        TargetObjectLocation.Add(new Tuple<uint, uint>(LoopNumberX, (uint)LoopNumberY));
                    }
                }
            }

            /*
            Parallel.For(0, this.GetBlockSizeY(), (LoopNumberY, state) =>
            {
                for (uint LoopNumberX = 0; LoopNumberX < this.GetBlockSizeX(); LoopNumberX++)
                {
                    if (this.GetCell(LoopNumberX, LoopNumberY).IsLabelContains(LabelInput).Equals(true))
                    {
                        TargetObjectLocation.Add(new Tuple<uint, uint>(LoopNumberX, (uint)LoopNumberY));
                    }
                }
            });
            */

            return new Tuple<int, List<Tuple<uint, uint>>>(TargetObjectLocation.Count, TargetObjectLocation);
        }

        public Tuple<int, List<Tuple<uint, uint>>> GetLocationsByLabel(string LabelInput)
        {
            var TargetObjectLocation = new List<Tuple<uint, uint>>();
            for (int LoopNumberY = 0; LoopNumberY < this.GetBlockSizeY(); LoopNumberY++)
            {
                for (uint LoopNumberX = 0; LoopNumberX < this.GetBlockSizeX(); LoopNumberX++)
                {
                    if (this.GetCell(LoopNumberX, LoopNumberY).IsLabelExist(LabelInput).Equals(true))
                    {
                        TargetObjectLocation.Add(new Tuple<uint, uint>(LoopNumberX, (uint)LoopNumberY));
                    }
                }
            }
            
            /*
            Parallel.For(0, this.GetBlockSizeY(), (LoopNumberY, state) =>
            {
                for (uint LoopNumberX = 0; LoopNumberX < this.GetBlockSizeX(); LoopNumberX++)
                {
                    if (this.GetCell(LoopNumberX, LoopNumberY).IsLabelExist(LabelInput).Equals(true))
                    {
                        TargetObjectLocation.Add(new Tuple<uint, uint>(LoopNumberX, (uint)LoopNumberY));
                    }
                }
            });
            */

            return new Tuple<int, List<Tuple<uint, uint>>>(TargetObjectLocation.Count, TargetObjectLocation);
        }

        public void Print()
        {
            for (uint LoopNumberY = 0; LoopNumberY < this.GetBlockSizeY(); LoopNumberY++)
            {
                for (uint LoopNumberX = 0; LoopNumberX < this.GetBlockSizeX(); LoopNumberX++)
                {
                    Console.Write(this.GetCell(LoopNumberX, LoopNumberY).GetString() + "\t");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TargetString"></param>
        /// <returns>
        /// int:                                #Found objects
        /// List<Tuple<uint, uint></uint>>:        Location X and Y of found objects
        /// </returns>
        public Tuple<int, List<Tuple<uint, uint>>> Find(string TargetString)
        {
            var TargetObjectLocation = new List<Tuple<uint, uint>>();
            if(false)               //    Use serial method
            {
                for (int LoopNumberY = 0; LoopNumberY < this.GetBlockSizeY(); LoopNumberY++)
                {
                    for (uint LoopNumberX = 0; LoopNumberX < this.GetBlockSizeX(); LoopNumberX++)
                    {
                        if (this.GetCell(LoopNumberX, LoopNumberY).GetString().Equals(TargetString))
                        {
                            TargetObjectLocation.Add(new Tuple<uint, uint>(LoopNumberX, (uint)LoopNumberY));
                        }
                    }
                }
            }
            else
            {
                Parallel.For(0, this.GetBlockSizeY(), (LoopNumberY, state) =>
                {
                    for (uint LoopNumberX = 0; LoopNumberX < this.GetBlockSizeX(); LoopNumberX++)
                    {
                        if (this.GetCell(LoopNumberX, LoopNumberY).GetString().Equals(TargetString))
                        {
                            TargetObjectLocation.Add(new Tuple<uint, uint>(LoopNumberX, (uint)LoopNumberY));
                        }
                    }
                });
            }
            return new Tuple<int, List<Tuple<uint, uint>>>(TargetObjectLocation.Count, TargetObjectLocation);
        }

        public BlockStructure RemoveLabelsContains(string LabelInput)
        {
            Parallel.For(0, this.GetBlockSizeY(), (LoopNumberY, state) =>
            {
                for (uint LoopNumberX = 0; LoopNumberX < this.GetBlockSizeX(); LoopNumberX++)
                {
                    this.SetCell(this.GetCell(LoopNumberX, LoopNumberY).RemoveLabelsContains(LabelInput), LoopNumberX, LoopNumberY);
                }
            });
            return this;
        }

        public BlockStructure RemoveLabel(string LabelInput)
        {
            Parallel.For(0, this.GetBlockSizeY(), (LoopNumberY, state) =>
            {
                for (uint LoopNumberX = 0; LoopNumberX < this.GetBlockSizeX(); LoopNumberX++)
                {
                    this.SetCell(this.GetCell(LoopNumberX, LoopNumberY).RemoveLabel(LabelInput), LoopNumberX, LoopNumberY);
                }
            });
            return this;
        }

        public override string ToString()
        {
            string ReturnObject = "";

            for (uint LoopNumberY = 0; LoopNumberY < this.GetBlockSizeY(); LoopNumberY++)
            {
                for (uint LoopNumberX = 0; LoopNumberX < this.GetBlockSizeX(); LoopNumberX++)
                {
                    ReturnObject = ReturnObject + this.GetCell(LoopNumberX, LoopNumberY).GetString() + "\t";
                }
                ReturnObject = ReturnObject + System.Environment.NewLine;
            }
            return ReturnObject;

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
            for (uint LoopNumberY = 0; LoopNumberY < this.GetBlockSizeY(); LoopNumberY++)
            {
                for (uint LoopNumberX = 0; LoopNumberX < this.GetBlockSizeX(); LoopNumberX++)
                {
                    if (this.GetCell(LoopNumberX, LoopNumberY).GetString().Equals(
                        Instance.GetCell(LoopNumberX, LoopNumberY).GetString()
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
