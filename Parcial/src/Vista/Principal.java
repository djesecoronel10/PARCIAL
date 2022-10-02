package Vista;

import Modelo.*;
import java.util.Scanner;

public class Principal {

    public static void main(String[] args) {
            //creacion de nuevos objetos
            
            Banco nuevo = new Banco();
            Sede sede;
            Cuentas cuenta;
        
                Scanner nueva = new Scanner(System.in);
                int i, opcion = 0, numero = 0, numero1 = 0;

                //ciclo repetitivo para el menu
                
        while (opcion != 6) {
            System.out.println("");
                System.out.println("///BIENVENIDO A TU BANCO///");
                System.out.println("MENU DE OPCIONES: ");
                System.out.println("1. Crear un Banco");
                System.out.println("2. Crear una Sede");
                System.out.println("3. Apertura de cuenta bancaria");
                System.out.println("4. Consultar alguna Sede");
                System.out.println("5. Consultar alguna Cuenta");
                System.out.println("6. Salir del Programa");

            System.out.println("");
                System.out.println("Digite el numero se la opcion a realizar: ");
            opcion = nueva.nextInt();

            System.out.println();
            nueva.nextLine();

            switch (opcion) {
                
//Proceso Opcion Numero 1  
                
                case 1:
                    //identifica si anteriormente ya habia sido creado un banco, si aun no ha sido creado el programa procede a hacerle las preguntas
                    if (nuevo.getnombreBanco() .equals("") != true) {
                        
                        System.out.println("Ya se ha creado un banco, porfavor cree alguna sede o cuenta bancaria.");
                        
                    } else {
                        
                        System.out.println("Nombre del Banco: ");
                        nuevo.setnombreBanco(nueva.nextLine());
                    }
                    break;

                case 2:
                    //verfica que hayan banco registrados y si los hya, realiza la creacion de la sede
                    if (nuevo.getnombreBanco().equals("")) {
                        
                        System.out.println("No se encuentra ningun Banco Registrado.");
                        
                    } else {
                        
                        nuevo.crearSede(numero, nueva);
                        
                    }
                    break;
                    
//Proceso Opcion Numero 3
                    
                case 3:
            //se verifica si hay bancos y sedes registrados, si los hay pueden realizar la apertura de la cuenta
                    if (nuevo.getnombreBanco().equals("")) {
                        
                        System.out.println("No se encuentra Ningun Banco para poder crear cuentas");
                        
                    } else if (nuevo.getnumSedes() == 0) {
                        
                        System.out.println("El banco no tiene sedes. Cree una.");
                        
                    } else {
                        System.out.println("Numero de la sede en la cual desea inscribir la cuenta: ");
                        
                        numero1 = nueva.nextInt();

                        if (numero1 > nuevo.getnumSedes()) {
                            
                            System.out.println("No existe la sede seleccionada.");
                            
                        } else {
                            sede = nuevo.consultarSede(numero1 - 1);
                            
                            if (sede.getnumCuentas() == 10) {
                                
                                System.out.println("\nEsta sede ya alcanzó el limite de cuentas.");
                                
                            } else {
                                for (i = 0; i <= sede.getnumCuentas(); i++) {
                                    
                                    if (sede.consultarCuenta(i) == null) {
                                        
                                        numero1 = i;
                                        
                                        break;
                                    }
                                }
                    System.out.println();
                    sede.crearCuenta(nueva, numero1);
                            }
                        }
                    }
                    break;
                    
//Proceso para la opcion 4
                    
                case 4:
                    //si no hay ningun banco o sede registrado arrojara error, sino el programa preguntara la sede a consultar teniendo en cuenta que estan identificadas
                    //por orden de creacion
                    if (nuevo.getnombreBanco().equals("")) {
                        
                        System.out.println("No hay banco existente para la consulta de sedes");
                        
                    } else 
                        
                        if (nuevo.getnumSedes() == 0) {
                            
                        System.out.println("Aun no se encuentra ninguna sede abierta");
                        
                    } else {
                            
                        System.out.println("Sede a Consultar: ");
                        
                        numero1 = nueva.nextInt();

                        if (numero1 > nuevo.getnumSedes()) {
                            
                            System.out.println("ERROR. Cuenta no existente");
                            
                        } else {
                            
                            sede = nuevo.consultarSede(numero1 - 1);
                            System.out.println("");
                            System.out.println("INFORMACION DE LA SEDE SOLICITADA:");
                            System.out.println("Nombre: " + sede.getnombre());
                            System.out.println("Direccion: " + sede.getdireccion());
                            System.out.println("Cuidad: " + sede.getciudad());
                            
                        }
                    }
                    break;
                    
//Proceso para la opcion 5
                    
                case 5:
                    //si no hay banco existente el programa arroja error debido a que no hay ningun banco creado aun
                    if (nuevo.getnombreBanco().equals("")) {
                        
                        System.out.println("No hay banco existente para poder consultar alguna cuenta");
                        
                    //si no hay sedes registrada el programa arroja el mensaje de que no hay ninguna sede creada
                    } else
                        
                        if (nuevo.getnumSedes() == 0) {
                            
                        System.out.println("No se encontro ninguna sede para la consulta de cuentas");
                        
                    //si no hay ningun problema, el programa le preguntara cual cuenta desea consultar teniendo en cuenta que las cuentas van en orden de creacion    
                    } else {
                            
                        System.out.println("¿En que sede desea consultar la cuenta?");
                        
                        numero1 = nueva.nextInt();
                        
                    //si el programa detecta error en la consulta de sede le arroja un mensaje de error, sino realiza el proceso correspondiente
                        if (numero1 > nuevo.getnumSedes()) {
                            
                            System.out.println("ERROR. Esta sede no existe");
                            
                        } else {
                            
                            sede = nuevo.consultarSede(numero1 - 1);
         

                            if (sede.getnumCuentas() == 0) {
                                
                                System.out.println("");
                           
                                System.out.println("Disculpe. Esta sede no posee ninguna cuenta bancaria");
                                
                            } else {
                                
                                System.out.println("Porfavor ingrese la cuenta a consultar: ");
                                
                                numero1 = nueva.nextInt();
                          

                                if (numero1 > sede.getnumCuentas()) {
                                    
                                    System.out.println("Lo sentimos. Esta cuenta no existe");
                                    
                                } else {
                                    
                                    cuenta = sede.consultarCuenta(numero1 - 1);
                                    System.out.println("");
                                    System.out.println("Solicitud de Informacion de la cuenta aceptada.");
                                    System.out.println("INFORMACION DE LA CUENTA: ");
                                    System.out.println("");
                                    System.out.println("Numero de cuenta registrado: " + cuenta.getnumCuenta());
                                    System.out.println("Tipo de cuenta: " + cuenta.gettipoCuenta());
                                    System.out.println("Saldo inicial de la cuenta: " + cuenta.getsaldoInicial());

                                    User titular = cuenta.consultarUser();
                                    System.out.println("");
                                    System.out.println("INFORMACION DEL TITULAR: ");
                                    System.out.println("Nombre del titular de la cuenta: " + titular.getnombre() + " " + titular.getapellido());
                                    System.out.println("N° de identificacion: " + titular.getcedula());
                                    System.out.println("Sexo: " + titular.getsexo());
                                    
                                    }
                                    }
                                    }
                                    }
                    
                    break;

                case 6:
                    
                    //si la persona opta por salir, le mandamos un mensaje de despedida
                    
                    System.out.println("LE AGRADECEMOS EL USO DE NUESTROS SERVICIOS, ESPERAMOS VERLO PRONTO.");
                    System.out.println("");
                    
                    break;

                default:
                    
                    System.out.println("Lo sentimos, el numero de opcion digitado es incorrecto, porfavor digite uno valido.");
                    
            }
            }
            }
            }
