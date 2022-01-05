using System;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInteiros = new int[3];
            arrayInteiros[0] = 10;
            arrayInteiros[1] = 20;
            arrayInteiros[2] = 30;
            //no for, o ideial é usar a propriedade lenght de um array para caso aconteça de algum momento mudar o tamanho do array, não terá impacto aqui no for
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                Console.WriteLine(arrayInteiros[i]);
            }

            //tbm pode-se usar o for, sem a necessidade de um contador
            foreach(int i in arrayInteiros)
            {
                Console.WriteLine("foreach" + i);
            }
        }
    }
}