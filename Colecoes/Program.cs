using Colecoes.Helper;
using System;
using System.Collections.Generic;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ
            int[] arrayNumeros = new int[5] { 131, 2222, 783, 124, 54 };

            var numerosParesQuerys = 
                from numero in arrayNumeros
                where numero % 2 == 0
                orderby numero
                select numero;

            var numerosParesMetodo = arrayNumeros.Where(numero => numero % 2 == 0).OrderBy(numero => numero).ToList();

            Console.WriteLine( "query" + string.Join(", ", numerosParesQuerys));
            Console.WriteLine( "metodo + "string.Join(", ", numerosParesMetodo));

            ////dicionários
            //Dictionary<string,string> estados = new Dictionary<string,string>();

            //estados.Add("SP", "São Paulo");
            //estados.Add("RS", "Rio Grande Do Sul");
            //estados.Add("SC", "Santa Catarina");

            //foreach(KeyValuePair<string,string> s in estados)
            //{
            //    Console.WriteLine($"CHAVE: {s.Key}, VALOR: {s.Value}");
            //}

            ////ACESSANDO DE FORMA SEGURA
            //string valorProcurado = "MG";


            //if (estados.TryGetValue(valorProcurado, out string estadoEncontrado)){

            //    Console.WriteLine(estadoEncontrado);
            //}
            //else
            //{
            //    Console.WriteLine($"{valorProcurado} não existe no dicionario");
            //}
            ////pilhas
            //Stack<string> pilhaLivros = new Stack<string>();
            //pilhaLivros.Push("Jose");
            //pilhaLivros.Push("Maria");
            //pilhaLivros.Push("Heitor");
            //pilhaLivros.Push("Janaina");

            //while(pilhaLivros.Count > 0)
            //{
            //    Console.WriteLine(pilhaLivros.Pop());

            //}


            //filas
            //Queue<string> fila = new Queue<string>();

            //fila.Enqueue("Augusto");
            //fila.Enqueue("Cecilia");
            //fila.Enqueue("Priscilla");
            //fila.Enqueue("Ione");

            //while (fila.Count > 0)
            //{
            //    Console.WriteLine((string)fila.Dequeue());

            //}   
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