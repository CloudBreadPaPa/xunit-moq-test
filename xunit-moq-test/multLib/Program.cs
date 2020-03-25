using System;

namespace MultLib
{
    public interface IMultInterface
    {
        public int Mult(int first, int second);
    }

    public class MultLibc : IMultInterface
    {

        public int Mult(int a, int b)
        {
            return a * b;
        }

    }
}
