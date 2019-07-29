using System;
using System.IO;

namespace TriangleContainment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[2], b = new int[2], c = new int[2];
            int i = 0;
            int originTriangles = 0, totalTriangles=0;
            string[] bits;
            using (TextReader reader = File.OpenText("p102_triangles.txt"))
            {
                string text = reader.ReadLine();
                do
                {
                    
                    bits = text.Split(',');
                    int[,] coordinates = new int[2, bits.Length / 2];
                    for (int j = 0; j < 2; j++)
                    {
                        a[j] = Convert.ToInt32(bits[i]);
                        i++;
                        b[j] = Convert.ToInt32(bits[i]);
                        i++;
                        c[j] = Convert.ToInt32(bits[i]);
                        i++;
                    }
                    Triangle abc = new Triangle(a, b, c);
                    if (abc.DoesItContainOrigin())
                        originTriangles++;
                    i = 0;
                    totalTriangles++;
                } while ((text = reader.ReadLine())!=null);
            }
            Console.WriteLine("The number of triangles containing origin is {0}, total triangles is {1}", originTriangles, totalTriangles);
        }
    }
}
