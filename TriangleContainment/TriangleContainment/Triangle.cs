using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleContainment
{
    class Triangle
    {
        private int[] x, y, z = new int[2];
        public static int[] o = { 0, 0 };
        public Triangle(int[] a, int[] b, int[] c)
        {
            x = a;
            y = b;
            z = c;
        }
        public bool DoesItContainOrigin()
        {
            if (Area(x, y, z) == Area(x, y, o) + Area(x, o, z) + Area(o, y, z))
                return true;
            return false;
        }
        private int Area(int[] a, int[] b, int[] c)
        {
            return Math.Abs((a[0] - c[0]) * (b[1] - a[1]) - (a[0] - b[0]) * (c[1] - a[1]));
        }
        

    }
}
