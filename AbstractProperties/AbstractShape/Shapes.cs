// abstractshape.cs
// compile with: /target:library
// csc /target:library abstractshape.cs
using System;

//namespace AbstractShape
//{

    public abstract class Shape
    {
        private string myId;

        public Shape(string s)
        {
            Id = s;   // calling the set accessor of the Id property
        }

        public string Id
        {
            get
            {
                return myId;
            }

            set
            {
                myId = value;
            }
        }

        // Area is a read-only property - only a get accessor is needed:
        public abstract double Area
        {
            get;
        }

        public abstract double PathLength
        {
            get;
        }

        public override string ToString()
        {
            return Id + " Area = " + string.Format("{0:F1}", Area) + ", Path Length = " + string.Format("{0:F1}", PathLength);
        }
    }

    // shapes.cs
    // compile with: /target:library /reference:abstractshape.dll
    public class Square : Shape
    {
        private int mySide;

        public Square(int side, string id)
            : base(id)
        {
            mySide = side;
        }

        public override double Area
        {
            get
            {
                // Given the side, return the area of a square:
                return mySide * mySide;
            }
        }

        public override double PathLength
        {
            get
            {
                //A square has four equal length sides
                return 4 * mySide;
            }
        }
    }

    public class Circle : Shape
    {
        private int myRadius;

        public Circle(int radius, string id)
            : base(id)
        {
            myRadius = radius;
        }

        public override double Area
        {
            get
            {
                // Given the radius, return the area of a circle:
                return myRadius * myRadius * System.Math.PI;
            }
        }

        public override double PathLength
        {
            get
            {
                //Given the radius, return the circumference of a circle:
                return 2 * System.Math.PI * myRadius;
            }
        }
    }

    public class Rectangle : Shape
    {
        private int myWidth;
        private int myHeight;

        public Rectangle(int width, int height, string id)
            : base(id)
        {
            myWidth = width;
            myHeight = height;
        }

        public override double Area
        {
            get
            {
                // Given the width and height, return the area of a rectangle:
                return myWidth * myHeight;
            }
        }

        public override double PathLength
        {
            get
            {
                //Return the path length of a rectangle
                return 2 * myWidth + 2 * myHeight;
            }
        }
    }
//}