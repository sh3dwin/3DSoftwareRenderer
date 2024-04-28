﻿using g3;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareRenderer3D.DataStructures
{
    public class Texture
    {
        private Bitmap _texture;

        public Texture(Bitmap texture) { 
            _texture = texture;
        }

        public Color GetTextureColor(float u, float v, bool linearInterpolation = true)
        {
            return linearInterpolation ? GetLinearlyInterpolatedColor(u, v) : GetNearestNeighborColor(u, v);
        }

        private Color GetLinearlyInterpolatedColor(float u, float v)
        {
            throw new NotImplementedException();
        }

        private Color GetNearestNeighborColor(float u, float v)
        {
            throw new NotImplementedException();
        }
    }
}
