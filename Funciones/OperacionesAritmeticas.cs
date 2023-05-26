using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.Funciones
{
    public class Operaciones
    {
        #region MANERA EXTENSA
        //public int num1, num2;
        //public void Suma()
        //{
        //    Console.WriteLine("SUMA");
        //    Console.WriteLine("INGRESA EL PRIMER NUMERO: ");
        //    num1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("INGRESA EL SEGUNDO NUMERO: ");
        //    num2 = int.Parse(Console.ReadLine());
        //    Console.WriteLine($"EL RESULTADO ES: { num1 + num2}");
        //}
        #endregion
        public int Suma(int num1,int num2,int num3,int num4,int num5)
        {
            //return num1 + num2;

            int resultado = num1 + num2;
            return resultado;
        }
        public int Resta(int num1, int num2)
        {
            //return num1 - num2;

            int resultado = num1 - num2;
            return resultado;
        }
        public int Multiplicacion(int num1, int num2)
        {
            //return num1 * num2;

            int resultado = num1 * num2;
            return resultado;
        }
        public double CambiarDolares(double dolar)
        {
            //return num1 * num2;
            double Peso = dolar * 18;
            
            return Peso;
        }
    }
}
