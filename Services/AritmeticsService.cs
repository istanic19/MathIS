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

        public static BaseMathEntity CopiedEntity { get; private set; }

        public static List<Tuple<BaseMathEntity,BaseMathEntity,BaseMathEntity>> State { get; set; }

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

            State = new List<Tuple<BaseMathEntity, BaseMathEntity, BaseMathEntity>>();
        }

        public static void CopyEntity(BaseMathEntity entity)
        {
            if (entity == null)
                return;
            CopiedEntity = entity.Clone();
        }

        public static void AddState(BaseMathEntity item1, BaseMathEntity item2, BaseMathEntity item3)
        {
            while(State.Count>=10)
            {
                State.RemoveAt(State.Count - 1);
            }

            if (State.Count == 0)
                State.Add(new Tuple<BaseMathEntity, BaseMathEntity, BaseMathEntity>(item1, item2, item3));
            else
                State.Insert(0, new Tuple<BaseMathEntity, BaseMathEntity, BaseMathEntity>(item1, item2, item3));
        }

        public static Tuple<BaseMathEntity, BaseMathEntity, BaseMathEntity> RestoreLastState()
        {
            if (State.Count > 0)
            {
                State.RemoveAt(0);
                if (State.Any())
                    return State.First();
            }

            return null;
        }

        public static Number Calculate(MatOperation operation, Number a, Number b)
        {
            Number result = null;

            switch (operation.Operation)
            {
                case Operation.Add:
                    return (Number)Round((a + b));
                case Operation.Subtract:
                    return (Number)Round((a - b));
                case Operation.Multiply:
                    return (Number)Round((a * b));
                case Operation.Divide:
                    return (Number)Round((a / b));
                case Operation.Power:
                    if (b.Imaginary == 0)
                        return (Number)Round(a.Power((int)b.Real));
                    else
                        return (Number)Round(a.Power(b));
                case Operation.Root:
                    if (b.Imaginary == 0)
                        return (Number)Round(a.Root((int)b.Real));
                    else
                        return (Number)Round(a.Root(b));
            }


            return result;
        }

        public static BaseMathEntity CalculateVector(VectorOperation operation, BaseMathEntity a, BaseMathEntity b)
        {
            switch(operation.Operation)
            {
                case VectorOperationEnum.Add:
                    return Round(a.Add(b));
                case VectorOperationEnum.Subtract:
                    return Round(a.Subtract(b));
                case VectorOperationEnum.Multiply:
                    return Round(a.Multiply(b));
                case VectorOperationEnum.MatrixMupltiply:
                    return Round(a.MatrixMultiply(b));
            }

            return null;
        }

        public static BaseMathEntity Conjugate(BaseMathEntity a)
        {
            return Round(a.Conjugate());
        }

        public static BaseMathEntity Normalize(BaseMathEntity a)
        {
            return Round(a.Normalize());
        }

        public static BaseMathEntity Round(BaseMathEntity input)
        {
            if (AppSettings.PrecisionDecimals < 0)
                return input;
            input.Round((uint)AppSettings.PrecisionDecimals);
            return input;
        }
    }
}
