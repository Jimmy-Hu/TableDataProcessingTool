using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TableDataProcessingTool.CSharpFiles
{
    [Serializable]
	public class CellStructure : BaseClass
	{
		private string StringData;
		private DateTime? dateTime;
		private int? IntNumber;
		private BigInteger? BigIntegerNumber;
		private float? FloatNumber;
		private double? DoubleNumber;
		private decimal? DecimalNumber;
		private List<CellStructure> SplitResult;
		private bool UseBackGroundColor = false;
		private int BackGroundColorARGB;

		private List<string> Labels;

		public CellStructure(string InputString)
		{
			this.StringData = InputString;

			//	Try to convert to DateTime structure
			if (DateTime.TryParse(InputString, out DateTime DateTimeParsingResult))
			{
				this.dateTime = DateTimeParsingResult;
			}
			else
			{
				this.dateTime = null;
			}
			//	Try to convert to int number
			if (int.TryParse(InputString, out int IntNumberParsingResult))
			{
				this.IntNumber = IntNumberParsingResult;
			}
			else
			{
				this.IntNumber = null;
			}
			//	Try to convert to BigInteger number
			if (BigInteger.TryParse(InputString, out BigInteger BigIntegerNumberParsingResult))
			{
				this.BigIntegerNumber = BigIntegerNumberParsingResult;
			}
			else
			{
				this.BigIntegerNumber = null;
			}
			//	Try to convert to float number
			if (float.TryParse(InputString, out float FloatNumberParsingResult))
			{
				this.FloatNumber = FloatNumberParsingResult;
			}
			else
			{
				this.FloatNumber = null;
			}
			//	Try to convert to double number
			if (double.TryParse(InputString, out double DoubleNumberParsingResult))
			{
				this.DoubleNumber = DoubleNumberParsingResult;
			}
			else
			{
				this.DoubleNumber = null;
			}
			//	Try to convert to decimal number
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
			
			//	Try to convert to DateTime structure
			DateTime DateTimeParsingResult;
			if (DateTime.TryParse(InputString, out DateTimeParsingResult))
			{
				this.dateTime = DateTimeParsingResult;
			}
			else
			{
				this.dateTime = null;
			}
			//	Try to convert to int number
			int IntNumberParsingResult;
			if (int.TryParse(InputString, out IntNumberParsingResult))
			{
				this.IntNumber = IntNumberParsingResult;
			}
			else
			{
				this.IntNumber = null;
			}
			//	Try to convert to BigInteger number
			if (BigInteger.TryParse(InputString, out BigInteger BigIntegerNumberParsingResult))
			{
				this.BigIntegerNumber = BigIntegerNumberParsingResult;
			}
			else
			{
				this.BigIntegerNumber = null;
			}
			//	Try to convert to float number
			float FloatNumberParsingResult;
			if (float.TryParse(InputString, out FloatNumberParsingResult))
			{
				this.FloatNumber = FloatNumberParsingResult;
			}
			else
			{
				this.FloatNumber = null;
			}
			//	Try to convert to double number
			double DoubleNumberParsingResult;
			if (double.TryParse(InputString, out DoubleNumberParsingResult))
			{
				this.DoubleNumber = DoubleNumberParsingResult;
			}
			else
			{
				this.DoubleNumber = null;
			}
			//	Try to convert to decimal number
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

			//	Try to convert to DateTime structure
			if (DateTime.TryParse(StringForProcessing, out DateTime DateTimeParsingResult))
			{
				this.dateTime = DateTimeParsingResult;
			}
			else
			{
				this.dateTime = null;
			}
			//	Try to convert to int number
			if (int.TryParse(StringForProcessing, out int IntNumberParsingResult))
			{
				this.IntNumber = IntNumberParsingResult;
			}
			else
			{
				this.IntNumber = null;
			}
			//	Try to convert to BigInteger number
			if (BigInteger.TryParse(StringForProcessing, out BigInteger BigIntegerNumberParsingResult))
			{
				this.BigIntegerNumber = BigIntegerNumberParsingResult;
			}
			else
			{
				this.BigIntegerNumber = null;
			}
			//	Try to convert to float number
			if (float.TryParse(StringForProcessing, out float FloatNumberParsingResult))
			{
				this.FloatNumber = FloatNumberParsingResult;
			}
			else
			{
				this.FloatNumber = null;
			}
			//	Try to convert to double number
			if (double.TryParse(StringForProcessing, out double DoubleNumberParsingResult))
			{
				this.DoubleNumber = DoubleNumberParsingResult;
			}
			else
			{
				this.DoubleNumber = null;
			}
			//	Try to convert to decimal number
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

		public CellStructure AddLabel(string NewLabel)
		{
			this.Labels.Add(NewLabel);
			return this;
		}

		public CellStructure DeepClone()
		{
			return (CellStructure)DeepClone(this);
		}

		public string GetString()
		{
			return this.StringData;
		}
		public DateTime? GetDateTime()
		{
			return this.dateTime;
		}
		public int? GetInt()
		{
			return this.IntNumber;
		}
		public BigInteger? GetBigInteger()
		{
			return this.BigIntegerNumber;
		}
		public float? GetFloat()
		{
			return this.FloatNumber;
		}
		public double? GetDouble()
		{
			return this.DoubleNumber;
		}

		public decimal? GetDecimal()
		{
			return this.DecimalNumber;
		}

		public List<CellStructure> GetSplitResult()
		{
			return this.SplitResult;
		}

		public bool IsLabelContains(string InputLabel)
		{
			foreach (var EachLabel in this.Labels)
			{
				if (EachLabel.Contains(InputLabel).Equals(true))
				{
					return true;
				}
			}
			return false;
		}

		public bool IsLabelExist(string InputLabel)
		{
			foreach (var EachLabel in this.Labels)
			{
				if (InputLabel.Equals(EachLabel).Equals(true))
				{
					return true;
				}
			}
			return false;
		}

		public bool IsNullOrEmpty()
		{
			return String.IsNullOrEmpty(this.GetString());
		}

		public CellStructure RemoveLabelsContains(string InputLabel)
		{
			List<string> NewLabels = new List<string>();
			for (int LoopNumber = 0; LoopNumber < this.Labels.Count; LoopNumber++)
			{
				if (this.Labels[LoopNumber].Contains(InputLabel).Equals(false))
				{
					NewLabels.Add(this.Labels[LoopNumber]);
				}
			}
			this.Labels = NewLabels;
			return this;
		}

		public CellStructure RemoveLabel(string InputLabel)
		{
			for (int LoopNumber = 0; LoopNumber < this.Labels.Count; LoopNumber++)
			{
				this.Labels.Remove(InputLabel);
			}
			return this;
		}

		public CellStructure SetBackGroundColor(ClosedXML.Excel.XLColor NewBackGroundColor)
		{
			this.UseBackGroundColor = true;
			this.BackGroundColorARGB = NewBackGroundColor.Color.ToArgb();
			return this;
		}

		public CellStructure SetBackGroundColor(System.Drawing.Color NewBackGroundColor)
        {
			this.UseBackGroundColor = true;
			this.BackGroundColorARGB = NewBackGroundColor.ToArgb();
			return this;
        }

		public bool IsBackGroundColorUsed()
		{
			return this.UseBackGroundColor;
		}

		public ClosedXML.Excel.XLColor GetBackGroundColor()
		{
			ClosedXML.Excel.XLColor ReturnValue = ClosedXML.Excel.XLColor.FromArgb(this.BackGroundColorARGB);
			return ReturnValue;
		}

		public override bool Equals(object obj)
		{
			CellStructure TargetCellStructure = obj as CellStructure;
			if (this.GetString().Equals(TargetCellStructure.GetString()).Equals(false))
			{
				return false;
			}
			return true;
		}

	}

}
