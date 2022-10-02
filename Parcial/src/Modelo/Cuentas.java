package Modelo;

import java.util.Scanner;


public class Cuentas {
    //atributos de la clase
    private int numCuenta;
    private String tipoCuenta;
    private double saldoInicial, saldo;
    private User titular;

    //Constructor getter y setter
    
                public Cuentas() {
                this.numCuenta = 0;
                this.tipoCuenta = "";
                this.saldoInicial = 0;
                this.saldo = 0;
                this.titular = new User();
                
                }

    public int getnumCuenta() {
        
        return numCuenta;
        
    }

    public void setnumCuenta(int numCuenta) {
        
        this.numCuenta = numCuenta;
        
    }

    public String gettipoCuenta() {
        
        return tipoCuenta;
        
    }

    public void settipoCuenta(String tipoCuenta) {
        
        this.tipoCuenta = tipoCuenta;
        
    }

    public double getsaldoInicial() {
        
        return saldoInicial;
        
    }

    public void setsaldoInicial(double saldoInicial) {
        
        this.saldoInicial = saldoInicial;
        
    }

    public double getsaldo() {
        
        return saldo;
        
    }

    public void setsaldo(double saldo) {
        
        this.saldo = saldo;
        
    }

    
    //Metodo crearUsuario
    
    public void crearUser(Scanner leer){
        
        System.out.print("Cedula: "); titular.setcedula(leer.nextLine());
        System.out.print("Nombre: "); titular.setnombre(leer.nextLine());
        System.out.print("Apellido: "); titular.setapellido(leer.nextLine());
        System.out.print("Sexo: "); titular.setsexo(leer.nextLine().charAt(0));
        
    }
    
    //Metodo consultarUser
    
    public User consultarUser(){
        
        return this.titular;
        
    }
    
}
