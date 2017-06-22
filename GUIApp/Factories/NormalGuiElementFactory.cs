using System;
using GUIApp.Adapters.Colors;
using GUIApp.Decorators;
using GUIApp.GUI;
using GUIApp.GUI.Elements;
using GUIApp.Iterator;
using Point = ConsoleApplication1.Utilities.Point;

namespace GUIApp.Factories
{
    public class NormalGuiElementFactory : GuiElementFactory
    {
        public override IGuiElement CreateMainMenu()
        {
            var elements = new OptionList<IGuiElement>
            {
                new Label("Hi Ahmed!", new Point(0, 0), 10, Color.Black),
                new ClickableDecorator(new Label("Click me", new Point(0, 100), 10, Color.Black), new Point(0, 100),
                    100, 20, () => { GuiManager.Window = CreateSettingsMenu(); })
            };
            return new GuiGrouping(elements);
        }

        public override IGuiElement CreateSettingsMenu()
        {
            var elements = new OptionList<IGuiElement>
            {
                new Label("Hi Piet!", new Point(0, 0), 10, Color.Black),
                new ClickableDecorator(new Label("Click me not", new Point(0, 60), 10, Color.Black), new Point(0, 60),
                    100, 20, () => { GuiManager.Window = CreateMainMenu(); })
            };
            return new GuiGrouping(elements);
        }
    }
}