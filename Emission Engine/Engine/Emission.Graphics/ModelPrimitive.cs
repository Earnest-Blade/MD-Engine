﻿using Emission.Graphics.Shading;
using System.Collections.Generic;

using Emission.Mathematics;

namespace Emission.Graphics
{
    public static class ModelPrimitive
    {
        public static Model PrimitivePlane(float width, float height) => PrimitivePlane(Transform.Zero, width, height);
        public static Model PrimitivePlane(Transform transform, float width, float height)
        {
            return new Model(transform, new Mesh(
                new List<Vertex>
                {
                    new Vertex(new Vector3(-width/2, 0, height/2), Vector3.UnitY, (0, 1)),
                    new Vertex(new Vector3(-width/2, 0, -height/2), Vector3.UnitY, (0, 0)),
                    new Vertex(new Vector3(width/2, 0, -height/2), Vector3.UnitY, (1, 1)),
                    new Vertex(new Vector3(width/2, 0, height/2), Vector3.UnitY, (1, 0)),
                },
                new List<uint>
                {
                    0, 1, 2,
                    0, 2, 3
                },
                new List<Texture>()
            ));
        }

        public static Model SpherePrimitive()
        {
            return null;
        }

    }
}
