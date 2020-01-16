namespace DrawingApp.Widgets
{
    public abstract class WidgetWithSize : Widget
    {
        protected int _size;

        public WidgetWithSize(
            int x,
            int y,
            int size)
            : base(x, y)
        {
            _size = size;
        }
    }
}
