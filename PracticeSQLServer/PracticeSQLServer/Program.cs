using System;
namespace PracticeSQLServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var dostuff = new DatabaseActions();
            double a = 0;
            while (a != -1)
            {                
                using (var db = new BloggingContext())
                {
                    Console.WriteLine("Input the nummber associated with your choice");
                    Console.WriteLine("1 - View all blogs");
                    Console.WriteLine("2 - View a specific blog and its contents");
                    Console.WriteLine("3 - Add a new blog");
                    Console.WriteLine("4 - Add content to a blog");
                    Console.WriteLine("5 - Exit");
                    a = char.GetNumericValue(Console.ReadKey(true).KeyChar);
                    a = dostuff.MenuHandler(a, db);
                    for (int i = 0; i < 3; i++)
                        Console.WriteLine();
                }
            }
        }
    }
}
