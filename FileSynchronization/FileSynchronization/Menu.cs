using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
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
                              "1: Backup\n" +
                              "2: Restore\n" +
                              "9: Exit");
            Console.WriteLine("Select an option");

            _input = Console.ReadLine();
            Console.Clear();

            switch (_input)
            {
                case "1":
                    Console.WriteLine("Backup");
                    break;
                case "2":
                    Console.WriteLine("Restore");
                    break;
                case "9":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Not a valid option");
                    break;
            }
            Console.ReadKey();
        }
    }
}
