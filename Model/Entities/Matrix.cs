using MathIS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathIS.Model.Entities
{
    public class Matrix: BaseMathEntity
    {
        private Number[,] _components;
        private int _rows;
        private int _columns;

        public Number[,] Components
        {
            get { return _components; }
        }
        public int Rows
        {
            get { return _rows; }
        }
        public int Columns
        {
            get { return _columns; }
        }

        public Matrix(int rows, int columns)
        {
            _rows = rows;
            _columns = columns;
            _components = new Number[_rows, _columns];
            for (int i = 0; i < _rows; ++i)
            {
                for (int j = 0; j < _columns; ++j)
                {
                    _components[i, j] = new Number(0);
                }
            }
        }

        public Matrix(int rows, int columns, string input)
        {
            _rows = rows;
            _columns = columns;
            _components = new Number[_rows, _columns];
            for (int i = 0; i < _rows; ++i)
            {
                for (int j = 0; j < _columns; ++j)
                {
                    _components[i, j] = new Number(0);
                }
            }
            InitializeComponents(input);
        }

        public void InitializeComponents(string input)
        {
            var rows = input.Split(';');
            int rowIndex = 0;
            foreach(var row in rows)
            {
                if (rowIndex >= _rows)
                    break;
                var vector = new Vector(row);
                for (int i = 0; i < vector.Components.Count && i < _columns; ++i)
                {
                    _components[rowIndex, i] = vector.Components.ElementAt(i).Clone();
                }
                rowIndex++;
            }
        }

        private string GetText()
        {
            var text = "";
            for (int i = 0; i < _rows; ++i)
            {
                if (text != "")
                    text += "\r\n";
                var row = "";
                for (int j = 0; j < _columns; ++j)
                {
                    row += _components[i, j].ToString(true);
                }
                text += row;
            }

            return text;
        }

        public override void Round(uint decimals)
        {
            foreach (var c in Components)
                c.Round(decimals);
        }

        public override string ToString()
        {
            return GetText();
        }

        public override BaseMathEntity Conjugate()
        {
            var conj = new Matrix(Rows, Columns);
            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Columns; ++j)
                {
                    conj.Components[i, j] = (Number)Components[i, j].Conjugate();
                }
            }
            return conj;
        }

        public override BaseMathEntity Multiply(BaseMathEntity x)
        {
            if (x is Vector)
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
            return Multiply(x);
        }

        public static Matrix operator *(Matrix b, Matrix c)
        {
            if (b.Columns != c.Rows)
                throw new Exception("First matrix columns number have to be the same as second matrix rows number!");
            Matrix result = new Matrix(b.Rows, c.Columns);

            for (int i = 0; i < b.Rows; ++i)
            {
                
                for (int z = 0; z < c.Columns; ++z)
                {
                    Number num = new Number(0);
                    for (int j = 0; j < b.Columns; ++j)
                    {
                        num = num + (b.Components[i, j] * c.Components[j, z]);
                    }
                    result.Components[i, z] = num;
                }
            }
            return result;
        }

        public static Matrix operator &(Matrix b, Matrix c)
        {
            return b * c;
        }
    }
}
