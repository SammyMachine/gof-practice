namespace GOF.singleton.example
{
    public class Operation
    {
        public static double Run(char operationCode, int operand)
        {
            Log lg2 = Log.MyLog;
            double rez = 0;
            switch (operationCode)
            {
                case '+':
                    rez += operand;

                    lg2.LogExecution("Сложение " + operand);

                    break;

                case '-':
                    rez -= operand;
                    lg2.LogExecution("Вычитание " + operand);
                    break;

                case '*':
                    rez *= operand;
                    break;

                case '/':
                case ':':
                    rez /= operand;
                    break;
            }
            return rez;
        }
    }
}