using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Summing sum = new Summing();
            sum.add(1, 2);
            int total = sum.GetTotal();
            Console.WriteLine(total);
        }
    }

    public class Summing : ICalculate
    {
        private int _total;

        public void add(int first, int second)
        {
            _total = first + second;
        }

        public int GetTotal()
        {
            return _total;
        }
    }
}
