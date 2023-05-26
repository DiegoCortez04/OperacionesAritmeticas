using Ejercicio01.Clases;
using System;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona alumno = new Persona();
            alumno.LlenarDatos();
            alumno.ImprimirDatos();

        }
    }
}
