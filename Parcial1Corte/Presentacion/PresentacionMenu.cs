using System;

namespace Presentacion
{
    public class PresentacionMenu
    {
        private PresentacionPost presentacionPostgrado = new PresentacionPost();
        private PresentacionPre presentacionPre = new PresentacionPre();
        private PresentacionPromedio presentarEstudiante = new PresentacionPromedio();

        public void MenuPrograma(){
            byte desc;
            do{
                Console.Clear();
                Console.WriteLine("******************** UPCSERVICIOS ********************");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("------MENU DE OPCIONES------");
                Console.WriteLine("");
                Console.WriteLine("1. LISTADO ESTUDIANTES DE PREGRADO");
                Console.WriteLine("");
                Console.WriteLine("2. LISTADO ESTUDIANTES DE POSTGRADO");
                Console.WriteLine("");
                Console.WriteLine("3. PROMEDIO GENERAL DEL PROGRAMA");
                Console.WriteLine("");
                Console.WriteLine("4. ESTUDIANTE CON MEJOR RENDIMIENTO");
                Console.WriteLine("");

                Console.WriteLine("5. CERRAR PROGRAMA");
                
                Console.Write("\nPORFAVOR DIGITER EL NUMERO DE SU OPCION A REALIZAR: ");

                desc = byte.Parse(Console.ReadLine());

                switch (desc)
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
            } while (desc != 5);
        }
    }
}