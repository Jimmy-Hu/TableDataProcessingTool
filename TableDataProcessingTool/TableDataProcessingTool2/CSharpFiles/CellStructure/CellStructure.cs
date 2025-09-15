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
        [ProtoMember(2)]
        private DateTime? dateTime;
        [ProtoMember(3)]
        private int? IntNumber;
        [ProtoMember(4)]
        private float? FloatNumber;
        [ProtoMember(5)]
        private double? DoubleNumber;
        [ProtoMember(6)]
