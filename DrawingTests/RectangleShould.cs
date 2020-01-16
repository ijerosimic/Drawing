using DrawingApp.Widgets.Shapes;
using System;
using Xunit;

namespace DrawingTests
{
    public class RectangleShould
    {
        [Theory]
        [InlineData(1, 1, -1, 1)]
        [InlineData(1, 1, 1, -1)]
        [InlineData(1, 1, -1, -1)]
        public void ThrowExceptionIfWidthOrHeightInvalid(
          int X, int Y, int width, int height)
        {
            Assert.Throws<ArgumentException>(() =>
                new Rectangle(X, Y, width, height));
        }

        [Theory]
        [InlineData(1, 1, 1, 6)]
        [InlineData(1, 5, 3, 9)]
        [InlineData(2, 5, 6, 4)]
        public void ReturnAStringWithFieldInformation(
            int X, int Y, int width, int height)
        {
            var sut = new Rectangle(X, Y, width, height);

            var res = sut.Display();

            var expected = $"{nameof(Rectangle)} ({X},{Y}), width={width} height={height}";

            Assert.Equal(expected, res);
        }
    }
}
