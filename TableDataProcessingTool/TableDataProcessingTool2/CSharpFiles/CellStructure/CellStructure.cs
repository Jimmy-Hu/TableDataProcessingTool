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
                this.dateTime = DateTimeParsingResult;
            }
            else
            {
                this.dateTime = null;
            }
            //    Try to convert to int number
            if (int.TryParse(InputString, out int IntNumberParsingResult))
            {
                this.IntNumber = IntNumberParsingResult;
            }
            else
            {
                this.IntNumber = null;
            }
            //    Try to convert to float number
            if (float.TryParse(InputString, out float FloatNumberParsingResult))
            {
                this.FloatNumber = FloatNumberParsingResult;
            }
            else
            {
                this.FloatNumber = null;
            }
            //    Try to convert to double number
            if (double.TryParse(InputString, out double DoubleNumberParsingResult))
            {
                this.DoubleNumber = DoubleNumberParsingResult;
            }
            else
            {
                this.DoubleNumber = null;
            }
            //    Try to convert to decimal number
            if (decimal.TryParse(InputString, out decimal DecimalNumberParsingResult))
            {
                this.DecimalNumber = DecimalNumberParsingResult;
            }
            else
            {
                this.DecimalNumber = null;
            }
            SplitResult = new List<CellStructure>();
            Labels = new List<string>();
        }

        public CellStructure(string InputString, params char[] Separators)
        {
            this.StringData = InputString;

            //    Try to convert to DateTime structure
            DateTime DateTimeParsingResult;
            if (DateTime.TryParse(InputString, out DateTimeParsingResult))
            {
                this.dateTime = DateTimeParsingResult;
            }
            else
            {
                this.dateTime = null;
            }
            //    Try to convert to int number
            int IntNumberParsingResult;
            if (int.TryParse(InputString, out IntNumberParsingResult))
            {
                this.IntNumber = IntNumberParsingResult;
            }
            else
            {
                this.IntNumber = null;
            }
            //    Try to convert to float number
            float FloatNumberParsingResult;
            if (float.TryParse(InputString, out FloatNumberParsingResult))
            {
                this.FloatNumber = FloatNumberParsingResult;
            }
            else
            {
                this.FloatNumber = null;
            }
            //    Try to convert to double number
            double DoubleNumberParsingResult;
            if (double.TryParse(InputString, out DoubleNumberParsingResult))
            {
                this.DoubleNumber = DoubleNumberParsingResult;
            }
            else
            {
                this.DoubleNumber = null;
            }
            //    Try to convert to decimal number
            if (decimal.TryParse(InputString, out decimal DecimalNumberParsingResult))
            {
                this.DecimalNumber = DecimalNumberParsingResult;
            }
            else
            {
                this.DecimalNumber = null;
            }
            SplitResult = new List<CellStructure>();
            foreach (var item in InputString.Split(Separators)
                .Select((Value, Index) => new { Index, Value }))
            {
                SplitResult.Add(new CellStructure(item.Value));
            }
            Labels = new List<string>();
        }
        public CellStructure(string InputString, string RegexPatternInput)
        {
            string StringForProcessing = System.Text.RegularExpressions.Regex.Replace(InputString, RegexPatternInput, String.Empty);

            this.StringData = StringForProcessing;

            //    Try to convert to DateTime structure
            if (DateTime.TryParse(StringForProcessing, out DateTime DateTimeParsingResult))
