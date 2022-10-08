package Modelo;

public class User {
    
    //Atributos de la clase
    private String cedula, nombre, apellido;
    private char sexo;

    
     //Constructor Getter y Setter
    public User() {
        this.cedula = "";
        this.nombre = "";
        this.apellido = "";
        this.sexo = 'N';
    }
   

    public String getcedula() {
        return cedula;
    }

    public void setcedula(String cc) {
        this.cedula = cc;
    }

    public String getnombre() {
        return nombre;
    }

    public void setnombre(String nombre) {
        this.nombre = nombre;
    }

    public String getapellido() {
        return apellido;
    }

    public void setapellido(String apellido) {
        this.apellido = apellido;
    }

    public char getsexo() {
        return sexo;
    }

    public void setsexo(char sexo) {
        this.sexo = sexo;
    }
}
