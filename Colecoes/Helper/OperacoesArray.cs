using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes.Helper
{
    internal class OperacoesArray
    {
        public void OrdenarBubbleSort(int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if(array[j] > array[j +1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public void ImprimirArray(int[] array)
        {
            var linha = string.Join(", ", array);
            Console.WriteLine(linha);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
        }

        public void Ordenar( int[] array)
        {
            Array.Sort(array);
        }

        public void Copiar(int[] arrayOrigem, int[] arrayDestino)
        {
            Array.Copy(arrayOrigem, arrayDestino,arrayOrigem.Length);
        }
    }
}
