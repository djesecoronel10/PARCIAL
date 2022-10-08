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
            Console.Write("**EN ESTA SECCION PODRA SABER EL PROMEDIO GENERAL DE CUALQUIERA DE NUESTRAS CARRERAS**");
            Console.WriteLine("");
            Console.WriteLine("ESCRIBA EL PROGRAMA ---->");
            var materia = Console.ReadLine().ToUpper();
            
            Console.WriteLine(servicio.Promedio(materia));
            Console.Write("Presione la Tecla ENTER para continuar. ");Console.ReadKey();
        }






        public void PresentarMejor(){

            Console.Clear();

            Console.WriteLine("------RECONOCIMIENTOS------");
            Console.WriteLine("");
            Console.Write("**ESTA SECCION ES PARA PODER VER EL MEJOR ESTUDIANTE DE CADA PROGRAMA**");
            Console.WriteLine("");
            Console.Write("Programa: ");
            Console.WriteLine("");
            var materia = Console.ReadLine().ToUpper();
            
            Console.WriteLine(servicio.Destacado(materia));
            Console.Write("Presione la Tecla ENTER para continuar. ");Console.ReadKey();
        }
    }
}