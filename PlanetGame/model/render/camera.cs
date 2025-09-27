using Microsoft.Xna.Framework;

namespace Render.Cameras
{
    public class Camera
    {
        public Vector2 Position { get; set; }
        public float Zoom { get; set; }
        public Camera(Vector2 position, float zoom)
        {
            Position = position;
            Zoom = zoom;
        }
    }
}