using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game_Project_0
{
    public class imageEntity
    {
        Random random;

        /// <summary>
        /// The game this ball is a part of
        /// </summary>
        Game game;

        /// <summary>
        /// A color to help distinguish one ball from another
        /// </summary>
        Color color;

        /// <summary>
        /// The texture to apply to a ball
        /// </summary>
        Texture2D texture;

        /// <summary>
        /// The position of the ball in the game world
        /// </summary>
        public Vector2 Position { get; set; }

        string textureName;

        /// <summary>
        /// Constructs a new ball instance
        /// </summary>
        /// <param name="game">The game this ball belongs in</param>
        /// <param name="color">A color to distinguish this ball</param>
        public imageEntity(Game game, Color color, string Name)
        {
            this.game = game;
            this.color = color;
            this.random = new Random();
            textureName = Name;
        }

        // Helper for reading input from keyboard, gamepad, and touch input. This class 
        // tracks both the current and previous state of the input devices, and implements 
        // query methods for high level input actions such as "move up through the menu"
        // or "pause the game".


        /// <summary>
        /// Loads the ball's texture
        /// </summary>
        public void LoadContent()
        {
            texture = game.Content.Load<Texture2D>(textureName);
        }

        public void Update(int gametick)
        {
            //if(gametick > 500)
        }

        /// <summary>
        /// Draws the ball at its current position and with 
        /// its assigned color
        /// </summary>
        /// <param name="spriteBatch">The SpriteBatch to render with</param>
        public void Draw(SpriteBatch spriteBatch, int gametick)
        {
            if (texture is null) throw new InvalidOperationException("Texture must be loaded to render");

            if (textureName == "bacon")
            {
                if (gametick < 250)
                {
                    spriteBatch.Draw(texture, new Rectangle(0, 20, 200, 200), null, Color.White, 0, new Vector2(0, 0), SpriteEffects.None, 0f);
                }
                else
                {
                    spriteBatch.Draw(texture, new Rectangle(0, 20, 200, 200), null, Color.White, 0, new Vector2(0, 0), SpriteEffects.FlipHorizontally, 0f);
                }
                

                
            }
            else
            {
                spriteBatch.Draw(texture, Position, color);
            }
            
        }

    }
}
