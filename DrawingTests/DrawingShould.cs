using DrawingApp;
using DrawingApp.Widgets;
using DrawingApp.Widgets.Shapes;
using System.Collections.Generic;
using Xunit;

namespace DrawingTests
{
    public class DrawingShould
    {
        [Fact]
        public void AddWidgets()
        {
            var sut = new Drawing();

            sut.Add(new Rectangle(10, 10, 30, 40));
            sut.Add(new Square(15, 30, 35));
            sut.Add(new Ellipse(100, 150, 300, 200));
            sut.Add(new Circle(1, 1, 300));
            sut.Add(new TextBox(5, 5, 200, 100, "sample text"));

            var res = sut.GetWidgets();

            Assert.Equal(5, res.Count);
        }

        [Fact]
        public void ReturnAListOfWidgets()
        {
            var sut = new Drawing();

            sut.Add(new Rectangle(10, 10, 30, 40));

            var res = sut.GetWidgets();

            Assert.IsType<List<Widget>>(res);
        }
    }
}
