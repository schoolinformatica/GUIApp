using GUIApp.Adapters;
using GUIApp.Adapters.Colors;
using GUIApp.Adapters.InputAdapters;
using GUIApp.Factories;
using GUIApp.GUI;
using GUIApp.GUI.Elements;
using GUIApp.Visitor;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Color = GUIApp.Adapters.Colors.Color;

namespace GUIApp
{
    public class Game1 : Game
    {
        private readonly GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private IGuiElement _guiManager;
        private IDrawElementVisitor _drawVisitor;
        private IUpdateElementVisitor _updateVisitor;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.IsFullScreen = false;
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.IsMouseVisible = true;
            GuiManager.Window = new NormalGuiElementFactory().CreateMainMenu();
            _guiManager = GuiManager.Window;
            _updateVisitor = new UpdateElementVisitor(new MonogameMouseManager());
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _drawVisitor = new DrawElementVisitor(new MonogameDrawingManager(_spriteBatch, Content));
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            _guiManager.Update(_updateVisitor);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            _guiManager = GuiManager.Window;
            GraphicsDevice.Clear(MonoGameColor.Get(Color.CornflowerBlue));

            _spriteBatch.Begin();
            _guiManager.Draw(_drawVisitor);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}