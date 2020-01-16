using System;

namespace DrawingApp.Widgets
{
    public abstract class WidgetWithDiameter : Widget
    {
        protected int _diameterH;
        protected int _diameterV;

        public WidgetWithDiameter(
            int x,
            int y,
            int diameterH,
            int diameterV)
            : base(x, y)
        {
            if (diameterH < 0)
                throw new ArgumentException("Invalid horizontal diameter argument");

            if (diameterV < 0)
                throw new ArgumentException("Invalid vertical diameter argument");

            _diameterH = diameterH;
            _diameterV = diameterV;
        }
    }
}
