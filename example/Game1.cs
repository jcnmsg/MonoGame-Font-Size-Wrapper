using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace FontExample
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private string _exampleText;
        
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _exampleText = "Hello, world!";
        }

        protected override void Initialize()
        {
            Window.AllowUserResizing = true;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            Font.Initialize(_spriteBatch, Content);

            Font.LoadSizes("Arial", new int[] { 12, 16, 24, 32, 48, 72 });
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            List<Font> fonts = Font.GetAvailableSizes("Arial");

            for (int i = 0; i < fonts.Count; i++)
            {
                Font font = fonts[i];
                Vector2 measuredString = Font.MeasureString(font, _exampleText);

                Font.DrawString(font.FontName, font.Size, $"{_exampleText} {measuredString.X},{measuredString.Y}", new Vector2(8, 72 * i + 8), Color.White);
            }

            // Tries to draw with unexisting by picking the closest available size and scaling accordingly
            //Font.DrawString("Arial", 55, "Hello World!", new Vector2(8, 8), Color.White, true);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
