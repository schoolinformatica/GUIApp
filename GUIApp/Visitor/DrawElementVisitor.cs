using GUIApp.Adapters;
using GUIApp.Adapters.DrawingAdapters;
using GUIApp.GUI.Elements;
using GUIApp.Utilities;
using Microsoft.Xna.Framework;

namespace GUIApp.Visitor
{
    public class DrawElementVisitor : IDrawElementVisitor
    {
        private readonly IDrawAdapter _drawAdapter;
        
        public DrawElementVisitor(IDrawAdapter drawAdapter)
        {
            _drawAdapter = drawAdapter;
        }

        public void OnLabel(Label label)
        {
            _drawAdapter.DrawLabel(label);
        }

        public void OnRectangle(Rect rectangle)
        {
            _drawAdapter.DrawRectangle(rectangle);
        }

        public void OnGuiManager(GuiGrouping guiManager)
        {
            foreach (var element in guiManager.Elements)
            {
                element.Visit(() => { }, x => x.Draw(this));
            }
        }
    }
}