using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeSQLServer
{
    class DatabaseActions
    {
        public double MenuHandler (double selection, BloggingContext db)
        {
            switch (selection)
            {
                case 1:
                    return DisplayBlogs(db);
                case 2:
                    return 0;
                case 3:
                    return 0;
                case 4:
                    return 0;
            }
            return -1;
        }
        public double DisplayBlogs (BloggingContext db)
        {
            int count = 0;
            foreach (var blog in db.Blogs)
            {
                count++;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0} records saved to database", count);
            Console.WriteLine();
            Console.WriteLine("All blogs in database:");
            foreach (var blog in db.Blogs)
            {
                Console.WriteLine(" - {0}", blog.Url);                
            }
            Console.WriteLine();
            Console.WriteLine("Press q to exit, any other key to return to menu.");
            if (Console.ReadKey(true).KeyChar == 'q')
                return -1;
            else
                return 0;

                
        }
        public double DisplayContents (BloggingContext db)
        {
            var blog = db.Blogs.Find();
            Console.WriteLine("Blog contents: ");
            foreach (var post in blog.Posts)
            {
                Console.WriteLine("- {0} -", post.Title);
                Console.WriteLine("    {0}", post.Content);
                Console.WriteLine();
            }
            return 0;
        }
    }
}
