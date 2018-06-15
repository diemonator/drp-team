using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BookConverter
{
    class Program
    {
        private static Manager myManager;
        static void Main(string[] args)
        {
            myManager = new Manager();
            List<string> books = new List<string>();
            books = myManager.GetListOfBooks();
            Console.WriteLine("We have the following books:-");
            int count = 1;
            foreach (string s in myManager.GetListOfBooks())
            {
                Console.WriteLine("Press " + count + " for " + s);
                count++;
            }
            char inputForBook = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Press '1' to convert string to Xml, Press '2' to convert file to Pdf, 'q' to quit and 'r' to start a new console");
            char inputForFile = Convert.ToChar(Console.ReadLine());

            while (inputForFile != 113)
            {
                if (inputForFile == 49 || inputForFile == 50)
                {
                    int i = (int)Char.GetNumericValue(inputForFile);
                    int j = (int)Char.GetNumericValue(inputForBook);
                    myManager = new Manager();
                    Console.WriteLine("Congrats!!! " + " " + books[j - 1] + " " + myManager.ToString(i, j));
                }
                else if (inputForFile == 113)
                {
                    Environment.Exit(0);
                }
                else if (inputForFile == 114)
                {
                    Console.WriteLine("Press '1' to convert string to Xml, Press '2' to convert file to Pdf, 'q' to quit and 'r' to start new console");
                    var info = new System.Diagnostics.ProcessStartInfo(Environment.GetCommandLineArgs()[0]);
                    System.Diagnostics.Process.Start(info);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                inputForFile = Convert.ToChar(Console.ReadLine());
            }
            Environment.Exit(0);
        }
    }
}
