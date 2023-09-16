using System.Linq;

namespace TestProject
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            string token = "d165955f-53b9-4f29-b4cb-2141ebe7b62b";
            return token == null ? 0 : a + b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int MultiplyBy(int a, int b)
        {
            return a * b;
        }
    }
}
