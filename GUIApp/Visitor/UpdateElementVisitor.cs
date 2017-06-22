using System;
using System.Runtime.Serialization.Formatters;
using GUIApp.Adapters.InputAdapters;
using GUIApp.Decorators;
using GUIApp.GUI.Elements;

namespace GUIApp.Visitor
{
    public class UpdateElementVisitor : IUpdateElementVisitor
    {
        private readonly IMouseAdapter _mouseAdapter;

        public UpdateElementVisitor(IMouseAdapter mouseAdapter)
        {
            _mouseAdapter = mouseAdapter;
        }

        public void OnClickable(ClickableDecorator clickableDecorator)
        {
            _mouseAdapter.GetLeftMouseButton().Visit(
                () => { },
                x =>
                {
                    if (clickableDecorator.IsIntersecting(x))
                    {
                        Console.WriteLine("clICKED");
                        clickableDecorator.OnClickAction.Invoke();
                    }
                });
        }

        public void OnLabel(Label label)
        {
            
        }

        public void OnGuiManager(GuiGrouping guiManager)
        {
            foreach (var element in guiManager.Elements)
            {
                element.Visit(() => { }, x => x.Update(this));
            }
        }
    }
}