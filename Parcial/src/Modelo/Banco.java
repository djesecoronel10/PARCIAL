package Modelo;

import java.util.Scanner;

public class Banco {
    //Atributos de la clase
    private String nombreBanco;
    private int numSedes;
    private Sede sedes[];
    
    Scanner leer = new Scanner(System.in);
    //constructor getter y setter
    public Banco(){
    this.nombreBanco = "";
    this.numSedes = 0;
    this.sedes = new Sede[20];
    }

    public String getnombreBanco() {
        return nombreBanco;
    }

    public void setnombreBanco(String nombreBanco) {
        this.nombreBanco = nombreBanco;
    }

    public int getnumSedes() {
        return numSedes;
    }

    public void setnumSedes(int noSedes) {
        this.numSedes = noSedes;
    }
    
    //Metodo Crear Sede
    
    public void crearSede(int posicion, Scanner leer){
        sedes[posicion] = new Sede();
        
        System.out.print("Ingrese el nombre de la sede: ");
        sedes[posicion].setnombre(leer.nextLine());
        System.out.print("Ingrese ciudad: ");
        sedes[posicion].setciudad(leer.nextLine());
        System.out.print("Ingrese direccion: ");
        sedes[posicion].setdireccion(leer.nextLine());
        
        this.numSedes++;
    }
    
    //  Metodo consultarSede
    
    public Sede consultarSede(int posicion){
        return sedes[posicion];
    }
}