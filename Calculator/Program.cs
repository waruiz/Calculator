using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Summing sum = new Summing();
            sum.Calculate(1, 2);
            int total = sum.GetTotal();
            Console.WriteLine(total);

            Subtracting difference = new Subtracting();
            difference.Calculate(7, 5);
            total = difference.GetTotal();
            Console.WriteLine(total);
        }
    }

    public class Summing : ICalculate
    {
        private int _total;

        public void Calculate(int first, int second)
        {
            _total = first + second;
        }

        public int GetTotal()
        {
            return _total;
        }
    }

    public class Subtracting : ICalculate
    {
        private int _total;

        public void Calculate(int first, int second)
        {
            _total = first - second;
        }

        public int GetTotal()
        {
            return _total;
        }
    }
}
