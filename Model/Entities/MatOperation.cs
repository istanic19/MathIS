using MathIS.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathIS.Model.Entities
{
    public class MatOperation
    {
        private Operation _operation;
        public Operation Operation
        {
            get { return _operation; }
        }
        public MatOperation(Operation o)
        {
            _operation = o;
        }

        public override string ToString()
        {
            return _operation.ToString(0);
        }

    }
}
