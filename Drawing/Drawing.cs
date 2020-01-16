using DrawingApp.Widgets;
using System.Collections.Generic;

namespace DrawingApp
{
    public class Drawing
    {
        List<Widget> _widgets;

        public Drawing()
        {
            _widgets = new List<Widget>();
        }

        public void Add(Widget widget)
        {
            _widgets.Add(widget);
        }

        //I have decided that Print()
        //should only return a list of Widgets
        //to not be dependent on Console
        //and let the user of the class decide
        //how to use the list of widgets
        public List<Widget> GetWidgets()
        {
            return _widgets;
        }
    }
}
