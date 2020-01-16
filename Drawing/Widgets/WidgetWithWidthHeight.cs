using System;

namespace DrawingApp.Widgets
{
    public abstract class WidgetWithWidthHeight : Widget
    {
        protected int _width;
        protected int _height;

        public WidgetWithWidthHeight(
            int X,
            int Y,
            int width,
            int height)
            : base(X, Y)
        {
            if (width < 0)
                throw new ArgumentException("Invalid Width argument");

            if (height < 0)
                throw new ArgumentException("Invalid Height argument");

            _width = width;
            _height = height;
        }
    }
}
