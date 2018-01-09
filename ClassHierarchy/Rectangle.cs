using System;
using System.Collections.Generic;
using System.Text;

namespace ClassHierarchy
{
    class Rectangle
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
        public int Area
        {
            get { return Height * Width; }
        }
    }
}
