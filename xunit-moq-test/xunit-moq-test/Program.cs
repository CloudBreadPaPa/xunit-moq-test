using System;
using MultLib;

namespace XunitMoqTest
{
    public static class Program
    {
        public static void Main()
        {
            MultLibc MultFunc = new MultLibc();
            Console.WriteLine(MultFunc.Mult(1, 2));
        }
    }
}
