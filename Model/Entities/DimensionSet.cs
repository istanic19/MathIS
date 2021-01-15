using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathIS.Model.Entities
{
    [Serializable]
    public class DimensionSet
    {
        public int VectorDimensions { get; set; }
        public int MatrixRows { get; set; }
        public int MatrixColumns { get; set; }

        public DimensionSet()
        {
            VectorDimensions = 2;
            MatrixRows = 2;
            MatrixColumns = 2;
        }
    }
}
