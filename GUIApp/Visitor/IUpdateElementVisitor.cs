using GUIApp.Decorators;
using GUIApp.GUI.Elements;

namespace GUIApp.Visitor
{
    public interface IUpdateElementVisitor
    {
        void OnClickable(ClickableDecorator clickableDecorator);
        void OnLabel(Label label);
        void OnGuiManager(GuiGrouping guiManager);
    }
}