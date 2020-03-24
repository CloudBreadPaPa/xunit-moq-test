using System;
using multLib;

namespace xunit_moq_test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            multLibc MultFunc = new multLibc();
            Console.WriteLine(MultFunc.Mult(1, 2));
        }
    }
}
