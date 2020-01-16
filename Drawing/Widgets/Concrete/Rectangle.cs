using System;

namespace DrawingApp.Widgets.Shapes
{
    public class Rectangle : WidgetWithWidthHeight
    {
        public Rectangle(
            int x,
            int y,
            int width,
            int height)
            : base(x, y, width, height)
        {
        }

        public override string Display()
        {
            return $"{nameof(Rectangle)} ({_x},{_y}), width={_width} height={_height}";
        }
    }
}
