namespace DrawingApp.Widgets
{
    public abstract class WidgetWithText : WidgetWithWidthHeight
    {
        protected string _text;

        public WidgetWithText(
            int x,
            int y, 
            int width,
            int height,
            string text) 
            : base(x, y, width, height)
        {
            _text = text;
        }
    }
}
