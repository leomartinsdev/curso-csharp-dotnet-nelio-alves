﻿using Secao9.Shapes.Entities.Enums;

namespace Secao9.Shapes.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
