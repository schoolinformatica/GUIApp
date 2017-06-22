using ConsoleApplication1.Utilities;
using GUIApp.Visitor;
using Microsoft.Xna.Framework.Input;

namespace GUIApp.Adapters.InputAdapters
{
    public class MonogameMouseManager : IMouseAdapter
    {
        public IOption<Point> GetLeftMouseButton()
        {
            var mouseState = Mouse.GetState();
            
            if(mouseState.LeftButton == ButtonState.Pressed)
                return new Some<Point>(new Point(mouseState.X, mouseState.Y));
            
            return new None<Point>();
        }
    }
}