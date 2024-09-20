namespace GOF.command.example
{
    internal class ArithmeticUnit
    {
        public double Register { get; private set; }

        public void Run(char operationCode, double operand)
        {
            switch (operationCode)
            {
                case '+':
                    Register += operand;

                    break;

                case '-':
                    Register -= operand;

                    break;

                case '*':
                    Register *= operand;

                    break;

                case '/':
                    Register /= operand;

                    break;
            }
        }
    }
}