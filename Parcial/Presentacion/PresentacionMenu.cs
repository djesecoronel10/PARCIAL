using System;

namespace Presentacion
{
    public class PresentacionMenu
    {
        private PresentacionPost presentacionPostgrado = new PresentacionPost();
        private PresentacionPre presentacionPre = new PresentacionPre();
        private PresentacionPromedio presentarEstudiante = new PresentacionPromedio();

        public void MenuPrograma(){
            byte op;
            do{
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("------MENU UNIVERSIDAD POPULAR DEL CESAR------");
                Console.WriteLine("1. LISTADO ESTUDIANTES DE PREGRADO");
                Console.WriteLine("2. LISTADO ESTUDIANTES DE POSTGRADO");
                Console.WriteLine("3. PROMEDIO GENERAL DEL PROGRAMA");
                Console.WriteLine("4. ESTUDIANTE CON MEJOR RENDIMIENTO");
                Console.WriteLine("5. Salir");
                
                Console.Write("\nOpcion a realizar: ");
                op = byte.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        presentacionPre.Lista();
                        break;
                    case 2:
                        presentacionPostgrado.Lista();
                        break;
                    case 3:
                        presentarEstudiante.PresentarPromedio();
                        break;
                    case 4:
                        presentarEstudiante.PresentarMejor();
                        break;
                    case 5:
                        Console.WriteLine("\nGRACIAS POR CONFIAR EN UPCSERVICIOS");
                        break;
                }
            } while (op != 5);
        }
    }
}