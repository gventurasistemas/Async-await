using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncWait_02
{
    class Program
    {       
        static void Main(string[] args)
        {
            FazerCalculoAsync();
            Console.WriteLine("A tarefa foi disparada. Aguardando resultado...");
            Console.ReadKey();
        }

        //async mostra ao compilador que aquele método é assíncrono e, portanto, 
        //não deve interromper o fluxo de execução caso a tarefa que é executada 
        //dentro dele demore algum tempo para retornar seu valor ou executar seus procedimentos
        private static async void FazerCalculoAsync()
        {
            //await causa uma suspensão para aguardar o resultado da task para a qual ele aponta
            int resultado = await ExecutarCalculo();
            Console.WriteLine("O resultado foi {0}", resultado);
        }
        private static Task<int> ExecutarCalculo()
        {
            return Task.Run(() =>
            {
                int result = 0;
                for (int i = 0; i <= 10; i++)
                {
                    result += i;
                    Thread.Sleep(300);
                }
                return result;
            });
        }












    }
}
