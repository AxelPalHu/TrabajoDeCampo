using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoDeCampo
{
    class Empleado
    {
        public string Nombre;
        public int Edad;
        public double Sueldo;

        
        public Empleado(string nombre, int edad, double sueldo)
        {
            Nombre = nombre;
            Edad = edad;
            Sueldo = sueldo;
        }

       
        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Sueldo: $" + Sueldo);
            Console.WriteLine("---------------------------");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<Empleado> empleados = new List<Empleado>();

            
            empleados.Add(new Empleado("Juan Pérez", 30, 2000.00));
            empleados.Add(new Empleado("Laura Gómez", 28, 2500.50));
            empleados.Add(new Empleado("Carlos Ruiz", 45, 3200.75));

            
            Console.WriteLine("LISTA DE EMPLEADOS:\n");
            foreach (Empleado emp in empleados)
            {
                emp.MostrarDatos();
            }

            Console.ReadKey(); 
        }
    }
}
