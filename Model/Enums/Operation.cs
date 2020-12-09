using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathIS.Model.Enums
{
    public enum Operation
    {
        Add = 0,
        Subtract = 1,
        Multiply = 2,
        Divide = 3,
        Power = 4,
        Root = 5
    }

    public static class OperationExstensionClass
    {
        public static string ToString(this Operation o, int dummy)
        {
            switch(o)
            {
                case Operation.Add:
                    return "+ (Add)";
                case Operation.Subtract:
                    return "- (Subtract)";
                case Operation.Multiply:
                    return "X (Multiply)";
                case Operation.Divide:
                    return "/ (Divide)";
                case Operation.Power:
                    return "^ (Power to)";
                case Operation.Root:
                    return "¬V (Root)";
            }

            return o.ToString();
        }
    }
}
