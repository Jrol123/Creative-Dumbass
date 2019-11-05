using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bycicle
{
    class Program
    {
        static void Transformator(string a, List<List<string>> glob, out Boolean stutus, out List<List<string>> globall)
        {
            string[] com = { "bicycle", "help", "xtml" };
            List<string> person = new List<string>();

            Boolean status = false;

            if (a == "help")
            {
                status = true;
                Console.WriteLine("List of commands:");

                Console.WriteLine("1. 'help', to see this list");
                Console.WriteLine("2. 'bicycle' to give someone a bike");
                Console.WriteLine("3. 'xtml' to see the list of users");
                Console.WriteLine("4. 'back' to take bike back");
            }
            else if (a == "bicycle")
            {
                status = true;
                Console.WriteLine();
                Console.WriteLine("Write the first name and last name of the man, that want's to take a bike");
                Console.WriteLine();

                string fs = Console.ReadLine();
                Console.WriteLine();

                Boolean lol = false;
                Boolean police = false;

                person.Add(fs);

                if (glob.Count > 0)
                {
                    for (int i = 0; i < glob.Count; i++)
                    {
                        if (fs == glob[i][0])
                        {
                            lol = true;

                            Console.WriteLine("Woah! We know this man! he has {0} reputation, and his count of travels is {1}!", glob[i][2], glob[i][3]);
                            Console.WriteLine();
                            if (glob[i][2] == "0")
                            {
                                Console.WriteLine("ABORT! IT'S A CRIMINAL DANGER FOR OUR BUISNESS! CALL A POLICE!");
                                police = true;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Do you want to give him a bike? (Yes/No)");
                                Console.WriteLine();
                            }

                            break;
                        }
                    }
                    if (police == true)
                    {

                    }
                }

                if (lol == false)
                {
                    int NM = glob.Count;
                    Console.WriteLine("Well... We have a new member of our great family!");

                    glob.Add(new List<string>());
                    glob[0].Add(fs);

                    Console.WriteLine();
                    Console.WriteLine("We need a phone number of this person");
                    Console.WriteLine();

                    glob[NM].Add(Console.ReadLine());
                    glob[NM].Add("10");
                    glob[NM].Add("0");
                }

                Console.WriteLine("Well... Se Ya later, man! Goodbye!");

            }
            else if (a == "xtml")
            {
                status = true;


            }
            else if (a == "back")
            {
                status = true;

                Console.WriteLine();
                Console.WriteLine("Write the first name and last name of the man, that want's to take a bike");
                Console.WriteLine();

                string check = Console.ReadLine();

                if(glob.Equals (check))
                {
                    Console.WriteLine();
                    Console.WriteLine("Did he return the bycicle at time?(Yes/No)");
                    Console.WriteLine();

                    int ball = 10;

                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You typed the wrong name!");
                    Console.WriteLine();
                }

                
            }
            else
            {
                status = false;
                Console.WriteLine("Wrong Command");
            }
            globall = glob;
            stutus = status;
        }
        static void Main(string[] args)
        {
            List<List<string>> global = new List<List<string>>();
            Boolean stat = false;

            Console.WriteLine("Hello, Worker!");

            while (1 != 2)
            {
                Console.WriteLine("Enter command or type 'help' to see the list of commands");
                Console.WriteLine();

                string input = Console.ReadLine();

                Console.WriteLine();

                if (input == "end")
                {
                    Console.WriteLine("Goodbye!");

                    break;
                }

                while (stat == false)
                {
                    Transformator(input, global, out Boolean status, out List<List<string>> globall);

                    global = globall;

                    stat = status;

                    if(stat == true)
                    {
                        break;
                    }

                    Console.WriteLine();
                    Console.WriteLine("Enter command or type 'help' to see the list of commands");
                    Console.WriteLine();

                    input = Console.ReadLine();
                }
                Console.WriteLine();
                Console.WriteLine("Job's done! Press any key, to enter at the 'Command input' mode!");
                Console.ReadKey();
                Console.Clear();

                stat = false;
            }

            Console.ReadKey();
        }
    }
}
