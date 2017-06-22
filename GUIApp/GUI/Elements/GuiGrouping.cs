using GUIApp.Factories;
using GUIApp.Iterator;
using GUIApp.Visitor;

namespace GUIApp.GUI.Elements
{
    public class GuiGrouping : IGuiElement
    {
        public OptionList<IGuiElement> Elements;
        
        public GuiGrouping(OptionList<IGuiElement> elements)
        {
            Elements = elements;
        }

        public void Draw(IDrawElementVisitor visitor)
        {
            visitor.OnGuiManager(this);
        }
    
        public void Update(IUpdateElementVisitor visitor)
        {
            visitor.OnGuiManager(this);
        }
    }
}