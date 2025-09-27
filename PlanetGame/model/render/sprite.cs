using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Render.Objects
{
    public class Sprite
    {
        public Texture2D texture;
        public Vector2 position;
        public int layer = 0;

        public Sprite(Texture2D texture, Vector2 position, int layer = 0)
        {
            this.texture = texture;
            this.position = position;
            this.layer = layer;
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 offset = default)
        {
            
            spriteBatch.Draw(texture, position + offset, Color.White);
        }
    }


}