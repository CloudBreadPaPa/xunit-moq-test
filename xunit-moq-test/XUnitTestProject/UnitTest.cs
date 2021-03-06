using System;
using Xunit;
using Moq;
using MultLib;

namespace XUnitTestProject
{
    public class UnitTest
    {
        MultLibc mul = new MultLibc();

        [Fact]
        public void multTest()
        {
            Assert.Equal(2, mul.Mult(1, 2));
        }

        [Fact]
        public void multTest2()
        {
            Assert.Equal(4, mul.Mult(2, 2));
        }

        [Fact]
        public void moqTest()
        {
            var mock = new Mock<IMultInterface>();
            mock.Setup(p => p.Mult(5,5)).Returns(25);
            int val = mock.Object.Mult(5, 5);  // request with same pattern
            int val2 = mock.Object.Mult(1, 1);  // error value
           
            Assert.Equal(25, val);

        }

    }
}
