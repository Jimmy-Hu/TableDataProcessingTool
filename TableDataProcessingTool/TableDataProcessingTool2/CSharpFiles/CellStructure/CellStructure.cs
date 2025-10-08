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
        private decimal? DecimalNumber;
        [ProtoMember(7)]
        private List<CellStructure> SplitResult;
        [ProtoMember(8)]
        private bool UseBackGroundColor = false;
        [ProtoMember(9)]
        private int BackGroundColorARGB;

        [ProtoMember(10)]
        private List<string> Labels;

        public CellStructure()
        {

        }

        public CellStructure(string InputString)
        {
            this.StringData = InputString;

            //    Try to convert to DateTime structure
            if (DateTime.TryParse(InputString, out DateTime DateTimeParsingResult))
            {
