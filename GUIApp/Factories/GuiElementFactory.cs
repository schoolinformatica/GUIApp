using System;
using GUIApp.GUI;

namespace GUIApp.Factories
{
    public abstract class GuiElementFactory
    {
        public abstract IGuiElement CreateMainMenu();
        public abstract IGuiElement CreateSettingsMenu();
    }
}