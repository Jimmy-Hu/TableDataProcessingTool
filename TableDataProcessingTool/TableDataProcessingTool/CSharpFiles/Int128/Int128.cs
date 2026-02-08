using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TableDataProcessingTool.CSharpFiles.Int128
{
    public struct Int128 : IComparable, IFormattable, IComparable<Int128>, IEquatable<Int128>
    {
        /// <summary>
        /// The minimum value of an <see cref="Int128"/>.
        /// -170141183460469231731687303715884105728
        /// </summary>
        public static readonly Int128 MinValue = new Int128(long.MinValue, 0);

        /// <summary>
        /// The max value of an <see cref="Int128"/>.
        /// 170141183460469231731687303715884105727
        /// </summary>
        public static readonly Int128 MaxValue = new Int128(long.MaxValue, ulong.MaxValue);

        public static readonly Int128 Zero = new Int128();

        public static readonly Int128 One = new Int128(1);

        public static readonly Int128 NegativeOne = new Int128(-1, ulong.MaxValue);

        public static readonly Int128 Two = new Int128(2);

        /// <summary>
        /// Gets the 126 powers of two that can be represented by a <see cref="Int128"/>.
        /// </summary>
        public static IEnumerable<Int128> PowersOfTwo
        {
            get
            {
                Int128 nextPower = Two;
                for (; nextPower < MaxValue; nextPower *= Two) yield return nextPower;
            }
        }

        private Int128 ManipulatedBit => this & this - One;

        private readonly long _high;

        private readonly ulong _low;

        public bool IsNegative => this < Zero;

        public bool IsEven => this % 2 == Zero;

        public bool IsZero => this == Zero;

        public bool IsOne => this == One;

        public bool IsPowerOfTwo => this > Zero && ManipulatedBit == Zero;

        public void Deconstruct(out long High, out ulong Low)
        {
            High = _high;
            Low = _low;
        }

        public Int128(long high, ulong low)
        {
            _high = high;
            _low = low;
        }

        public Int128(ulong low) : this(0, low)
        {
        }

        public static Int128 Parse(string value)
        {
            BigInteger bigInteger;
            try
            {
                bigInteger = BigInteger.Parse(value);
            }
            catch
            {
                throw new Exception("Value could not be parsed.");
            }
            if (bigInteger < MinValue.GetBigInteger() || bigInteger > MaxValue.GetBigInteger())
                throw new Exception("Value was either to large or to small for an Int128.");
            return FromBigInteger(bigInteger);
        }

        public static bool TryParse(string value, out Int128 result)
        {
            try
            {
                result = Parse(value);
                return true;
            }
            catch
            {
                result = default(Int128);
                return false;
            }
        }

        public static Int128 operator ++(Int128 int128) => FromBigInteger(int128.GetBigInteger() + One.GetBigInteger());

        public static Int128 operator --(Int128 int128) => FromBigInteger(int128.GetBigInteger() - One.GetBigInteger());

        public static Int128 operator +(Int128 left, Int128 right) => FromBigInteger(left.GetBigInteger() + right.GetBigInteger());

        public static Int128 operator -(Int128 left, Int128 right) => FromBigInteger(left.GetBigInteger() - right.GetBigInteger());

        public static Int128 operator *(Int128 left, Int128 right) => FromBigInteger(left.GetBigInteger() * right.GetBigInteger());

        public static Int128 operator /(Int128 left, Int128 right) => left == Zero
        || right == Zero ? default(Int128) : FromBigInteger(left.GetBigInteger() / right.GetBigInteger());

        public static Int128 operator %(Int128 int128, int value) => value == 0
        || int128 == Zero ? default(Int128) : FromBigInteger(int128.GetBigInteger() % value);

        public static Int128 operator >>(Int128 int128, int value) => FromBigInteger(int128.GetBigInteger() >> value);

        public static Int128 operator <<(Int128 int128, int value) => FromBigInteger(int128.GetBigInteger() << value);

        public static Int128 operator &(Int128 left, Int128 right) => FromBigInteger(left.GetBigInteger() & right.GetBigInteger());

        private static Int128 FromBigInteger(BigInteger bigInteger)
        {
            GetValuesFromBigInteger(bigInteger, out var high, out var low);
            return new Int128(high, low);
        }

        /// <summary>
        /// Clamps <paramref name="bigInteger"/> to an <see cref="Int128"/>
        /// </summary>
        private static void GetValuesFromBigInteger(BigInteger bigInteger, out long High, out ulong Low)
        {
            if (bigInteger <= MinValue.GetBigInteger()) (High, Low) = MinValue;
            else if (bigInteger >= MaxValue.GetBigInteger()) (High, Low) = MaxValue;
            else GetValuesFromBytes(bigInteger.ToByteArray(), out High, out Low);
        }

        /// <summary>
        /// Gets the <paramref name="High"/> and <paramref name="Low"/>
        /// values from the bytes of <see cref="BigInteger.ToByteArray"/> 
        /// </summary>
        private static void GetValuesFromBytes(byte[] bytes, out long High, out ulong Low)
        {
            Low = 0;
            High = 0;
            var low = new byte[8];
            var high = new byte[8];
            if (bytes.Length > 0 && bytes.Length <= 8)
            {
                Buffer.BlockCopy(bytes, 0, low, 0, bytes.Length);
                Low = BitConverter.ToUInt64(low, 0);
            }
            else if (bytes.Length > 8)
            {
                Buffer.BlockCopy(bytes, 0, low, 0, 8);
                Buffer.BlockCopy(bytes, 8, high, 0, bytes.Length - 8);
                Low = BitConverter.ToUInt64(low, 0);
                High = BitConverter.ToInt64(high, 0);
            }
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is Int128 int128 && Equals(int128);
        }

        public bool Equals(Int128 int128)
        {
            return this == int128;
        }

        public override int GetHashCode()
        {
            return GetBigInteger().GetHashCode();
        }

        public static bool operator ==(Int128 left, Int128 right)
        {
            return left._high == right._high && left._low == right._low;
        }

        public static bool operator !=(Int128 left, Int128 right)
        {
            return !(left == right);
        }

        public static bool operator <(Int128 left, Int128 right)
        {
            return left.GetBigInteger() < right.GetBigInteger();
        }

        public static bool operator >(Int128 left, Int128 right)
        {
            return left.GetBigInteger() > right.GetBigInteger();
        }

        public static bool operator <=(Int128 left, Int128 right)
        {
            return left.GetBigInteger() <= right.GetBigInteger();
        }

        public static bool operator >=(Int128 left, Int128 right)
        {
            return left.GetBigInteger() >= right.GetBigInteger();
        }

        public int CompareTo(object obj)
        {
            return obj != null && obj is Int128 int128 ? CompareTo(int128) : 1;
        }

        public int CompareTo(Int128 other)
        {
            return GetBigInteger().CompareTo(other.GetBigInteger());
        }

        private BigInteger GetBigInteger()
        {
            BigInteger result = (BigInteger)_high << 64;
            result |= _low;
            return result;
        }

        public Int64 ToInt64()
        {
            var bigInteger = GetBigInteger();
            return bigInteger < -9223372036854775808 ? -9223372036854775808 :
            bigInteger > 9223372036854775807 ? 9223372036854775807 : (long)bigInteger;
        }

        public UInt64 ToUInt64()
        {
            var bigInteger = GetBigInteger();
            return bigInteger < 0 ? 0ul : bigInteger > 18446744073709551615 ? 18446744073709551615 : (ulong)bigInteger;
        }

        public Int32 ToInt32()
        {
            var bigInteger = GetBigInteger();
            return bigInteger < -2147483648 ? -2147483648 :
            bigInteger > 2147483647 ? 2147483647 : (int)bigInteger;
        }

        public Int16 ToInt16()
        {
            var bigInteger = GetBigInteger();
            return bigInteger < -32768 ? (short)-32768 :
            bigInteger > 32767 ? (short)32767 : (short)bigInteger;
        }

        public Single ToSingle() => (float)GetBigInteger();

        public Double ToDouble() => (double)GetBigInteger();

        public override string ToString()
        {
            return GetBigInteger().ToString();
        }

        public string ToString(string format)
        {
            return GetBigInteger().ToString(format);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return GetBigInteger().ToString(format, formatProvider);
        }
    }
}
