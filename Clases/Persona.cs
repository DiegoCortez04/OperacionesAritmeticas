using Ejercicio01.Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Carrera { get; set; }
        public int Edad { get; set; }

        public void LlenarDatos()
        {
            Console.WriteLine("INGRESA TU NOMBRE: ");
            this.Nombre = Console.ReadLine();
            Console.WriteLine("INGRESA TU APELLIDO: ");
            this.Apellido = Console.ReadLine();
            Console.WriteLine("INGRESA TU CARRERA: ");
            this.Carrera = Console.ReadLine();
            Console.WriteLine("INGRESE SU EDAD: ");
            this.Edad = int.Parse(Console.ReadLine());
            Console.Clear();

            if (Edad >= 18)
            {
                Menu menu = new Menu();
                menu.Opciones();
            }
            else
            {
                Console.WriteLine("NO PUEDES ACCEDER");
                LlenarDatos();
            }
        }
        public void ImprimirDatos()
        {
            Console.WriteLine("NOMBRE: " + Nombre);
            Console.WriteLine("APELLIDO: " + Apellido);
            Console.WriteLine("CARRERA: " + Carrera);
            Console.WriteLine("EDAD: " + Edad);
        }
    }
}
