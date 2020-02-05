using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncWait_01_Basico
{
    class Program
    {
        //Não é possível usar o async await no método Main
        static void Main(string[] args)
        {
            PrintMessage("Pedro");
            Console.ReadKey();
        }

        static async void PrintMessage (string name)
        {
            Console.WriteLine("{0}", await Task.Run(() => GetMessage(name)));
        }

        static string GetMessage(string name)
        {
            return "Hello, " + name;
        }

    }
}
