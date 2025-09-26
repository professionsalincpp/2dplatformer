using System.Collections.Generic;
using Microsoft.Xna.Framework;


namespace Physics.Objects
{
    public interface IPhysicsObject
    {
        public Vector2 Position { get; set; }
        public Rectangle BoundingBox { get; set; }
        public float Mass { get; set; }
        public List<IPhysicsObject> Children { get; set; }
    }

    public class StaticPhysicsObject : IPhysicsObject
    {
        public Vector2 Position { get; set; }
        public Rectangle BoundingBox { get; set; }
        public float Mass { get; set; }
        public List<IPhysicsObject> Children { get; set; }
        public StaticPhysicsObject() => Children = new List<IPhysicsObject>();
    }
    public class DynamicPhysicsObject : IPhysicsObject
    {
        public Vector2 Velocity { get; set; }
        public Vector2 Acceleration { get; set; }
        public Vector2 Position { get; set; }
        public Rectangle BoundingBox { get; set; }
        public float Mass { get; set; }
        public List<IPhysicsObject> Children { get; set; }

        public DynamicPhysicsObject() => Children = new List<IPhysicsObject>();
        public Vector2 ApplyImpulse(Vector2 impulse)
        {
            Velocity += impulse / Mass;
            return Velocity;
        }
        public Vector2 ApplyForce(Vector2 force)
        {
            Acceleration += force / Mass;
            return Acceleration;
        }
        public void Update(float dt)
        {
            Velocity += Acceleration * dt;
            Position += Velocity * dt;
            Acceleration = Vector2.Zero;
        }
    }
     
}