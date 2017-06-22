using GUIApp.Visitor;

namespace GUIApp.GUI
{
    public interface IUpdateable
    {
        void Update(IUpdateElementVisitor visitor);
    }
}