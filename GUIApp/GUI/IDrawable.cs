using GUIApp.Visitor;

namespace GUIApp.GUI
{
    public interface IDrawable
    {
        void Draw(IDrawElementVisitor visitor);
    }
}