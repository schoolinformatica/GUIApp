using System;
using GUIApp.GUI;
using GUIApp.Utilities;
using GUIApp.Visitor;
using Microsoft.Xna.Framework;
using Color = GUIApp.Adapters.Colors.Color;
using Point = ConsoleApplication1.Utilities.Point;

namespace GUIApp.Decorators
{
    public class ClickableDecorator : GuiElementDecorator
    {
        private readonly int _width;
        private readonly int _height;
        private readonly Point _position;
        public Action OnClickAction;

        public ClickableDecorator(IGuiElement guiElement, Point position, int width, int heigth,
            Action onClickAction) : base(
            guiElement)
        {
            _width = width;
            _height = heigth;
            _position = position;

            OnClickAction = onClickAction;
        }

        public override void Draw(IDrawElementVisitor visitor)
        {
            var rectangle = new Rectangle((int) _position.X, (int) _position.Y, _width, _height);
            
            visitor.OnRectangle(new Rect(_position, _width, _height, Color.White));
            base.Draw(visitor);
        }

        public override void Update(IUpdateElementVisitor visitor)
        {
            base.Update(visitor);
            visitor.OnClickable(this);
        }

        public bool IsIntersecting(Point point)
        {
            return point.X > _position.X && point.Y > _position.Y &&
                   point.X < _position.X + _width && point.Y < _position.Y + _height;
        }
    }
}