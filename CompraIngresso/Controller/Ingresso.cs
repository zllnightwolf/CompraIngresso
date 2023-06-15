using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraIngresso.Controller
{
    internal class Ingresso
    {
        private int num;
        public int Calculo(int quantidade, int valor)
        {
            num = quantidade * valor;

            
            
            return num;
        }
    }
}
