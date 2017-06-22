using GUIApp.Adapters.Colors;
using GUIApp.Adapters.DrawingAdapters;
using GUIApp.Decorators;
using GUIApp.GUI.Elements;
using GUIApp.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Color = Microsoft.Xna.Framework.Color;

namespace GUIApp.Adapters
{
    public class MonogameDrawingManager : IDrawAdapter
    {
        private readonly SpriteBatch _spriteBatch;
        private readonly Texture2D _whitePixel;
        private readonly SpriteFont _defaultFont;
        private ContentManager _contentManager;

        public MonogameDrawingManager(SpriteBatch spriteBatch, ContentManager contentManager)
        {
            _spriteBatch = spriteBatch;
            _contentManager = contentManager;
            _whitePixel = contentManager.Load<Texture2D>("white_pixel");
            _defaultFont = contentManager.Load<SpriteFont>("arial");
        }

        public void DrawRectangle(Rect rectangle)
        {
            var monoGameRectangle = new Rectangle((int)rectangle.Position.X, (int)rectangle.Position.Y, rectangle.Width,
                rectangle.Height);
            
            _spriteBatch.Draw(_whitePixel, monoGameRectangle, MonoGameColor.Get(rectangle.color));
        }

        public void DrawLabel(Label label)
        {
            _spriteBatch.DrawString(_defaultFont, label.Content,
                new Vector2(label.TopLeftCorner.X, label.TopLeftCorner.Y), MonoGameColor.Get(label.Color));
        }
    }
}