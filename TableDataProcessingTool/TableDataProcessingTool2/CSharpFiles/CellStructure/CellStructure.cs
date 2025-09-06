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
    public class CellStructure : BaseClass
    {
        [ProtoMember(1)]
        private string StringData;
