using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game_Project_0
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private imageEntity bacon;
        private imageEntity ghost;
        private imageEntity sword;
        private imageEntity us;

        public int gametick;

        SpriteFont spriteFont;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            bacon = new imageEntity(this, Color.White, "bacon") { Position = new Vector2(0, 20) };
            ghost = new imageEntity(this, Color.White, "ghost") { Position = new Vector2(400, 100) };
            sword = new imageEntity(this, Color.White, "sword") { Position = new Vector2(100, 300) };
            us = new imageEntity(this, Color.White, "us") { Position = new Vector2(200, 20) };

            gametick = 0;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            bacon.LoadContent();
            ghost.LoadContent();
            sword.LoadContent();
            us.LoadContent();

            // TODO: use this.Content to load your game content here
            spriteFont = Content.Load<SpriteFont>("Font1");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);

            gametick++;

            if (gametick > 500) gametick = 0;
            bacon.Update(gametick);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            bacon.Draw(_spriteBatch, gametick);
            ghost.Draw(_spriteBatch, gametick);
            sword.Draw(_spriteBatch, gametick);
            us.Draw(_spriteBatch, gametick);
            _spriteBatch.DrawString(spriteFont, "Press Escape To Get Out Of Here!", new Vector2(300, 300), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
