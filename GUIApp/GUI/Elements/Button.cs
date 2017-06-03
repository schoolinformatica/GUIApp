using System;
using Microsoft.Xna.Framework;

namespace ConsoleApplication1.GUI.Elements
{
    public class Button : IGuiElement
    {
        public float Width, Height;
        public Action Action;
        public Color Color;
        public Label Label;
        public Point TopLeftCorner;
        public Button(string text, Point topLeftCorner, int size, Color color, float width, float height, Action action) 
        {
            Action = action;
            Width = width;
            Height = height;
            Color = color;
            TopLeftCorner = topLeftCorner;
            Label = new Label(text, topLeftCorner, size, Color.White);
        }
        public void Draw(IDrawVisitor visitor)
        {
            visitor.DrawButton(this);
        }
        public bool is_intersecting(Point point)
        {
            return point.X > TopLeftCorner.X && point.Y > TopLeftCorner.Y &&
                   point.X < TopLeftCorner.X + Width && point.Y < TopLeftCorner.Y + Height;
        }
        
        public void Update(IUpdateVisitor visitor, float dt)
        {
            visitor.UpdateButton(this, dt);
        }

    }
}