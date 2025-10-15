#line 2 "Temp/GeneratedCode/TypeWrapTest/SimpleTests__TypeWrapGenerator_596515985_0.g.cs"
#pragma warning disable 0219

using System;
using System.Collections.Generic;
using TypeWrap;
using UnityEngine;

namespace TypeWrapTest
{


#pragma warning disable

    [global::System.ComponentModel.TypeConverter(typeof(FruitKindValue.FruitKindValueTypeConverter))]
    partial record struct FruitKindValue : global::TypeWrap.IWrap<FruitKind>
        , global::System.IEquatable<FruitKindValue>
        , global::System.IEquatable<FruitKind>
        , global::System.IComparable
        , global::System.IComparable<FruitKindValue>
        , global::System.IComparable<FruitKind>
    {
        public static readonly FruitKindValue Apple = new FruitKindValue(FruitKind.Apple);

        public static readonly FruitKindValue Banana = new FruitKindValue(FruitKind.Banana);

        public static readonly FruitKindValue Orange = new FruitKindValue(FruitKind.Orange);

        public readonly int CompareTo(FruitKind other)
            => ((int)this._).CompareTo((int)other);

        public readonly int CompareTo(FruitKindValue other)
            => this.CompareTo(other._);

        public readonly int CompareTo(object obj)
            => obj switch
            {
                FruitKindValue other => CompareTo(other),
                FruitKind other => this._.CompareTo(other),
                _ => 1,
            };

        public readonly bool Equals(FruitKind other)
            => this._ == other;

        public readonly bool Equals(FruitKindValue other)
            => this._ == other._;

        public readonly override int GetHashCode()
            => ((int)this._).GetHashCode();

        public readonly override string ToString()
            => this._.ToString();

        public static implicit operator FruitKindValue(FruitKind value)
            => new FruitKindValue(value);

        public static implicit operator FruitKind(FruitKindValue value)
            => value._;

        public static FruitKindValue operator ~(FruitKindValue value)
        {
            return new FruitKindValue((FruitKind)(~(value._)));
        }

        public static FruitKindValue operator ++(FruitKindValue value)
        {
            var tempValue = value._;
            tempValue ++;
            return new FruitKindValue((FruitKind)(tempValue));
        }

        public static FruitKindValue operator --(FruitKindValue value)
        {
            var tempValue = value._;
            tempValue --;
            return new FruitKindValue((FruitKind)(tempValue));
        }

        public static FruitKindValue operator +(FruitKindValue left, int right)
        {
            return new FruitKindValue((FruitKind)(left._ + right));
        }

        public static FruitKindValue operator -(FruitKindValue left, FruitKindValue right)
        {
            return new FruitKindValue((FruitKind)(left._ - right._));
        }

        public static FruitKindValue operator &(FruitKindValue left, FruitKindValue right)
        {
            return new FruitKindValue((FruitKind)(left._ & right._));
        }

        public static FruitKindValue operator |(FruitKindValue left, FruitKindValue right)
        {
            return new FruitKindValue((FruitKind)(left._ | right._));
        }

        public static FruitKindValue operator ^(FruitKindValue left, FruitKindValue right)
        {
            return new FruitKindValue((FruitKind)(left._ ^ right._));
        }

        public static bool operator >(FruitKindValue left, FruitKindValue right)
        {
            return left._ > right._;
        }

        public static bool operator <(FruitKindValue left, FruitKindValue right)
        {
            return left._ < right._;
        }

        public static bool operator >=(FruitKindValue left, FruitKindValue right)
        {
            return left._ >= right._;
        }

        public static bool operator <=(FruitKindValue left, FruitKindValue right)
        {
            return left._ <= right._;
        }

        public static FruitKindValue operator -(FruitKindValue left, int right)
        {
            return new FruitKindValue(left._ - right);
        }

        private sealed class FruitKindValueTypeConverter : global::System.ComponentModel.TypeConverter
        {
            private static readonly global::System.Type s_wrapperType = typeof(FruitKindValue);
            private static readonly global::System.Type s_underlyingType = typeof(FruitKind);

            public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
            {
                if (sourceType == s_wrapperType || sourceType == s_underlyingType) return true;
                return base.CanConvertFrom(context, sourceType);
            }

            public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
            {
                if (destinationType == s_wrapperType || destinationType == s_underlyingType) return true;
                return base.CanConvertTo(context, destinationType);
            }

            public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
            {
                if (value != null)
                {
                    var t = value.GetType();
                    if (t == typeof(FruitKindValue)) return (FruitKindValue)value;
                    if (t == typeof(FruitKind)) return new FruitKindValue((FruitKind)value);
                }
                return base.ConvertFrom(context, culture, value);
            }

            public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
            {
                if (value is FruitKindValue wrappedValue)
                {
                    if (destinationType == s_wrapperType) return wrappedValue;
                    if (destinationType == s_underlyingType) return wrappedValue._;
                }
                return base.ConvertTo(context, culture, value, destinationType);
            }
        }

    }


}
