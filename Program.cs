using System;
using System.Collections.Generic;
using Booklib;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> listBook = new List<Book>();
            MyBookLib m = new MyBookLib();
            int choose;
            do
            {
                Console.WriteLine("***************BOOK MANAGER***************");
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. Find a book");
                Console.WriteLine("3. Show book list");
                Console.WriteLine("4. Remove a book");
                Console.WriteLine("5. Exit");
                Console.Write("Input command (1-5):");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        listBook=m.AddABook(listBook);
                        break;
                    case 2:
                        m.FindABook(listBook);
                        break;
                    case 3:
                        m.ViewListBook(listBook);
                        break;
                    case 4:
                        listBook=m.RemoveAbook(listBook);
                        break;
                    case 5:
                        Console.WriteLine("Bye!!!!");
                        break;
                    default:
                        Console.WriteLine("Please type input again!!!!");
                        break;
                }

            } while (choose != 5);
            Console.ReadLine();
        }
    }

}
