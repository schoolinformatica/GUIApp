using ConsoleApplication1.GUI.Elements;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ConsoleApplication1.GUI
{
    public class DefaultDrawVisitor : IDrawVisitor
    {
        private readonly SpriteBatch _spriteBatch;
        private readonly Texture2D _whitePixel;
        private readonly SpriteFont _defaultFont;
        private ContentManager _contentManager;


        public DefaultDrawVisitor(SpriteBatch spriteBatch, ContentManager contentManager)
        {
            this._spriteBatch = spriteBatch;
            this._contentManager = contentManager;
            _whitePixel = contentManager.Load<Texture2D>("white_pixel");
            _defaultFont = contentManager.Load<SpriteFont>("arial");
        }

        public void DrawButton(Button element)
        {
            var rectangle = new Rectangle(element.TopLeftCorner.X, element.TopLeftCorner.Y, (int) element.Width,
                (int) element.Height);
            
            _spriteBatch.Draw(_whitePixel, rectangle, element.Color);
            DrawLabel(element.Label);
        }

        public void DrawLabel(Label element)
        {
            _spriteBatch.DrawString(_defaultFont, element.Content,
                new Vector2(element.TopLeftCorner.X, element.TopLeftCorner.Y), element.Color);
        }

        public void DrawGui(GuiManager guiManager)
        {
            foreach (var guiElement in guiManager.Elements)
            {
                guiElement.Draw(this);
            }
        }
    }
}