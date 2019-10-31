using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Book
    {
        public string author;
        public string name;
        public string janr;
        public int year;
        public int pages;
        public int count;
        public Boolean ist;
        public Book()
        {
            //количество, название, автор, жанр, есть или нет
            Console.Write("Enter author: ");
            author = Console.ReadLine();

            Console.Write("Enter name: ");
            name = Console.ReadLine();

            Console.Write("Enter janr: ");
            janr = Console.ReadLine();

            Console.Write("Enter count of pages: ");
            pages = int.Parse(Console.ReadLine());

            Console.Write("Enter count of books: ");
            count = int.Parse(Console.ReadLine());

            Console.Write("Enter the year of release: ");
            year = int.Parse(Console.ReadLine());

            if (count > 0)
            {
                ist = true;
            }
            else
            {
                ist = false;
            }

        }
        public void Give(int n)
        {
            if(!ist || n > count)
            {
                Console.WriteLine("Sry, we have not enough books for this operation");
            }
            else if(n == count)
            {
                count = -n;
                ist = false;
                Console.WriteLine("PLS Buy more books. that was the last one!");
            }
            else
            {
                count -= n;
                Console.WriteLine("sucsess... We have {0} books like this in the library!",count);
            }
        }
        public void Minfo(out string nam, out string auth)
        {
            nam = name;
            auth = author;
        }
        public void Finfo()
        {
            Console.WriteLine("author:{0}",author);
            Console.WriteLine("name:{0}", name);
            Console.WriteLine("janr:{0}", janr);
            Console.WriteLine("year:{0}", year);
            Console.WriteLine("pages:{0}", pages);
            Console.WriteLine("count:{0}", count);
        }
        public void Stat()
        {
            if(ist)
            {
                Console.WriteLine("Yes, there's {0} books like this",count);
            }
            else
            {
                Console.WriteLine("SRY, no books (");
            }
            Console.WriteLine();
        }
        public void Take(int n)
        {
            count += n;
            Console.WriteLine("sucsess... We have {0} books like this in the library!", count);
        }
    }
}
