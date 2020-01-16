namespace DrawingApp.Widgets.Shapes
{
    public class Square : WidgetWithSize
    {
        public Square(
            int x, 
            int y, 
            int size) 
            : base(x, y, size)
        {
        }

        public override string Display()
        {
            return $"{nameof(Square)} ({_x},{_y}), size={_size}";
        }
    }
}
