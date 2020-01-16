namespace DrawingApp.Widgets.Shapes
{
    public class Ellipse : WidgetWithDiameter
    {
        public Ellipse(
            int x,
            int y,
            int diameterH,
            int diameterV)
            : base(x, y, diameterH, diameterV)
        {
        }

        public override string Display()
        {
            return $"{nameof(Ellipse)} ({_x},{_y}), diameterH={_diameterH} diameterV={_diameterV}";
        }
    }
}
