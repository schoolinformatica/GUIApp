using Microsoft.Xna.Framework;

namespace ConsoleApplication1.GUI.Elements
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

        public void Draw(IDrawVisitor visitor)
        {
            //MISSING CODE HERE;
            visitor.DrawLabel(this);
        }

        public void Update(IUpdateVisitor visitor, float dt)
        {
            visitor.UpdateLabel(this, dt);
        }
    }
}