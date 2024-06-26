﻿using System.Numerics;

namespace SoftwareRenderer3D.DataStructures.VertexDataStructures
{
    public class StandardVertex : IVertex
    {
        private Vector3 _position;

        public StandardVertex(Vector3 position)
        {
            _position = position;
        }

        public StandardVertex(float x, float y, float z)
        {
            _position = new Vector3(x, y, z);
        }
        public Vector3 GetVertexPoint()
        {
            return _position;
        }

        public Vector3 Position => _position;
    }
}
