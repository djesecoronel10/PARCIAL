namespace Entidades
{
    public class Pregrado: Persona{



        public double NotasCorte1 { get; set; }
        public double NotasCorte2 { get; set; }
        public double NotasCorte3 { get; set; }

        public Pregrado()
        {}

        public Pregrado(int noDocumento, string nombre, string apellido, string carrera, int semestre, double notasCorte1, double notasCorte2, double notasCorte3
   ): base(noDocumento, nombre, apellido, carrera , semestre){




            NotasCorte1 = notasCorte1;
            NotasCorte2 = notasCorte2;
            NotasCorte3 = notasCorte3;


        }


        public override string ToString(){



            return $"PRE;{ID};" +
            $"{Nombre};{Apellido};{Carrera};{Semestre};{NotasCorte1};" +
            $"{NotasCorte2};{NotasCorte3};";


        }



        public override void CargarPersonas(string[] data){


        base.CargarPersonas(data);

        NotasCorte1 = double.Parse(data[6]);
        NotasCorte2 = double.Parse(data[7]);
        NotasCorte3 = double.Parse(data[8]);

        
     }
    }
}