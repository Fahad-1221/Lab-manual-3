using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_manual_003
{
    class Book
    {
        public string[] ISBN = new string[20];
        public string[] Title = new string[20];

        public string[] MajorArea = new string[20];
        public string[] SubArea = new string[20];
        public int[] NumPage = new int[20];
        public int[] Price = new int[20];

        public void input()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"\nISBN of {i + 1} number book : ");
                ISBN[i] = Console.ReadLine();
                Console.Write($"Title of {i + 1} number book : ");
                Title[i] = Console.ReadLine();
                Console.Write($"Major Area of {i + 1} number book : ");
                MajorArea[i] = Console.ReadLine();
                Console.Write($"Sub area of {i + 1} number book : ");
                SubArea[i] = Console.ReadLine();
                Console.Write($"Price of {i + 1} number book : ");
                Price[i] = int.Parse(Console.ReadLine());
                Console.Write($"Number of pages of {i + 1} number book : ");
                NumPage[i] = int.Parse(Console.ReadLine());

            }

        }

        public void dis()
        {
            Console.WriteLine("\n\tRECORD OF BOOKS");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("\n   Book NUMBER {0}", i + 1);
                Console.WriteLine($"Title = {Title[i]} ");
                Console.WriteLine($"Main Area = {MajorArea[i]} ");
                Console.WriteLine($"Sub Area = {SubArea[i]} ");
                Console.WriteLine($"Price = {Price[i]} ");
                Console.WriteLine($"Number of pages  = {NumPage[i]} ");

            }


        }

        public void search(string title1)
        {
            for (int i = 0; i < 2; i++)
            {
                if (title1 == Title[i])
                {
                    Console.WriteLine($"Title = {Title[i]} ");
                    Console.WriteLine($"Main area = {MajorArea[i]} ");
                    Console.WriteLine($"Sub area = {SubArea[i]} ");
                    Console.WriteLine($"Price = {Price[i]} ");
                    Console.WriteLine($"no pf pages  = {NumPage[i]} ");
                }

            }
        }



    }
}
