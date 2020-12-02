using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimo_Proyecto
{
    class Program
    {
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
