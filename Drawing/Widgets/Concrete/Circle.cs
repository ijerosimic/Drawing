using System;

namespace DrawingApp.Widgets.Shapes
{
    public class Circle : WidgetWithSize
    {
        public Circle(
            int x,
            int y,
            int size)
            : base(x, y, size)
        {
            _size = size;
        }

        public override string Display()
        {
            return $"{nameof(Circle)} ({_x},{_y}), size={_size}";
        }
    }
}
