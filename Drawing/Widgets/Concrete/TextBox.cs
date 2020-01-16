namespace DrawingApp.Widgets.Shapes
{
    public class TextBox : WidgetWithText
    {
        public TextBox(
            int x,
            int y,
            int width,
            int height,
            string text)
            : base(x, y, width, height, text)
        {
        }

        public override string Display()
        {
            var text = _text is null
                ? string.Empty
                : $" text={_text}";

            return $"{nameof(TextBox)} ({_x},{_y}), width={_width} height={_height}{text}";
        }
    }
}
