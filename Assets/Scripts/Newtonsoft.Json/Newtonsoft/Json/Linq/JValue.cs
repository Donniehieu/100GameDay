using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq.Expressions;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>, IConvertible
	{
		private class JValueDynamicProxy : DynamicProxy<JValue>
		{
			public override bool TryConvert(JValue instance, ConvertBinder binder, [NotNullWhen(true)] out object? result)
			{
				result = null;
				return false;
			}

			public override bool TryBinaryOperation(JValue instance, BinaryOperationBinder binder, object arg, [NotNullWhen(true)] out object? result)
			{
				result = null;
				return false;
			}

			public JValueDynamicProxy()
			{
				((DynamicProxy<>)(object)this)._002Ector();
			}
		}

		private JTokenType _valueType;

		private object? _value;

		public override bool HasValues => false;

		public override JTokenType Type => default(JTokenType);

		public new object? Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			return null;
		}

		internal JValue(object? value, JTokenType type)
		{
		}

		public JValue(JValue other)
		{
		}

		public JValue(long value)
		{
		}

		public JValue(decimal value)
		{
		}

		public JValue(char value)
		{
		}

		[CLSCompliant(false)]
		public JValue(ulong value)
		{
		}

		public JValue(double value)
		{
		}

		public JValue(float value)
		{
		}

		public JValue(DateTime value)
		{
		}

		public JValue(DateTimeOffset value)
		{
		}

		public JValue(bool value)
		{
		}

		public JValue(string? value)
		{
		}

		public JValue(Guid value)
		{
		}

		public JValue(Uri? value)
		{
		}

		public JValue(TimeSpan value)
		{
		}

		public JValue(object? value)
		{
		}

		internal override bool DeepEquals(JToken node)
		{
			return false;
		}

		private static int CompareBigInteger(BigInteger i1, object i2)
		{
			return 0;
		}

		internal static int Compare(JTokenType valueType, object? objA, object? objB)
		{
			return 0;
		}

		private static int CompareFloat(object objA, object objB)
		{
			return 0;
		}

		private static bool Operation(ExpressionType operation, object? objA, object? objB, out object? result)
		{
			result = null;
			return false;
		}

		internal override JToken CloneToken()
		{
			return null;
		}

		public static JValue CreateComment(string? value)
		{
			return null;
		}

		public static JValue CreateString(string? value)
		{
			return null;
		}

		public static JValue CreateNull()
		{
			return null;
		}

		public static JValue CreateUndefined()
		{
			return null;
		}

		private static JTokenType GetValueType(JTokenType? current, object? value)
		{
			return default(JTokenType);
		}

		private static JTokenType GetStringValueType(JTokenType? current)
		{
			return default(JTokenType);
		}

		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		internal override int GetDeepHashCode()
		{
			return 0;
		}

		private static bool ValuesEquals(JValue v1, JValue v2)
		{
			return false;
		}

		public bool Equals(JValue? other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(string format)
		{
			return null;
		}

		public string ToString(IFormatProvider formatProvider)
		{
			return null;
		}

		public string ToString(string? format, IFormatProvider formatProvider)
		{
			return null;
		}

		protected override DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return null;
		}

		private int System_002EIComparable_002ECompareTo(object obj)
		{
			return 0;
		}

		public int CompareTo(JValue obj)
		{
			return 0;
		}

		private TypeCode System_002EIConvertible_002EGetTypeCode()
		{
			return default(TypeCode);
		}

		private bool System_002EIConvertible_002EToBoolean(IFormatProvider provider)
		{
			return false;
		}

		private char System_002EIConvertible_002EToChar(IFormatProvider provider)
		{
			return '\0';
		}

		private sbyte System_002EIConvertible_002EToSByte(IFormatProvider provider)
		{
			return 0;
		}

		private byte System_002EIConvertible_002EToByte(IFormatProvider provider)
		{
			return 0;
		}

		private short System_002EIConvertible_002EToInt16(IFormatProvider provider)
		{
			return 0;
		}

		private ushort System_002EIConvertible_002EToUInt16(IFormatProvider provider)
		{
			return 0;
		}

		private int System_002EIConvertible_002EToInt32(IFormatProvider provider)
		{
			return 0;
		}

		private uint System_002EIConvertible_002EToUInt32(IFormatProvider provider)
		{
			return 0u;
		}

		private long System_002EIConvertible_002EToInt64(IFormatProvider provider)
		{
			return 0L;
		}

		private ulong System_002EIConvertible_002EToUInt64(IFormatProvider provider)
		{
			return 0uL;
		}

		private float System_002EIConvertible_002EToSingle(IFormatProvider provider)
		{
			return 0f;
		}

		private double System_002EIConvertible_002EToDouble(IFormatProvider provider)
		{
			return 0.0;
		}

		private decimal System_002EIConvertible_002EToDecimal(IFormatProvider provider)
		{
			return default(decimal);
		}

		private DateTime System_002EIConvertible_002EToDateTime(IFormatProvider provider)
		{
			return default(DateTime);
		}

		private object System_002EIConvertible_002EToType(Type conversionType, IFormatProvider provider)
		{
			return null;
		}
	}
}
