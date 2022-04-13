using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCalculadora
{
    internal class BaseCalculadora
    {

        public BaseCalculadora() { }

        public int sumar(int a,int b)
        {
            return a + b;
        }
        public int restar(int a, int b)
        {
            if (a >= b)
            {
                return a - b;
            }
            else {
                return b - a;
            }
        }
        public int multiplicar(int a, int b)
        {
            return a * b;
        }

        public int dividir(int a, int b)
        {
            try
            {
                if (a >= b)
                {
                    return a / b;
                } else
                {
                    return b / a;
                }
            } catch (Exception)
            {
                Console.WriteLine("No es posibile dividir por 0");
                return -1;
            }
        }


    }
}
