using System.Linq;

namespace TestProject
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        //public int Add2(int a, int b) {
        //    var unused = 1;
        //    return a + b;
        //}

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