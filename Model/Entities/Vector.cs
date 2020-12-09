using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathIS.Model.Entities
{
    public class Vector: BaseMathEntity
    {
        private List<Number> _components;
        private string _text;

        public List<Number> Components
        {
            get { return _components; }
        }

        public Vector(IEnumerable<Number> components)
        {
            _components = new List<Number>();
            foreach (var num in components)
                _components.Add(num.Clone());
            UpdateText();
        }

        public Vector(string input)
        {
            _components = new List<Number>();
            var sp = input.Trim().Split(',');
            foreach (var str in sp)
                _components.Add(Number.ParseFrom(str.Trim()));
            UpdateText();
        }

        public Vector(int dimensions)
        {
            _components = new List<Number>();
            for (int i = 0; i < dimensions; ++i)
                _components.Add(new Number(0));
            UpdateText();
        }

        private void UpdateText()
        {
            _text = "";
            foreach(var n in _components)
            {
                if (_text != "")
                    _text += ",";
                _text += n.ToString();
            }

            _text = string.Format("[{0}]", _text);
        }

        public override string ToString()
        {
            return _text;
        }

        #region Operators
        public override BaseMathEntity Multiply(BaseMathEntity x)
        {
            if (x is Number)
            {
                return ((this) * ((Number)x));
            }
            else if (x is Vector)
            {
                return ((this) * ((Vector)x));
            }
            else if (x is Matrix)
            {
                return ((this) * ((Matrix)x));
            }
            return base.Add(x);
        }
        public override BaseMathEntity MatrixMultiply(BaseMathEntity x)
        {
            if (x is Vector)
            {
                return ((this) & ((Vector)x));
            }
            return base.Add(x);
        }
        public static Vector operator +(Vector b, Vector c)
        {
            if (b.Components.Count != c.Components.Count)
                throw new Exception("Vectors have to be of the same order!");
            List<Number> components = new List<Number>();
            for (int i = 0; i < b.Components.Count; ++i)
            {
                components.Add(b.Components.ElementAt(i) + c.Components.ElementAt(i));
            }
            Vector num = new Vector(components);
            return num;
        }
        public static Vector operator -(Vector b, Vector c)
        {
            if (b.Components.Count != c.Components.Count)
                throw new Exception("Vectors have to be of the same order!");
            List<Number> components = new List<Number>();
            for (int i = 0; i < b.Components.Count; ++i)
            {
                components.Add(b.Components.ElementAt(i) - c.Components.ElementAt(i));
            }
            Vector num = new Vector(components);
            return num;
        }

        public static Vector operator *(Vector b, Number c)
        {
            List<Number> components = new List<Number>();
            for (int i = 0; i < b.Components.Count; ++i)
            {
                components.Add(b.Components.ElementAt(i) * c);
            }
            Vector num = new Vector(components);
            return num;
        }
        public static Vector operator *(Number c, Vector b)
        {
            List<Number> components = new List<Number>();
            for (int i = 0; i < b.Components.Count; ++i)
            {
                components.Add(b.Components.ElementAt(i) * c);
            }
            Vector num = new Vector(components);
            return num;
        }

        public static Number operator *(Vector b, Vector c)
        {
            if (b.Components.Count != c.Components.Count)
                throw new Exception("Vectors have to be of the same order!");
            Number result = new Number(0);
            for (int i = 0; i < b.Components.Count; ++i)
            {
                result = result + b.Components.ElementAt(i) * c.Components.ElementAt(i);
            }
            return result;
        }

        public static Matrix operator &(Vector b, Vector c)
        {
            if (b.Components.Count != c.Components.Count)
                throw new Exception("Vectors have to be of the same order!");
            Matrix result = new Matrix(b.Components.Count, b.Components.Count);
            for (int i = 0; i < b.Components.Count; ++i)
            {
                for (int j = 0; j < b.Components.Count; ++j)
                {
                    result.Components[i, j] = b.Components[i] * c.Components[j];
                }
            }
            return result;
        }

        public static Vector operator *(Matrix b, Vector c)
        {
            if (b.Columns != c.Components.Count)
                throw new Exception("Number of matrix columns have to be the same as vector components count!");
            List<Number> components = new List<Number>();
            for (int j = 0; j < b.Rows; ++j)
            {
                Number comp = new Number(0);
                for (int i = 0; i < b.Columns; ++i)
                {
                    comp = comp + b.Components[j, i] * c.Components[i];
                }
                components.Add(comp);
            }
            return new Vector(components);
        }

        public static Vector operator *(Vector c, Matrix b )
        {
            return b * c;
        }

        public static Vector operator &(Matrix b, Vector c)
        {
            return b * c;
        }

        public static Vector operator &(Vector c, Matrix b)
        {
            return b * c;
        }
        #endregion
    }
}
