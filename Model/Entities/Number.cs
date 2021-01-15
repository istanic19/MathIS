using MathIS.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathIS.Model.Entities
{
    public class Number: BaseMathEntity
    {
        private decimal _real;
        private decimal _imaginary;

        public decimal Real
        {
            get { return _real; }
        }

        public decimal Imaginary
        {
            get { return _imaginary; }
        }

        public decimal AngleDeg
        {
            get { return GetAngle(true); }
        }

        public decimal AngleRad
        {
            get { return GetAngle(false); }
        }

        public decimal Module
        {
            get { return GetModule(); }
        }

        public override BaseMathEntity Clone()
        {
            return new Number(Real, Imaginary);
        }

        public override BaseMathEntity Conjugate()
        {
            return new Number(Real, -Imaginary);
        }

        public override BaseMathEntity Normalize()
        {
            if (Real == 0 && Imaginary == 0)
                return new Number(0);
            return new Number(Real / GetModule(), Imaginary /GetModule());
        }

        public override void Round(uint decimals)
        {
            _real = Math.Round(Real, (int)decimals, MidpointRounding.AwayFromZero);
            _imaginary = Math.Round(Imaginary, (int)decimals, MidpointRounding.AwayFromZero);
        }

        public override string ToString()
        {
            if (_real != 0 && _imaginary != 0)
            {
                if (Math.Abs(_imaginary) == 1m)
                    return string.Format("({0} {1} j)", _real, _imaginary < 0 ? "-" : "+");
                else
                    return string.Format("({0} {1} {2} j)", _real, _imaginary < 0 ? "-" : "+", Math.Abs(_imaginary));
            }
            else if (_real != 0)
                return string.Format("{0}{1}{2}", _real < 0 ? "(" : "", _real, _real < 0 ? ")" : "");
            else if (_imaginary != 0)
            {
                if (Math.Abs(_imaginary) == 1m)
                {
                    if (_imaginary < 0)
                        return "- j";
                    else
                        return "j";
                }
                else
                    return string.Format("{0}{1} j{2}", _imaginary < 0 ? "(" : "", _imaginary, _imaginary < 0 ? ")" : "");
            }
            else
                return "0";
        }

        public string Text
        {
            get
            {
                return ToString().Replace("(", "").Replace(")", "");
            }
        }

        public static Number ParseFrom(string input)
        {
            input = input.Trim().ToLower();
            if(input.StartsWith("+"))
            {
                if (input.Length == 1)
                    return null;
                input = input.Substring(1).Trim();
            }

            input = input.Replace('i', 'j');
            if (input.ToList().Count(c => c == 'j') > 1)
                return null;

            decimal real = 0m;
            decimal imag = 0m;

            if (!input.Contains("j"))
            {
                if (!decimal.TryParse(input, out real))
                    return null;
            }
            else
            {
                bool firstNegative = input.StartsWith("-");
                if (firstNegative)
                {
                    if (input.Length == 1)
                        return null;
                    input = input.Substring(1).Trim();
                }

                if (input == "j")
                {
                    if (firstNegative)
                        return new Number(0, -1);
                    else
                        return new Number(0, 1);
                }

                if (!char.IsDigit(input[0]))
                    return null;

                if (!input.Contains("-") && !input.Contains("+"))
                {
                    if (!input.EndsWith("j") || input.Length < 2)
                        return null;

                    if (!decimal.TryParse(input.Substring(0, input.Length - 1).Trim(), out imag))
                        return null;
                    if (firstNegative)
                        imag = -imag;
                }
                else
                {
                    if (!input.EndsWith("j") || input.Length < 2)
                        return null;

                    input = input.Substring(0, input.Length - 1).Trim();

                    if (!input.Contains("-") && !input.Contains("+"))
                    {
                        return null;
                    }

                    bool secondNegative = input.Contains("-");

                    input = input.Replace('-', '|').Replace('+', '|');
                    var parts = input.Split('|');

                    if (parts.Length != 2)
                        return null;
                    if (!decimal.TryParse(parts[0].Trim(), out real))
                        return null;
                    if (parts[1].Trim() == "")
                        imag = 1m;
                    else if (!decimal.TryParse(parts[1].Trim(), out imag))
                        return null;

                    if (firstNegative)
                        real = -real;
                    if (secondNegative)
                        imag = -imag;
                }
            }

            return new Number(real, imag);
        }

        public Number(decimal value, decimal? img = null)
        {
            _real = value;
            _imaginary = img.HasValue ? img.Value : 0;
        }

        public Quadrant GetQuadrant()
        {
            if (Real < 0 && Imaginary >= 0)
                return Quadrant.Second;
            else if (Real < 0 && Imaginary < 0)
                return Quadrant.Third;
            else if (Real >= 0 && Imaginary < 0)
                return Quadrant.Fourth;
            return Quadrant.First;
        }

        public decimal GetModule()
        {
            return (decimal)Math.Sqrt((double)(Real * Real) + (double)(Imaginary * Imaginary));
        }

        public decimal Magnitude()
        {
            return Real * Real + Imaginary * Imaginary;
        }
        

        public decimal GetAngle(bool deg = false)
        {
            if (Real == 0 && Imaginary == 0)
                return 0m;
            else if (Real == 0 && Imaginary > 0)
            {
                if (deg)
                    return 90;
                else
                    return ((decimal)Math.PI) / 2m;
            }
            else if (Real < 0 && Imaginary == 0)
            {
                if (deg)
                    return 180;
                else
                    return ((decimal)Math.PI);
            }
            else if (Real == 0 && Imaginary < 0)
            {
                if (deg)
                    return 270;
                else
                    return (3.0m * ((decimal)Math.PI)) / 2m;
            }
            else
            {
                var angle = (decimal)Math.Atan((double)Math.Abs(Imaginary / Real));
                var quadrant = GetQuadrant();
                if (quadrant == Quadrant.Second)
                    angle = (decimal)Math.PI - angle;
                else if (quadrant == Quadrant.Third)
                    angle = ((decimal)Math.PI) + angle;
                else if (quadrant == Quadrant.Fourth)
                    angle = ((decimal)Math.PI) * 2.0m - angle;

                if (deg)
                    return angle * 180.0m / ((decimal)Math.PI);
                else
                    return angle;
            }
        }

        public void CopyFrom(Number number)
        {
            this._real = number.Real;
            this._imaginary = number.Imaginary;
        }


        public Number Root(int root)
        {
            bool negative = root < 0;
            if (negative)
                root = -root;

            var module = Math.Pow((double)GetModule(), 1 / ((double)root));
            var angle = ((double)GetAngle()) / ((double)root);

            var real = (decimal)(Math.Cos(angle) * module);
            var imag = (decimal)(Math.Sin(angle) * module);
            if(negative)
                return new Number(real, imag).Inverse();
            else 
                return new Number(real, imag);
        }

        public Number Root(Number root)
        {
            return this.Power(root.Inverse());
        }

        public Number Power(int exponent)
        {
            if (exponent == 0)
                return new Number(1, 0);
            var current = Clone() as Number;
            var result = Clone() as Number;

            bool negative = exponent < 0;
            if (negative)
                exponent = -exponent;

            for (int i = 1; i < exponent; ++i)
            {
                result = result * current;
                
            }

            if (negative)
                result = result.Inverse();

            return result;
        }

        public Number Power(Number exponent)
        {
            if (exponent == 0)
                return new Number(1, 0);

            exponent = exponent.Clone() as Number;

            int r = DecimalPlaces(exponent.Real);
            int i = DecimalPlaces(exponent.Imaginary);
            int root = 1;
            if (i > r && i > 0)
                root = ((int)Math.Pow(10, i));
            else if (r > 0)
                root = ((int)Math.Pow(10, r));

            if (i > r)
                exponent = exponent * root;
            else
                exponent = exponent * root;

            double absPotencija = Math.Log((double)GetModule());
            double imgPotencija = (double)GetAngle();

            Number temp = new Number((decimal)absPotencija, (decimal)imgPotencija);
            Number intermediate = temp * exponent;

            double abs = Math.Pow(Math.E, (double)intermediate.Real);
            Number result = new Number((decimal)(abs * Math.Cos((double)intermediate.Imaginary)), (decimal)(abs * Math.Sin((double)intermediate.Imaginary)));

            if (root > 1)
                result = result.Root(root);

            return result;
        }

        private static int DecimalPlaces(decimal number)
        {
            int n = 0;
            while((number-((decimal)((int)number)))!=0)
            {
                n++;
                number *= 10m;
            }
            return n;
        }


        public Number Inverse()
        {
            if (Real == 0 && Imaginary == 0)
                throw new Exception("Attempt to divide by zero!");

            if (Imaginary == 0)
                return new Number(1.0m / Real);
            else if (Real == 0)
                return new Number(0, -Imaginary);
            else
            {
                decimal divider = Real * Real + Imaginary * Imaginary;
                return new Number(Real / divider, -Imaginary / divider);
            }

        }



        #region Operators

        public override BaseMathEntity Add(BaseMathEntity x)
        {
            if(x is Number)
            {
                return ((this) + ((Number)x));
            }
            return base.Add(x);
        }
        public override BaseMathEntity Subtract(BaseMathEntity x)
        {
            if (x is Number)
            {
                return ((this) - ((Number)x));
            }
            return base.Add(x);
        }
        public override BaseMathEntity Multiply(BaseMathEntity x)
        {
            if (x is Number)
            {
                return ((this) * ((Number)x));
            }
            else if (x is Vector)
            {
                return (((Vector)x) * (this));
            }
            return base.Add(x);
        }
        public static Number operator +(Number b, Number c)
        {
            Number num = new Number(b.Real + c.Real, b.Imaginary + c.Imaginary);
            return num;
        }
        public static Number operator +(Number b, int c)
        {
            Number num = new Number(b.Real + (decimal)c, b.Imaginary);
            return num;
        }
        public static Number operator +(int c, Number b)
        {
            Number num = new Number(b.Real + (decimal)c, b.Imaginary);
            return num;
        }
        public static Number operator +(Number b, decimal c)
        {
            Number num = new Number(b.Real + c, b.Imaginary);
            return num;
        }
        public static Number operator +(decimal c, Number b)
        {
            Number num = new Number(b.Real + c, b.Imaginary);
            return num;
        }
        public static Number operator -(Number b, Number c)
        {
            Number num = new Number(b.Real - c.Real, b.Imaginary - c.Imaginary);
            return num;
        }
        public static Number operator -(Number b, int c)
        {
            Number num = new Number(b.Real - (decimal)c, b.Imaginary);
            return num;
        }
        public static Number operator -(int c, Number b)
        {
            Number num = new Number((decimal)c - b.Real, b.Imaginary);
            return num;
        }
        public static Number operator -(Number b, decimal c)
        {
            Number num = new Number(b.Real - c, b.Imaginary);
            return num;
        }
        public static Number operator -(decimal c, Number b)
        {
            Number num = new Number(c - b.Real, b.Imaginary);
            return num;
        }
        public static Number operator *(Number b, Number c)
        {
            decimal real = b.Real * c.Real - (b.Imaginary * c.Imaginary);
            decimal img = b.Real * c.Imaginary + b.Imaginary * c.Real;
            Number num = new Number(real, img);
            return num;
        }
        public static Number operator *(Number b, int c)
        {
            Number num = new Number(b.Real * ((decimal)c), b.Imaginary * ((decimal)c));
            return num;
        }
        public static Number operator *(int c, Number b)
        {
            Number num = new Number(b.Real * ((decimal)c), b.Imaginary * ((decimal)c));
            return num;
        }
        public static Number operator *(Number b, decimal c)
        {
            Number num = new Number(b.Real * c, b.Imaginary * c);
            return num;
        }
        public static Number operator *(decimal c, Number b)
        {
            Number num = new Number(b.Real * c, b.Imaginary * c);
            return num;
        }
        public static Number operator /(Number b, Number c)
        {
            if (c.Real == 0 && c.Imaginary == 0)
                throw new Exception("Attempt to divide by zero!");
            return b*c.Inverse();
        }
        public static Number operator /(Number b, int c)
        {
            if (c == 0)
                throw new Exception("Attempt to divide by zero!");
            return new Number(b.Real/((decimal)c), b.Imaginary / ((decimal)c));
        }
        public static Number operator /(int c, Number b)
        {
            if (b.Real == 0 && b.Imaginary == 0)
                throw new Exception("Attempt to divide by zero!");
            return c * b.Inverse();
        }
        public static Number operator /(Number b, decimal c)
        {
            if (c == 0)
                throw new Exception("Attempt to divide by zero!");
            return new Number(b.Real / c, b.Imaginary / c);
        }
        public static Number operator /(decimal c, Number b)
        {
            if (b.Real == 0 && b.Imaginary == 0)
                throw new Exception("Attempt to divide by zero!");
            return c * b.Inverse();
        }


        #region Equality
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Number)
                return (Real == ((Number)obj).Real && Imaginary == ((Number)obj).Imaginary);
            return false;
        }
        public static bool operator ==(Number num1, Number num2)
        {
            if (object.ReferenceEquals(num1, null))
            {
                return object.ReferenceEquals(num2, null);
            }

            return num1.Equals(num2);
        }
        public static bool operator !=(Number num1, Number num2)
        {
            if (object.ReferenceEquals(num1, null))
            {
                return !object.ReferenceEquals(num2, null);
            }

            return !num1.Equals(num2);
        }
        public static bool operator ==(Number num1, int num2)
        {
            if (object.ReferenceEquals(num1, null))
            {
                return false;
            }

            return num1.Real == (decimal)num2 && num1.Imaginary == 0;
        }
        public static bool operator !=(Number num1, int num2)
        {
            if (object.ReferenceEquals(num1, null))
            {
                return true;
            }

            return num1.Real != (decimal)num2;
        }

        #endregion

        #endregion
    }

    public static class NumberExtensionMethods
    {
        public static string ToString(this Number num, bool parenthesis)
        {
            var s = num.ToString();

            if (!parenthesis)
            {
                if (s.StartsWith("(") && s.EndsWith(")") && s.Length > 2)
                    return s.Substring(1, s.Length - 2).Trim();
                else
                    return s;
            }

            
            if (!s.StartsWith("("))
                return string.Format("({0})", s);
            else
                return s;
        }
    }
}
