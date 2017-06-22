using GUIApp.GUI;
using GUIApp.Visitor;

namespace GUIApp.Decorators
{
    public abstract class GuiElementDecorator : IGuiElement
    {
        protected readonly IGuiElement GuiElement;

        protected GuiElementDecorator(IGuiElement guiElement)
        {
            GuiElement = guiElement;
        }

        public virtual void Draw(IDrawElementVisitor visitor)
        {
           GuiElement.Draw(visitor);
        }

        public virtual void Update(IUpdateElementVisitor visitor)
        {
            GuiElement.Update(visitor);
        }
    }
}