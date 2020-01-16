using System;

namespace DrawingApp.Widgets
{
    public abstract class Widget
    {
        protected int _x;
        protected int _y;

        public Widget(
            int x,
            int y)
        {
            _x = x;
            _y = y;
        }

        public abstract string Display();
    }
}
