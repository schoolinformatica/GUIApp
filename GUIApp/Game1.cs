using ConsoleApplication1.GUI;
using ConsoleApplication1.GUI.Elements;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GUIApp
{
    public class Game1 : Game
    {
        private readonly GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private GuiManager _guiManager;
        private IDrawVisitor _drawVisitor;
        private IUpdateVisitor _updateVisitor;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.IsFullScreen = true;
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.IsMouseVisible = true;
            _guiManager = new GuiManager(() => Exit());
            _updateVisitor = new DefaultUpdateVisitor();

        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _drawVisitor = new DefaultDrawVisitor(_spriteBatch, Content);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            _guiManager.Update(_updateVisitor, (float)gameTime.ElapsedGameTime.TotalMilliseconds);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _guiManager.Draw(_drawVisitor);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
