using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableDataProcessingTool2.CSharpFiles
{
    [ProtoContract]
    public class BlockStructures : BaseClass
    {
        [ProtoMember(1)]
        private List<BlockStructure> BlockStructureList;

        public BlockStructures()
        {
            this.BlockStructureList = new List<BlockStructure>();
        }

        public BlockStructures Add(BlockStructure NewBlockStructure)
        {
            this.BlockStructureList.Add(NewBlockStructure);
            return this;
        }

        public BlockStructures Add(List<BlockStructure> NewBlockStructureList)
        {
            this.BlockStructureList.AddRange(NewBlockStructureList);
            return this;
        }

        public BlockStructures Add(BlockStructures NewBlockStructures)
        {
            this.BlockStructureList.AddRange(NewBlockStructures.GetList());
            return this;
        }

        public BlockStructures DeepClone()
        {
            return (BlockStructures)DeepClone(this);
        }

        public List<BlockStructure> GetList()
        {
            return this.BlockStructureList;
        }

        public BlockStructures RemoveAt(int Index)
        {
            this.BlockStructureList.RemoveAt(Index);
            return this;
        }

        public int Size()
        {
            return this.BlockStructureList.Count;
        }

        public override bool Equals(object obj)
        {
            BlockStructures InputBlockStructures = obj as BlockStructures;
            if (InputBlockStructures.Size().Equals(this.Size()).Equals(false))
            {
                return false;
            }
            foreach (var EachBlockStructure in this.BlockStructureList.Select((Value, Index) => new { Index, Value }))
            {
                if (EachBlockStructure.Value.Equals(InputBlockStructures.GetList()[EachBlockStructure.Index]).Equals(false))
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder OutputString = new StringBuilder();
            foreach (var EachBlockStructure in this.BlockStructureList.Select((Value, Index) => new { Index, Value }))
            {
                OutputString.Append("BlockStructure" + EachBlockStructure.Index.ToString() + ":" + System.Environment.NewLine);
                OutputString.Append(EachBlockStructure.Value.ToString());
            }
            return OutputString.ToString();
        }

        public BlockStructure this[int Index]
        {
            //    The get accessor
            get
            {
                if (Index >= 0 && Index <= this.BlockStructureList.Count - 1)
                {
                    return this.BlockStructureList[Index];
                }
                else
                {
                    return null;
                }

            }

            //    The set accessor
            set
            {
                if (Index >= 0 && Index <= this.BlockStructureList.Count - 1)
                {
                    this.BlockStructureList[Index] = value;
                }
            }
        }



    }
}
