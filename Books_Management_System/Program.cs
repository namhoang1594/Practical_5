using System;
using System.Collections.Generic;

namespace Books_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int choice;
            Console.WriteLine("BOOKS MANAGEMENT SYSTEM");
            Console.WriteLine("1. Insert new book");
            Console.WriteLine("2. View list of book");
            Console.WriteLine("3. Average Price");
            Console.WriteLine("4. Exit");
            do
            {
                Console.WriteLine("\n Select: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        program.Insertnewbook();
                        break;
                    case 2:
                        program.Viewlistofbook();
                        break;
                    case 3:
                        program.AveragePrice();
                        break;
                    case 4: return;
                }
            }
            while (choice != 4);
        }
        int count = 0;
        Dictionary<int, Book> arrbook = new Dictionary<int, Book>();
        public void Insertnewbook()
        {
            Book book = new Book();
            book.ID = count;
            Console.WriteLine("Name: ");
            book.Name = Console.ReadLine();
            while (true)
            {

                try
                {
                    Console.WriteLine("Publish Date: ");
                    book.PublishDate = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Publish date is not formatted.");
                }
            }
            Console.WriteLine("Author: ");
            book.Author = Console.ReadLine();
            Console.WriteLine("Language: ");
            book.Language = Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Average Price " + (i + 1) + ": ");
                book[i] = int.Parse(Console.ReadLine());
            }
            arrbook.Add(count, book);
            count++;
        }
        public void Viewlistofbook()
        {
            foreach (Book item in arrbook.Values)
            {
                item.Display();
            }
        }
        public void AveragePrice()
        {
            foreach (Book item in arrbook.Values)
            {
                item.Calculate();
                item.Display();
            }
        }
    }
}
