using static GOF.command.example.ConcreteCommand;

namespace GOF.command.example
{
    internal class Calculator
    {
        private ArithmeticUnit arithmeticUnit;
        private ControlUnit controlUnit;

        public Calculator()
        {
            arithmeticUnit = new ArithmeticUnit();
            controlUnit = new ControlUnit();
        }

        private double Run(Command command)
        {
            controlUnit.StoreCommand(command);
            controlUnit.ExecuteCommand();
            return arithmeticUnit.Register;
        }

        public double Add(double operand)
        {
            return Run(new Add(arithmeticUnit, operand));
        }

        public double Sub(double operand)
        {
            return Run(new Sub(arithmeticUnit, operand));
        }

        public double Mul(double operand)
        {
            return Run(new Mul(arithmeticUnit, operand));
        }

        public double Div(double operand)
        {
            return Run(new Div(arithmeticUnit, operand));
        }

        public void Undo()
        {
            controlUnit.Undo();
        }

        public void Redo()
        {
            controlUnit.Redo();
        }

        public void Undo(int level)
        {
            controlUnit.Undo(level);
        }

        public void Redo(int level)
        {
            controlUnit.Redo(level);
        }
    }
}