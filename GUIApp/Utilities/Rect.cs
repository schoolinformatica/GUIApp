using GUIApp.Adapters.Colors;
using Point = ConsoleApplication1.Utilities.Point;

namespace GUIApp.Utilities
{
    public class Rect
    {
        public Point Position { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Color color { get; private set; }
        
        public Rect(Point position, int width, int height, Color color)
        {
            Position = position;
            Width = width;
            Height = height;
            this.color = color;
        }
    }
}