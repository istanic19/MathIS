using MathIS.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathIS.Model.Entities
{
    public class AritmeticType
    {
        private AritmeticTypeEnum _type;
        public AritmeticTypeEnum Aritmetc
        {
            get { return _type; }
        }

        public AritmeticType(AritmeticTypeEnum tp)
        {
            _type = tp;
        }

        public override string ToString()
        {
            return _type.ToString();
        }
    }

   
}
