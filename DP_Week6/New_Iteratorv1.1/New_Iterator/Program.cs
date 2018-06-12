using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo info = new ConsoleKeyInfo();
            while (info.Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Type 'Facebook' to Create Facebook Profile or 'LinkedIn' to create LinkedIn Profile");
                string numToChooseProfile;
                try
                {
                    numToChooseProfile = Console.ReadLine();
                    Manager manager = new Manager();
                    SocialNetwork sn = null;
                    if (numToChooseProfile.ToLower() == "facebook")
                    {
                        sn = manager.CreateFacebook();
                    }
                    else if (numToChooseProfile == "exit")
                    {
                        break;
                    }
                    else /*(numToChooseProfile.ToLower() == "linkedin")*/
                    {
                        sn = manager.CreateLinkedIn();
                    }
                    IProfileIterator iterator = manager.CreateIterator(sn);
                    Console.WriteLine("Press key to Show Next Profile or Escape to exit()");
                    for (iterator.First(); !iterator.IsDone(); iterator.Next())
                    {
                        Console.WriteLine(iterator.CurrentProfile().Name);
                        if (info.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                        else
                        {
                            Console.ReadKey(true);
                        }
                    }
                    Console.WriteLine("\nThese are all the profiles we had!!!\n");
                    Console.WriteLine("*****************************************");
                    Console.WriteLine("\n");
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
