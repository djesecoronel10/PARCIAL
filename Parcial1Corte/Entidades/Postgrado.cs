namespace Entidades
{
    public class Postgrado: Persona{

        public double PromedioGeneral { get; set; }
        
        public Postgrado()
        {}
        
        public Postgrado(
        int id, string nombre, string apellido,

        string carrera, int semestre, double promediogeneral): 
        
        base(id, nombre, apellido, carrera, semestre){





            PromedioGeneral = promediogeneral;
        }
        
        public override string ToString(){
            return $"{ID};" +
                   $"{Nombre};{Apellido};{Carrera};{Semestre};{PromedioGeneral}";
        }

        public override void CargarPersonas(string[] data){



            base.CargarPersonas(data);
            PromedioGeneral = double.Parse(data[6]);



        }
    }
}