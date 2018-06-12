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
            //Console.WriteLine("Press 1 to Create Facebook Profile or 2 to create LinkedIn Profile");
            //int numToChooseProfile = Convert.ToInt32(Console.ReadLine());
            
            Manager manager = new Manager();
            SocialNetwork sf = manager.CreateFacebook();
            SocialNetwork sl = manager.CreateLinkedIn();

            IProfileIterator iterator = manager.CreateIterator(sf);
            IProfileIterator iteratorLinkedin = manager.CreateIterator(sl);

            for (iterator.First(); !iterator.IsDone(); iterator.Next())
            {
                Console.WriteLine(iterator.CurrentProfile().Name);
            }

            Console.ReadLine();
        }
    }
}
