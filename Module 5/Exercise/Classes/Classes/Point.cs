#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

#endregion

namespace Classes
{
    class Point
    {
        private int x, y;
        private static int objectCount = 0;

        // Default Constructor
        public Point()
        {
            Console.WriteLine("Default Constructor Called");
            objectCount++;
        }

        // Non-default constructor
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            objectCount++;
        }

        // Print Coordinates
        public void PrintCoords()
        {
            Console.WriteLine("The point coordinates are x:{0}, y: {1}", this.x, this.y);
        }

        public static int ObjectCount()
        {
            return objectCount;
        }
    }
}
