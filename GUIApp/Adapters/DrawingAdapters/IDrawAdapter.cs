using GUIApp.Adapters.Colors;
using GUIApp.GUI.Elements;
using GUIApp.Utilities;

namespace GUIApp.Adapters.DrawingAdapters
{
    public interface IDrawAdapter
    {
//        void DrawButton(Button button);
        void DrawRectangle(Rect rectangle);
        void DrawLabel(Label label);
    }
}