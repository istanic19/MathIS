using MathIS.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathIS.Model.Entities
{
    public class VectorOperation
    {
        private VectorOperationEnum _operation;
        public VectorOperationEnum Operation
        {
            get { return _operation; }
        }
        public VectorOperation(VectorOperationEnum o)
        {
            _operation = o;
        }

        public override string ToString()
        {
            return _operation.ToString();
        }
    }
}
