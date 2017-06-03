using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace ConsoleApplication1.GUI.Elements
{
    public class GuiManager : IGuiElement
    {
        public List<IGuiElement> Elements;
        public GuiManager(System.Action exit)
        {
            Elements = new List<IGuiElement>();
            Elements.Add(new Label("Hi Ahmed!", new Point(0, 0), 10, Color.Black));
            Elements.Add(new Button("Click me", new Point(0, 100), 10, Color.Black, 100, 30,
                () => {
                    Elements = new List<IGuiElement>();
                    Elements.Add(new Button("Exit", new Point(0, 0), 10, Color.Black, 100, 30,
                        () => {
                            exit();
                        }
                    ));
                }
            ));
        }

        public void Draw(IDrawVisitor visitor)
        {
            visitor.DrawGui(this);
        }
    
        public void Update(IUpdateVisitor visitor, float dt)
        {
            //MISSING CODE HERE
        }
    }
}