using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncWait_03_Basico
{
    class Program
    {
        static void Main(string[] args)
        {
            FazerCalculoAsync();
            Console.WriteLine("A tarefa foi disparada. Aguardando resultado...");
            Console.ReadKey();
        }
        private static async void FazerCalculoAsync()
        {
            await ExecutarCalculo();
        }
        private static Task ExecutarCalculo()
        {
            return Task.Run(() =>
            {
                int result = 0;
                for (int i = 0; i <= 10; i++)
                {
                    result += i;
                    Thread.Sleep(300);
                }
                Console.WriteLine("0 resultado é {0}", result);
            });
        }
    }
}
