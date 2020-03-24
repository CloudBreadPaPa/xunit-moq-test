using System;

namespace multLib
{
    public interface IMultInterface
    {
        public int Mult(int first, int second);
    }

    public class multLibc : IMultInterface
    {

        public int Mult(int a, int b)
        {
            return a * b;
        }

    }
}
