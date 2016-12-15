using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Group n = new Group(2);
            
            n.Input();

            View.Show(n);

            Console.ReadKey();
           

        }
    }
}
