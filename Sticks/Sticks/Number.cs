using System;

namespace Sticks
{
    class Number
    {
        //Internal number representation:
        private uint val;

        //The character we use for the string representation:
        private static readonly char NumChar = 'I';

        public string Symbol
        {
            //Return a sequence of "I" chars representing val.
            //Examples:
            // 0 => ""
            // 1 => "I"
            // 4 => "IIII"
            // 7 => "IIIIIII"
            get
            {
                /*
                String result = "";

                for (uint i = 0; i < val; i++)
                {
                    result += NumChar;
                }

                return result;
                */

                return new string(NumChar, (int)val);
            }

            //Convert sequence of "I" chars to val.
            //Examples:
            // "" => 0
            // "I" => 1
            //...
            //Caution: Throw a FormatException for invalid chars!
            set
            {
                //Check for validity:
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] != NumChar)
                    {
                        throw new FormatException(string.Format("Invalid character ({0} at position {1})!", value[i], i));
                    }
                }

                val = (uint)value.Length;
            }
        }

        public Number(int newVal)
        {
            if (newVal < 0)
            {
                throw new FormatException("Negative values are not allowed.");
            }

            val = (uint)newVal;
        }

        public Number(uint newVal)
        {
            val = newVal;
        }

        public Number(string newVal)
        {
            Symbol = newVal;
        }

        //Override ToString() for stick representation:
        public override string ToString()
        {
            return Symbol;
        }

        //Operator overload for '+' between two instances of Number:
        public static Number operator +(Number a, Number b)
        {
            return new Number(a.val + b.val);
        }

        //TODO: More operators!

        public static Number operator -(Number a, Number b)
        {
            if (a < b)
            {
                throw new InvalidOperationException("Subtraction leads to negative number.");
            }

            return new Number(a.val - b.val);
        }

        public static Number operator *(Number a, Number b)
        {
            return new Number(a.val * b.val);
        }

        public static Number operator /(Number a, Number b)
        {
            if (b.val == 0)
            {
                throw new InvalidOperationException("Division by 0 is not allowed.");
            }

            if ((a.val % b.val) != 0)
            {
                throw new InvalidOperationException("Only integer division without remainder allowed.");
            }

            return new Number(a.val / b.val);
        }

        public static bool operator<(Number a, Number b)
        {
            return (a.val < b.val);
        }

        public static bool operator>(Number a, Number b)
        {
            return (a.val > b.val);
        }

        public static bool operator ==(Number a, Number b)
        {
            return (a.val == b.val);
        }

        public static bool operator !=(Number a, Number b)
        {
            return (a.val != b.val);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Number))
            {
                return false;
            }

            Number num = (Number)obj;
            return (num == this);
        }

        //E.g. to use Number as key in a dictionary.
        public override int GetHashCode()
        {
            return (int)val;
        }
    }
}
