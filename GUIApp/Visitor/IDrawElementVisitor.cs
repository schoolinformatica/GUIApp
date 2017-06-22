using GUIApp.GUI.Elements;
using GUIApp.Utilities;
using Microsoft.Xna.Framework;

namespace GUIApp.Visitor
{
    public interface IDrawElementVisitor
    {
        void OnLabel(Label label);
        void OnRectangle(Rect rectangle);
        void OnGuiManager(GuiGrouping guiManager);
    }
}