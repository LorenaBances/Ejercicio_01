using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tipo de fruta");
            Console.WriteLine("1: Naranja");
            Console.WriteLine("2: Fresa");
            Console.WriteLine("3: Mango");
            string tipoTexto = Console.ReadLine();

            Console.Write("Ingrese la distancia: ");
            string distanciaTexto = Console.ReadLine();

            float distancia = float.Parse(distanciaTexto);
            int tipoFruta = int.Parse(tipoTexto);
            float pago = 0;

            switch (tipoFruta)
            {
                case  1:
                    if (distancia < 30)
                    {
                        pago = 2;
                    }
                    else
                    {
                        pago = 4;
                    }
                    break;
                case 2:
                    if (distancia < 30)
                    {
                        pago = 6;
                    }
                    else
                    {
                        pago = 9;
                    }
                    break;
                case 3:
                    if (distancia < 30)
                    {
                        pago = 3;
                    }
                    else
                    {
                        pago = 5;
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine("El pago es: " + pago);
            Console.ReadLine();
        }


    }
    
}

