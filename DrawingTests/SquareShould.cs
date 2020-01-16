using DrawingApp.Widgets.Shapes;
using Xunit;

namespace DrawingTests
{
    public class SquareShould
    {
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(1, 5, 3)]
        [InlineData(2, 5, 1)]
        public void ReturnAStringWithFieldInformation(
            int X, int Y, int size)
        {
            var sut = new Square(X, Y, size);

            var res = sut.Display();

            var expected = $"{nameof(Square)} ({X},{Y}), size={size}";

            Assert.Equal(expected, res);
        }
    }
}
