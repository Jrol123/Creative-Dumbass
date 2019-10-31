using ConsoleApp2;
using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            Console.WriteLine("0 - exit");
            Console.WriteLine("1 - give");
            Console.WriteLine("2 - take/add");
            //Console.WriteLine("3 - add");
            Console.WriteLine("3 - count");
            Console.WriteLine("4 - information about book");
            Console.WriteLine("5 - add a whole new book");
            Console.WriteLine();

            int a = 6;
            while (a != 0)
            {
                Console.WriteLine("enter the command");
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.Write("enter the count of books to give: ");
                        int cot = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.Write("enter the author: ");
                        string auth = Console.ReadLine();
                        Console.WriteLine();

                        Console.Write("enter the name of the book: ");
                        string nam = Console.ReadLine();
                        Console.WriteLine();

                        Boolean stat = false;
                        int end = 0;

                        for (int i = 0; i < books.Count; i++)
                        {
                            books[i].Minfo(out string nam1, out string auth1);
                            if (nam1 == nam && auth1 == auth)
                            {
                                stat = true;
                                end = i;
                                break;
                            }
                        }
                        if(!stat)
                        {
                            Console.WriteLine("SRY, we don't have this book yet");
                        }
                        else
                        {
                            books[end].Give(cot);
                        }
                        break;

                    case 2:
                        Console.Write("enter the count of books to take: ");
                        int cou = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.Write("enter the author: ");
                        string aut = Console.ReadLine();
                        Console.WriteLine();

                        Console.Write("enter the name of the book: ");
                        string namm = Console.ReadLine();
                        Console.WriteLine();

                        Boolean statt = false;
                        int endd = 0;

                        for (int i = 0; i < books.Count; i++)
                        {
                            books[i].Minfo(out string nam1, out string auth1);
                            if (nam1 == namm && auth1 == aut)
                            {
                                statt = true;
                                endd = i;
                                break;
                            }
                        }
                        if (!statt)
                        {
                            Console.WriteLine("SRY, we don't find this book!");
                        }
                        else
                        {
                            books[endd].Take(cou);
                        }

                        break;
                        /*
                    case 3:
                        Console.Write("enter the count of books to add: ");
                        int cout = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.Write("enter the author: ");
                        string autt = Console.ReadLine();
                        Console.WriteLine();

                        Console.Write("enter the name of the book: ");
                        string name = Console.ReadLine();
                        Console.WriteLine();

                        Boolean statis = false;
                        int endf = 0;

                        for (int i = 0; i < books.Count; i++)
                        {
                            books[i].Minfo(out string nam1, out string auth1);
                            if (nam1 == name && auth1 == autt)
                            {
                                statis = true;
                                endf = i;
                                break;
                            }
                        }
                        if (!statis)
                        {
                            Console.WriteLine("SRY, we don't find this book!");
                        }
                        else
                        {
                            books[endf].Take(cout);
                        }

                        break;
                        */
                    case 3:
                        Console.Write("enter the author: ");
                        string autt = Console.ReadLine();
                        Console.WriteLine();

                        Console.Write("enter the name of the book: ");
                        string nan = Console.ReadLine();
                        Console.WriteLine();

                        Boolean stas = false;
                        int en = 0;

                        for (int i = 0; i < books.Count; i++)
                        {
                            books[i].Minfo(out string nam1, out string auth1);
                            if (nam1 == nan && auth1 == autt)
                            {
                                stas = true;
                                en = i;
                                break;
                            }
                        }
                        if (!stas)
                        {
                            Console.WriteLine("SRY, we don't find this book!");
                        }
                        else
                        {
                            books[en].Stat();
                        }

                        break;
                    case 4:
                        Console.Write("enter the author: ");
                        string au = Console.ReadLine();
                        Console.WriteLine();

                        Console.Write("enter the name of the book: ");
                        string na = Console.ReadLine();
                        Console.WriteLine();

                        Boolean sta = false;
                        int eng = 0;

                        for (int i = 0; i < books.Count; i++)
                        {
                            books[i].Minfo(out string nam1, out string auth1);
                            if (nam1 == na && auth1 == au)
                            {
                                sta = true;
                                eng = i;
                                break;
                            }
                        }
                        if (!sta)
                        {
                            Console.WriteLine("SRY, we don't find this book!");
                        }
                        else
                        {
                            books[eng].Finfo();
                        }

                        break;
                    case 5:
                        books.Add(new Book());

                        break;
                    case 0:
                        Console.WriteLine("Goodbye!");
                        Console.ReadKey();

                        break;


                }
            }
        }
    }
}//Доделать методы + Доделать ввыдачу + доделать мелочь