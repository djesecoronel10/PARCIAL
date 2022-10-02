package Modelo;

import java.util.Scanner;

public class Sede {
   //Atributos de la clase
    private String nombre, ciudad, direccion;
    private int numCuenta;
    private Cuentas cuentas[];
    
   //Constructor Getter y Setter
    
    public Sede(){
        this.nombre = "";
        this.ciudad = "";
        this.direccion = "";
        this.numCuenta = 0;
        this.cuentas = new Cuentas[10];
    }

    public String getnombre() {
        return nombre;
    }

    public void setnombre(String nombre) {
        this.nombre = nombre;
    }

    public String getciudad() {
        return ciudad;
    }

    public void setciudad(String ciudad) {
        this.ciudad = ciudad;
    }

    public String getdireccion() {
        return direccion;
    }

    public void setdireccion(String direccion) {
        this.direccion = direccion;
    }

    public int getnumCuentas() {
        return numCuenta;
    }
    
    //Metodo crearCuenta

    public void crearCuenta(Scanner leer, int posicion){
        cuentas[posicion] = new Cuentas();
        
        System.out.print("Ingrese # de cuenta: "); cuentas[posicion].setnumCuenta(leer.nextInt());
        leer.nextLine();
        System.out.print("Tipo de cuenta: "); cuentas[posicion].settipoCuenta(leer.nextLine());
        System.out.print("Saldo inicial: "); cuentas[posicion].setsaldoInicial(leer.nextDouble());
        
        System.out.println("");
        System.out.println("Informacion del Titular de la Cuenta: ");
        leer.nextLine();
        cuentas[posicion].crearUser(leer);
        
        this.numCuenta++;
    }
    
    //Metodo consultarCuenta
    
    public Cuentas consultarCuenta(int pos){
        return this.cuentas[pos];
    }
}