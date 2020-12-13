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
        public static List<MatOperation> Operations { get; private set; }
        public static List<VectorOperation> VectorOperations { get; private set; }
        public static List<AritmeticType> Types { get; private set; }

        public static BaseMathEntity CopiedEntity { get; set; }

        static AritmeticsService()
        {
            Operations = new List<MatOperation>();
            foreach (var enumValue in Enum.GetValues(typeof(Operation)))
            {
                Operations.Add(new MatOperation((Operation)enumValue));
            }

            VectorOperations = new List<VectorOperation>();
            foreach (var enumValue in Enum.GetValues(typeof(VectorOperationEnum)))
            {
                VectorOperations.Add(new VectorOperation((VectorOperationEnum)enumValue));
            }

            Types = new List<AritmeticType>();
            foreach(var enumType in Enum.GetValues(typeof(AritmeticTypeEnum)))
            {
                Types.Add(new AritmeticType((AritmeticTypeEnum)enumType));
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

        public static BaseMathEntity CalculateVector(VectorOperation operation, BaseMathEntity a, BaseMathEntity b)
        {
            switch(operation.Operation)
            {
                case VectorOperationEnum.Add:
                    return a.Add(b);
                case VectorOperationEnum.Subtract:
                    return a.Subtract(b);
                case VectorOperationEnum.Multiply:
                    return a.Multiply(b);
                case VectorOperationEnum.MatrixMupltiply:
                    return a.MatrixMultiply(b);
            }

            return null;
        }
    }
}
