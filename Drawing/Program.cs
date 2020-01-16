using DrawingApp.Widgets.Shapes;
using System;

namespace DrawingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var drawing = new Drawing();

            drawing.Add(new Rectangle(10, 10, 30, 40));
            drawing.Add(new Square(-1, 30, 35));
            drawing.Add(new Ellipse(100, 150, 1, 200));
            drawing.Add(new Circle(1, 1, 300));
            drawing.Add(new TextBox(5, 5, 200, 100, "sample text"));

            Print(drawing);
        }

        static void Print(Drawing drawing)
        {
            var widgets = drawing.GetWidgets();

            Console.WriteLine("----------------------");
            Console.WriteLine("Requested drawing");
            Console.WriteLine("----------------------");

            foreach (var w in widgets)
                Console.WriteLine(w.Display());
        }
    }
}
