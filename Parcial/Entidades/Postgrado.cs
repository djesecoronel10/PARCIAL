namespace Entidades
{
    public class Postgrado: Persona{

        public double PromedioGeneral { get; set; }
        
        public Postgrado()
        {}
        
        public Postgrado(int id, string nombre, string apellido, 
            string carrera, int semestre, double promediogeneral
        ): base(id, nombre, apellido, carrera, semestre){
            PromedioGeneral = promediogeneral;
        }
        
        public override string ToString(){
            return $"POST;{ID};" +
                   $"{Nombre};{Apellido};{Carrera};{Semestre};{PromedioGeneral}";
        }

        public override void CargarDatos(string[] data){
            base.CargarDatos(data);
            PromedioGeneral = double.Parse(data[6]);
        }
    }
}