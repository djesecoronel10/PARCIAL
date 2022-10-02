using System;
using System.Linq;
using Entidades;

namespace Presentacion
{
    public class PresentacionPost : PresentacionPromedio
    {
        public void Lista()
        {
            Console.Clear();
            Console.WriteLine("------LISTADO DE ESTUDIANTES DE POSTGRADO------");

            foreach (var com in servicio.Listar().Where(persona => persona.GetType() == typeof(Postgrado))
                         .Cast<Postgrado>())
            {
                Console.WriteLine($"Numero Identificacion: {com.ID}");
                Console.WriteLine($"Nombre Completo: {com.Nombre} {com.Apellido}");
                Console.WriteLine($"Carrera: {com.Carrera}");
                Console.WriteLine($"Semestre: {com.Semestre}");
                Console.WriteLine($"Promedio: {com.PromedioGeneral}");
                
                Console.WriteLine();
            }
            Console.Write("Oprima una tecla para continuar.");Console.ReadKey();
        }
    }
}