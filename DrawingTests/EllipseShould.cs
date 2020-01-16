using DrawingApp.Widgets.Shapes;
using System;
using Xunit;

namespace DrawingTests
{
    public class EllipseShould
    {
        [Theory]
        [InlineData(1, 1, -1, 1)]
        [InlineData(1, 1, 1, -1)]
        [InlineData(1, 1, -1, -1)]
        public void ThrowExceptionIfDiameterInvalid(
            int X, int Y, int diameterH, int diamaterV)
        {
            Assert.Throws<ArgumentException>(() =>
                new Ellipse(X, Y, diameterH, diamaterV));
        }

        [Theory]
        [InlineData(1, 1, 1, 6)]
        [InlineData(1, 5, 3, 9)]
        [InlineData(2, 5, 6, 4)]
        public void ReturnAStringWithFieldInformation(
            int X, int Y, int diameterH, int diamaterV)
        {
            var sut = new Ellipse(X, Y, diameterH, diamaterV);

            var res = sut.Display();

            var expected = $"{nameof(Ellipse)} ({X},{Y}), diameterH={diameterH} diameterV={diamaterV}";

            Assert.Equal(expected, res);
        }
    }
}
