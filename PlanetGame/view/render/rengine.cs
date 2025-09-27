using Render.Objects;
using Render.Cameras;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Render.Engine
{
    public class RenderEngine
    {
        private List<Sprite> sprites = new List<Sprite>();
        public void SortSpritesByLayer()
        {
            sprites.Sort((a, b) => a.layer.CompareTo(b.layer));
        }
        public void AddSprite(Sprite sprite)
        {
            sprites.Add(sprite);
            SortSpritesByLayer();
        }
        public void Render(SpriteBatch spriteBatch, Camera camera)
        {
            spriteBatch.Begin();
            foreach (Sprite sprite in sprites)
            {
                // if (sprite == null) continue;
                // spriteBatch.Draw(sprite.texture, new Vector2(50, 50), Color.White);
                sprite.Draw(spriteBatch, camera.Position);
            }
            spriteBatch.End();
        }
    }
}