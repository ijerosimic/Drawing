using DrawingApp.Widgets.Shapes;
using System;
using Xunit;

namespace DrawingTests
{
    public class TextBoxShould
    {
        [Theory]
        [InlineData(1, 1, -1, 1, "")]
        [InlineData(1, 1, 1, -1, " ")]
        [InlineData(1, 1, -1, -1, "HEY")]
        public void ThrowExceptionIfWidthOrHeightInvalid(
         int X, int Y, int width, int height, string text)
        {
            Assert.Throws<ArgumentException>(() =>
                new TextBox(X, Y, width, height, text));
        }

        [Theory]
        [InlineData(1, 1, 1, 6, "")]
        [InlineData(1, 5, 3, 9, " ")]
        [InlineData(2, 5, 6, 4, "HEY")]
        public void ReturnAStringWithFieldInformation(
            int X, int Y, int width, int height, string text)
        {
            var sut = new TextBox(X, Y, width, height, text);

            var res = sut.Display();

            var expected = $"{nameof(TextBox)} ({X},{Y}), width={width} height={height} text={text}";

            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData(1, 1, 1, 6, null)]
        public void NotReturnTextFieldIfTextIsNull(
           int X, int Y, int width, int height, string text)
        {
            var sut = new TextBox(X, Y, width, height, text);

            var res = sut.Display();

            var expected = $"{nameof(TextBox)} ({X},{Y}), width={width} height={height}";

            Assert.Equal(expected, res);
        }
    }
}
