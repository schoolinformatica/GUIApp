using ConsoleApplication1.Utilities;
using GUIApp.Visitor;

namespace GUIApp.Adapters.InputAdapters
{
    public interface IMouseAdapter
    {
        IOption<Point> GetLeftMouseButton();
    }
}