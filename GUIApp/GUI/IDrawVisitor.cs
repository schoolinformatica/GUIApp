using ConsoleApplication1.GUI.Elements;

namespace ConsoleApplication1.GUI
{
    public interface IDrawVisitor
    {
        void DrawButton(Button element);
        void DrawLabel(Label element);
        void DrawGui(GuiManager element);
    }
}