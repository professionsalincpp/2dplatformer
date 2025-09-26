using System.Collections.Generic;
using Physics.Objects;

namespace Physics.Engine
{
    public class PhysicsEngine
    {
        private List<DynamicPhysicsObject> DynamicObjects { get; set; }
        private List<StaticPhysicsObject> StaticObjects { get; set; }
        public void AddObject(IPhysicsObject obj)
        {
            if (obj is DynamicPhysicsObject dynamicPhysicsObject)
                DynamicObjects.Add(dynamicPhysicsObject);
            else if (obj is StaticPhysicsObject staticPhysicsObject)
                StaticObjects.Add(staticPhysicsObject);
        }
        public void Update(float dt)
        {
            foreach (var obj in DynamicObjects)
                obj.Update(dt);
        }
    }
}