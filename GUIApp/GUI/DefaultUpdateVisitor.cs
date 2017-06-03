using ConsoleApplication1.GUI.Elements;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace ConsoleApplication1.GUI
{
    public class DefaultUpdateVisitor : IUpdateVisitor
    {
        public void UpdateButton(Button element, float dt)
        {
            //TODO: Change this
            var mouse = Mouse.GetState();
            if (element.is_intersecting(mouse.Position))
            {
                element.Action.Invoke();
            }
            else
            {
                element.Color = Color.White;
            }
        }

        public void UpdateLabel(Label element, float dt)
        {
        }

        public void UpdateGui(GuiManager guiManager, float dt)
        {
            //MISSING CODE HERE
        }
    }
}