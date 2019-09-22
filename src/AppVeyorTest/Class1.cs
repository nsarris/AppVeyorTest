using System;

namespace AppVeyorTest
{
    public class Logic
    {
        public int Add(int x, int y) => x + y;
        public int Subtract(int x, int y) => x - y;
        public double Divide(int x, int y) => (double)x / (double)y;
        public decimal Multiply(int x, int y) => (decimal)x * (decimal)y;
    }
}
