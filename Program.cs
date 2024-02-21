using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Metadata;

namespace Tarea2;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al Menú:");
            Console.WriteLine("1. Estructuras condicionales");
            Console.WriteLine("2. Switch");
            Console.WriteLine("3. Salir");

            Console.Write("Por favor, seleccione una opción: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Ha seleccionado la opción 1");{


                    // NUNERO MAYOR.

                    try
                    {
                        Console.WriteLine("Ingrese el primer número:");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingrese el segundo número:");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingrese el tercer número:");
                        int num3 = Convert.ToInt32(Console.ReadLine());

                        int mayor = NumMayor(num1, num2, num3);
                        Console.WriteLine($"El mayor de los tres números es: {mayor}");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Por favor, ingrese solo números enteros.");
                    }
                

                static int NumMayor(int a, int b, int c)
                {
                    int mayor = a;
                    if (b > mayor)
                        mayor = b;
                    if (c > mayor)
                        mayor = c;
                    return mayor;
                }
                Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("Ha seleccionado la opción 1");{


                    // INGRESO A CLUB

                    try
                    {
                        Console.WriteLine("\n\nINGRESO A CLUB\nIngrese su año de nacimiento:");
                        int yearOfBirth = Convert.ToInt32(Console.ReadLine());
                        bool esMayorDeEdad = EsMayorDeEdad(yearOfBirth);

                        if (esMayorDeEdad)
                        Console.WriteLine("Eres mayor de edad puedes ingresar.");
                        else
                        Console.WriteLine("Eres menor de edad no puedes ingresar.");

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("ingrese solo números enteros.");
                    }
                }

                static bool EsMayorDeEdad(int yearOfBirth)
                    {
                        int currentYear = DateTime.Now.Year;

                        int edad = currentYear - yearOfBirth;

                        return edad >= 18;
                    }
                    Console.ReadLine(); // Espera para que el usuario vea el resultado

                    Console.Clear();
                    Console.WriteLine("Ha seleccionado la opción 1");{

                    // PRECIO FINAL

                    try
                    {
                        Console.WriteLine("\n\nIngrese precio del producto");
                        decimal precio = Convert.ToDecimal(Console.ReadLine());
                        
                        decimal preciof = Descuento(precio);
                        Console.WriteLine($"El precio final es de: Q{preciof.ToString("f2")}");
                
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("ingrese un precio válido.");
                    }

                static decimal Descuento(decimal precio)
                    {

                        decimal Descuento = 0;

                        if (precio > 100)
                        {
                            Descuento = precio * 0.1m;
                        }

                        decimal preciof = precio - Descuento;
                        return preciof;
                    }
                    
                    Console.ReadLine(); // Espera para que el usuario vea el resultado
                    }
                    
                    Console.Clear();
                    Console.WriteLine("Ha seleccionado la opción 1");{

                    // USUARIO Y CONTRASEÑA
                   
                    try
                    {
                        Console.WriteLine("\n\n LOG IN\nIngrese usuario:");
                        string usuario = Console.ReadLine();
                        Console.WriteLine("\nIngrese contraseña:");
                        string contraseña = Console.ReadLine();

                        if (ValidarCredenciales(usuario,contraseña))
                        {
                            Console.WriteLine("ACCESO CONCEDIDO");
                            Console.ReadLine(); // Espera para que el usuario vea el resultado
                        }
                        else
                        {
                            Console.WriteLine("USUARIO O CONTRASEÑA INCORRECTA, ACCESO DENEGADO");
                            Console.ReadLine(); // Espera para que el usuario vea el resultado
                        }
                    
                    }

                    catch
                    {
                            Console.WriteLine("Por favor, ingrese un valor válido.");
                    }

                static bool ValidarCredenciales(string usuario,string contraseña)
                {
                    return usuario == "admin" && contraseña =="1234";
                }
                    }
                    Console.Clear();
                    Console.WriteLine("Ha seleccionado la opción 1");{

                    // NUMERO PAR

                    try
                    {
                        Console.WriteLine("\nIngrese un numero:");
                        int num4 = Convert.ToInt32(Console.ReadLine());
                        
                        bool numpar = Numdiv2(num4);

                    if(numpar)
                    {
                        Console.WriteLine("El numero ingresado es par.");
                        Console.ReadLine(); // Espera para que el usuario vea el resultado
                    }
                    else
                    {
                        Console.WriteLine("El numero ingresado no es par.");
                        Console.ReadLine(); // Espera para que el usuario vea el resultado
                    }

                    }

                    catch (FormatException)
                    {
                        Console.WriteLine("Por favor, ingrese un numero valido.");
                    }
                
                static bool Numdiv2(int num4)
                {
                    try
                    {
                        if ( num4 % 2 ==0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                        // En caso de cualquier excepción, devuelve false
                        return false;
                    }
                }   

                    }

                    Console.Clear();
                    Console.WriteLine("Ha seleccionado la opción 1");
                    {

                        //prestamo

                    try
                    {
                        Console.WriteLine("\n\nPRESTAMO\nIngrese monto solicitado:");
                        decimal cantpres = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("\nIngrese año de nacimiento:");
                        int añonac = Convert.ToInt32(Console.ReadLine());

                        if (Sipres(cantpres, añonac))
                        {
                            Console.WriteLine("Préstamo aprobado.");
                            Console.ReadLine(); // Espera para que el usuario vea el resultado
                        }
                        else
                        {
                            Console.WriteLine("Préstamo no aprobado.");
                            Console.ReadLine(); // Espera para que el usuario vea el resultado
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Por favor, ingrese valores numéricos válidos.");
                    }
                    }
                static bool Sipres(decimal cantpres, int añonac)
                {
                    if (cantpres < 5000 || añonac > 60)

                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
                    Console.Clear();
                    Console.WriteLine("Ha seleccionado la opción 1");

                    // AREA DE FIGURA GEOMETRICA

                    {
                    try
                        {
                            Console.WriteLine("Ingrese el tipo de figura geométrica (triángulo, cuadrado o círculo):");
                            string tipoFigura = Console.ReadLine().ToLower(); 

                            double area = 0;

                            switch (tipoFigura)
                            {
                                case "triangulo":
                                    Console.WriteLine("Ingrese la base del triángulo:");
                                    double baseTriangulo = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("Ingrese la altura del triángulo:");
                                    double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

                                    area = CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);
                                    break;
                                case "cuadrado":
                                    Console.WriteLine("Ingrese el lado del cuadrado:");
                                    double ladoCuadrado = Convert.ToDouble(Console.ReadLine());

                                    area = CalcularAreaCuadrado(ladoCuadrado);
                                    break;
                                case "circulo":
                                    Console.WriteLine("Ingrese el radio del círculo:");
                                    double radioCirculo = Convert.ToDouble(Console.ReadLine());

                                    area = CalcularAreaCirculo(radioCirculo);
                                    break;
                                default:
                                    Console.WriteLine("Tipo de figura no reconocido.");
                                    return; // Salir del programa si el tipo de figura no es reconocido
                            }

                            Console.WriteLine($"El área de la figura {tipoFigura} es: {area}");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Por favor, ingrese valores numéricos válidos.");
                        }
                    }

                    static double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
                    {
                        return (baseTriangulo * alturaTriangulo) / 2;
                    }

                    static double CalcularAreaCuadrado(double ladoCuadrado)
                    {
                        return ladoCuadrado * ladoCuadrado;
                    }

                    static double CalcularAreaCirculo(double radioCirculo)
                    {
                        return Math.PI * radioCirculo * radioCirculo;
                    }
                }
                        Console.ReadLine(); // Espera para que el usuario vea el resultado
    
                    break;
            
                case "2":
                    Console.Clear();
                    Console.WriteLine("Ha seleccionado la opción 2");
                    // PALABRA A NUMERO.
                    {
                    
                    try
                    {
                        Console.WriteLine("Ingrese un número del 1 al 5 en letra:");
                        string numeroLetra = Console.ReadLine().ToLower(); 
                        int numero;

                        switch (numeroLetra)
                        {
                            case "uno":
                                numero = 1;
                                break;
                            case "dos":
                                numero = 2;
                                break;
                            case "tres":
                                numero = 3;
                                break;
                            case "cuatro":
                                numero = 4;
                                break;
                            case "cinco":
                                numero = 5;
                                break;
                            default:
                                Console.WriteLine("Número no reconocido.");
                                return; // Salir del programa si el número no es reconocido
                        }

                        Console.WriteLine($"El número en dígito es: {numero}");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Por favor, ingrese un valor válido.");
                    }
                }
                        Console.ReadLine(); // Espera para que el usuario vea el resultado

                    Console.Clear();
                    Console.WriteLine("Ha seleccionado la opción 2");
                    // PALABRA A NUMERO.
                    {

                    try
                    {
                        Console.WriteLine("Ingrese un número del 1 al 7:");
                        int numero = Convert.ToInt32(Console.ReadLine());

                        string diaSemana = ObtenerDiaSemana(numero);

                        Console.WriteLine($"El día de la semana correspondiente es: {diaSemana}");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Por favor, ingrese un número válido.");
                    }
                }

                static string ObtenerDiaSemana(int numero)
                {
                    switch (numero)
                    {
                        case 1:
                            return "Lunes";
                        case 2:
                            return "Martes";
                        case 3:
                            return "Miércoles";
                        case 4:
                            return "Jueves";
                        case 5:
                            return "Viernes";
                        case 6:
                            return "Sábado";
                        case 7:
                            return "Domingo";
                        default:
                            return "Número fuera de rango";
                    }
                    }
                        Console.ReadLine(); // Espera para que el usuario vea el resultado

                    Console.Clear();
                    Console.WriteLine("Ha seleccionado la opción 2");
                    // TIPO DE SERVICIO.
                {
                    try
                    {
                        Console.WriteLine("Ingrese el tipo de servicio (lavado de auto, cambio de aceite, revisión mecánica):");
                        string tipoServicio = Console.ReadLine().ToLower();

                        decimal importePagar = CalcularImporte(tipoServicio);

                        if (importePagar >= 0)
                        {
                            Console.WriteLine($"El importe a pagar por {tipoServicio} es: Q{importePagar:N2}");
                            Console.ReadLine(); // Espera para que el usuario vea el resultado
                        }
                        else
                        {
                            Console.WriteLine("Tipo de servicio no reconocido.");
                            Console.ReadLine(); // Espera para que el usuario vea el resultado
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }

                static decimal CalcularImporte(string tipoServicio)
                {
                    switch (tipoServicio)
                    {
                        case "lavado de auto":
                            return 50.00m;
                        case "cambio de aceite":
                            return 280.00m;
                        case "revisión mecánica":
                            return 150.00m;
                        default:
                            return -1;
                    }
                }

                 Console.Clear();
                    Console.WriteLine("Ha seleccionado la opción 2");
                    // BIENVENIDA IDIOMA
                    {
                    try
                    {
                        Console.WriteLine("Ingrese su idioma de preferencia (español, inglés, francés):");
                        string idioma = Console.ReadLine().ToLower(); 
                        MostrarMensajeBienvenida(idioma);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }

                static void MostrarMensajeBienvenida(string idioma)
                {
                    switch (idioma)
                    {
                        case "español":
                            Console.WriteLine("¡Bienvenido!");
                            Console.ReadLine(); // Espera para que el usuario vea el resultado
                            break;
                        case "ingles":
                            Console.WriteLine("Welcome!");
                            Console.ReadLine(); // Espera para que el usuario vea el resultado
                            break;
                        case "frances":
                            Console.WriteLine("Bienvenue!");
                            Console.ReadLine(); // Espera para que el usuario vea el resultado
                            break;
                        default:
                            Console.WriteLine("Idioma no reconocido.");
                            Console.ReadLine(); // Espera para que el usuario vea el resultado
                            break;
                    }
                }
                
                    Console.Clear();
                    Console.WriteLine("Ha seleccionado la opción 2");
                    // EVALUAR CALIFICACION

                    {
                        
                    try
                    {
                        Console.WriteLine("Ingrese la nota de su examen:");
                        int califi = Convert.ToInt32(Console.ReadLine());

                        string mensaje;

                        switch (califi)
                        {
                            case int n when (n >= 90 && n <= 100):
                                mensaje = "Sobresaliente";
                                break;
                            case int n when (n >= 80 && n <= 89):
                                mensaje = "Notable";
                                break;
                            case int n when (n >= 70 && n <= 79):
                                mensaje = "Aprobatoria";
                                break;
                            case int n when (n >= 60 && n <= 69):
                                mensaje = "No aprobatoria";
                                break;
                            case int n when (n < 61):
                                mensaje = "Nota minima para aprobar 61 puntos";
                                break;
                            default:
                                mensaje = "Error: Calificación no válida.";
                                break;
                        }
                            Console.WriteLine($"Mensaje: {mensaje}");
                            Console.ReadLine();

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Por favor, ingrese una calificación válida.");
                    }
                    }               
                    break;

                case "3":
                    Console.WriteLine("Saliendo del programa...");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    Console.ReadLine(); // Espera para que el usuario vea el mensaje de error
                    break;

            }
        }            
    }
}


