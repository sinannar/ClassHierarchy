using System;
using System.Collections.Generic;
using System.Text;

namespace ClassHierarchy
{
    class Square : Rectangle
    {
        public Square(int size) : base(size, size)
        {
        }

        public override int Width
        {
            get { return base.Width; }
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override int Height
        {
            get { return base.Height; }
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
    }

    public class Test
    {
        public void foo()
        {
            Rectangle rectangle = new Square(1);
            rectangle.Width = 10;
            rectangle.Height = 5;

            Console.WriteLine(rectangle.Area);//This code will output 25.
        }
    }
}
