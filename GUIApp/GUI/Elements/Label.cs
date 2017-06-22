using ConsoleApplication1.Utilities;
using GUIApp.Adapters.Colors;
using GUIApp.Visitor;

namespace GUIApp.GUI.Elements
{
    public class Label : IGuiElement
    {
        public string Content;
        public int Size;
        public Color Color;
        public Point TopLeftCorner;
        public Label(string content, Point topLeftCorner, int size, Color color)
        {
            Size = size;
            Color = color;
            Content = content;
            TopLeftCorner = topLeftCorner;

        }

        public void Draw(IDrawElementVisitor visitor)
        {
            visitor.OnLabel(this);
        }

        public void Update(IUpdateElementVisitor visitor)
        {
            visitor.OnLabel(this);
        }
    }
}