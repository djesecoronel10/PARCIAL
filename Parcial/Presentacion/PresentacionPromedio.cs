using System;
using Logica;

namespace Presentacion
{
    public class PresentacionPromedio{

        protected AccionesPersona servicio = new AccionesPersona();
        
        public void PresentarPromedio(){

            Console.Clear();

            Console.WriteLine("------BIENVENIDO A CALCULAR PROMEDIO------");
            Console.WriteLine("");
            Console.Write("Escriba el programa que desea saber el promedio: ");
            var materia = Console.ReadLine().ToUpper();
            
            Console.WriteLine(servicio.Promedio(materia));
            Console.Write("Presione la Tecla ENTER para continuar. ");Console.ReadKey();
        }

        public void PresentarMejor(){

            Console.Clear();

            Console.WriteLine("------MEJORES ESTUDIANTES------");
            Console.WriteLine("");
            Console.Write("Programa: ");
            var materia = Console.ReadLine().ToUpper();
            
            Console.WriteLine(servicio.Destacado(materia));
            Console.Write("Presione la Tecla ENTER para continuar. ");Console.ReadKey();
        }
    }
}