using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathIS.Model.Entities
{
    public class BaseMathEntity
    {
        public bool Error { get; set; }
        public string ErrorMessage { get; set; }

        public virtual BaseMathEntity Add(BaseMathEntity x)
        {
            throw new Exception("Operation not implemented");
        }
        public virtual BaseMathEntity Subtract(BaseMathEntity x)
        {
            throw new Exception("Operation not implemented");
        }
        public virtual BaseMathEntity Multiply(BaseMathEntity x)
        {
            throw new Exception("Operation not implemented");
        }
        public virtual BaseMathEntity MatrixMultiply(BaseMathEntity x)
        {
            throw new Exception("Operation not implemented");
        }

        public virtual BaseMathEntity Conjugate()
        {
            throw new Exception("Operation not implemented");
        }

        public virtual BaseMathEntity Normalize()
        {
            throw new Exception("Operation not implemented");
        }

        public virtual BaseMathEntity Determinanta()
        {
            throw new Exception("Operation not implemented");
        }

        public virtual void Round(uint decimals)
        {
            throw new Exception("Operation not implemented");
        }

        public virtual BaseMathEntity Clone()
        {
            throw new Exception("Operation not implemented");
        }
    }
}
