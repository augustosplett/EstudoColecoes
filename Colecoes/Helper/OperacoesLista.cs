using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes.Helper
{
    public class OperacoesLista
    {
        public void ImprimirLista(List<string> lista)
        {
            foreach (var item in lista) { Console.WriteLine(item); }
        }
    }
}
