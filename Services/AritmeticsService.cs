using MathIS.Model.Entities;
using MathIS.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathIS.Services
{
    public static class AritmeticsService
    {
        public static List<MatOperation> Operations { get; set; }

        static AritmeticsService()
        {
            Operations = new List<MatOperation>();
            foreach (var enumValue in Enum.GetValues(typeof(Operation)))
            {
                Operations.Add(new MatOperation((Operation)enumValue));
            }
        }

        public static Number Calculate(MatOperation operation, Number a, Number b)
        {
            Number result = null;

            switch (operation.Operation)
            {
                case Operation.Add:
                    return (a + b);
                case Operation.Subtract:
                    return (a - b);
                case Operation.Multiply:
                    return (a * b);
                case Operation.Divide:
                    return (a / b);
                case Operation.Power:
                    if (b.Imaginary == 0)
                        return a.Power((int)b.Real);
                    else
                        return a.Power(b);
                case Operation.Root:
                    if (b.Imaginary == 0)
                        return a.Root((int)b.Real);
                    else
                        return a.Root(b);
            }


            return result;
        }
    }
}
