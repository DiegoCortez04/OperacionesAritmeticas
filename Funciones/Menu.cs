using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.Funciones
{
    public class Menu
    {
        public void Opciones()
        {
            Console.WriteLine("INGRESA UNA DE LAS OPCIONES");
            Console.WriteLine("1: SUMA");
            Console.WriteLine("2: RESTA");
            Console.WriteLine("3: MULTIPLICACION");
            Console.WriteLine("4: CAMBIAR DOLARES A PESOS");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            Operaciones operacion = new Operaciones();

            if (opcion == 4)
            {
                Console.WriteLine("INGRESA LOS DOLARES A CAMBIAR: ");
                double Dolar = double.Parse(Console.ReadLine());
                Console.WriteLine("TUS DOLARES SON: " + operacion.CambiarDolares(Dolar) + " PESOS");
                return;
            }
            Console.WriteLine("INGRESA EL PRIMER NUMERO: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESA EL SEGUNDO NUMERO: ");
            int num2 = int.Parse(Console.ReadLine());

            int Resultado;
            Resultado = operacion.Multiplicacion(num1, num2);
            switch (opcion)
            {
                case 1:
                    
                    Console.WriteLine("INGRESA EL TERCER NUMERO: ");
                    int num3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("INGRESA EL CAURTO NUMERO: ");
                    int num4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("INGRESA EL QUINTO NUMERO: ");
                    int num5 = int.Parse(Console.ReadLine());

                    Console.WriteLine("EL RESULTADO DE LA SUMA ES: " + operacion.Suma(num1, num2, num3, num4, num5));
                    break;

                case 2:
                    Console.WriteLine("EL RESULTADO DE LA RESTA ES: " + operacion.Resta(num1, num2));
                    break;

                case 3:
                    Console.WriteLine($"EL RESULTADO DE LA MULTIPLICACION ES: {Resultado}");
                    break;

                default:
                    Console.WriteLine("OPERACION INCORRECTA");
                    Opciones();
                    break;
            }
        }
    }
}
