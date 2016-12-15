using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent
{
    class View
    {
        public static void Show(Group gr)
        {
            for (int i = 0; i < gr.StudentCounter; i++)
            {
                Console.WriteLine("Student №{0}", i+1);
                Console.WriteLine(gr[i]);
               // gr.Remove();

            }

        }

        public static void ErrorMessage(string m)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(m);
            Console.ResetColor();
        }

        public static void SystemMessage(string m)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(m);
            Console.ResetColor();
        }

    }
}
