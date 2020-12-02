using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimo_Proyecto
{
    class Empleado
    {
        /*Con la siguiente información:
· Nombres de 5 empleados.
· Salario, cobrado por cada empleado, en los últimos 3 meses.

Crear el programa para:
a) Cargar la información de los empleados y sus respectivos sueldos.
b) Generar un vector que contenga el ingreso acumulado en salarios en los últimos 3 meses para cada empleado.
c) Mostrar por pantalla el total pagado en salario a todos los empleados en los últimos 3 meses
d) Obtener el nombre del empleado que tuvo el mayor ingreso acumulado*/

        private string[] empleados;
        private int[,] sueldos;
        private int[] sueldostot;

        public void Cargar()
        {
            empleados = new String[5];
            sueldos = new int[5,3];
            for (int p = 0; p < empleados.Length; p++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
               
                Console.Write("Digite el nombre del empleado:");
               
                empleados[p] = Console.ReadLine();
                
                for (int a = 0; a < sueldos.GetLength(1); a++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Digite el sueldo del empleado:");
                    string linea;
                    linea = Console.ReadLine();
                    sueldos[p, a] = int.Parse(linea);
                }
            }
        }

        public void Calcular()
        {
            sueldostot = new int[5];
            for (int p = 0; p < sueldos.GetLength(0); p++)
            {
                int suma = 0;
                for (int a = 0; a < sueldos.GetLength(1); a++)
                {
                    suma = suma + sueldos[p, a];
                }
                sueldostot[p] = suma;
            }
        }

        public void Imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Total de los  sueldos Recibidos por los empleados.");
            for (int p = 0; p < sueldostot.Length; p++)
            {
                Console.WriteLine(empleados[p] + " = " + sueldostot[p]);
            }
        }

        public void EmpleadoMayorSueldo()
        {

            int Total = sueldostot[0];
            string Nomb = empleados[0];
            for (int p = 0; p < sueldostot.Length; p++)
            {
                if (sueldostot[p] > Total)
                {
                    Total = sueldostot[p];
                    Nomb = empleados[p];
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El empleado con mayor sueldo es: " + Nomb + " y su sueldo total es de: " + Total);
        }
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.Cargar();
            empleado.Calcular();
            empleado.Imprimir();
            empleado.EmpleadoMayorSueldo();
            Console.ReadKey();
        }

    }
}

