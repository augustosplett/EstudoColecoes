using Colecoes.Helper;
using System;
using System.Collections.Generic;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //filas
            Queue<string> fila = new Queue<string>();

            fila.Enqueue("Augusto");
            fila.Enqueue("Cecilia");
            fila.Enqueue("Priscilla");
            fila.Enqueue("Ione");

            while (fila.Count > 0)
            {
                Console.WriteLine((string)fila.Dequeue());

            }   
            //OperacoesLista operacoesLista = new OperacoesLista();
            //List<string> estado = new List<string>();
            //estado.Add("rs");
            //estado.Add("sc");
            //estado.Add("pr");

            //Console.WriteLine(estado.Count);

            //operacoesLista.ImprimirLista(estado);


            ////int[] arrayInteiros = new int[3];
            ////arrayInteiros[0] = 10;
            ////arrayInteiros[1] = 20;
            ////arrayInteiros[2] = 30;
            //////no for, o ideial é usar a propriedade lenght de um array para caso aconteça de algum momento mudar o tamanho do array, não terá impacto aqui no for
            ////for (int i = 0; i < arrayInteiros.Length; i++)
            ////{
            ////    Console.WriteLine("For " + arrayInteiros[i]);
            ////}

            //////tbm pode-se usar o for, sem a necessidade de um contador
            ////foreach(int i in arrayInteiros)
            ////{
            ////    Console.WriteLine("Foreach " + i);
            ////}

            ////Ordenação de Arrays
            //OperacoesArray op = new OperacoesArray();
            //int[] array = new int[5] { 8, 7, 12, 141,23 };
            //int[] array2 = new int[10];

            //Console.WriteLine("Array Inicial");
            //op.ImprimirArray(array);

            ////op.OrdenarBubbleSort(array);
            ////op.Ordenar(array);
            ////Console.WriteLine("Array Ordenado");
            ////op.ImprimirArray(array);
            //Console.WriteLine("novo array antes da copia");
            //op.ImprimirArray(array2);
            //op.Copiar(array, array2);
            //Console.WriteLine("novo array depois da copia");
            //op.ImprimirArray(array2);


        }
    }
}