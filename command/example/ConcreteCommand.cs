namespace GOF.command.example
{
    internal class ConcreteCommand
    {
        public class Add : Command
        {
            public Add(ArithmeticUnit unit, double operand)
            {
                this.unit = unit;
                this.operand = operand;
            }

            public override void Execute()
            {
                unit.Run('+', operand);
            }

            public override void UnExecute()

            {
                unit.Run('-', operand);
            }
        }

        public class Sub : Command
        {
            public Sub(ArithmeticUnit unit, double operand)
            {
                this.unit = unit;
                this.operand = operand;
            }

            public override void Execute()
            {
                unit.Run('-', operand);
            }

            public override void UnExecute()
            {
                unit.Run('+', operand);
            }
        }

        public class Mul : Command
        {
            public Mul(ArithmeticUnit unit, double operand)
            {
                this.unit = unit;
                this.operand = operand;
            }

            public override void Execute()
            {
                unit.Run('*', operand);
            }

            public override void UnExecute()
            {
                unit.Run('/', operand);
            }
        }

        public class Div : Command
        {
            public Div(ArithmeticUnit unit, double operand)
            {
                this.unit = unit;
                this.operand = operand;
            }

            public override void Execute()
            {
                unit.Run('/', operand);
            }

            public override void UnExecute()
            {
                unit.Run('*', operand);
            }
        }
    }
}