using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSynchronization
{
    class Menu
    {
        private static string _input;

        public static void MainMenu()
        {
            Console.WriteLine("Main menu:\n" +
                              "1: Something\n" +
                              "2: Some other thing");
            Console.WriteLine("Select an option");

            _input = Console.ReadLine();
            Console.Clear();

            switch (_input)
            {
                case "1":
                    Console.WriteLine("Hurray you pressed 1");
                    break;
                case "2":
                    Console.WriteLine("Hurray you pressed 2");
                    break;
                default:
                    Console.WriteLine("Not a valid option");
                    break;
            }
            Console.ReadKey();
        }
    }
}
