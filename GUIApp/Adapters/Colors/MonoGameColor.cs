using System;
using System.Dynamic;

namespace GUIApp.Adapters.Colors
{
    public static class MonoGameColor
    {
        public static Microsoft.Xna.Framework.Color Get(Color color)
        {
            switch (color)
            {
                case Color.Black:
                    return Microsoft.Xna.Framework.Color.Black;
                case Color.White:
                    return Microsoft.Xna.Framework.Color.White;
                case Color.CornflowerBlue:
                    return Microsoft.Xna.Framework.Color.CornflowerBlue;
                default:
                    throw new Exception("Color not supported in MonoGame");
            }
        }
    }
}