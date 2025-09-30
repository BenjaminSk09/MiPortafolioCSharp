using System;

class Program
{
    static void Main(string[] args)
    { //Mensaje de bienvenida
        Console.WriteLine("bienvenido");

        //Declaracion de variables
        string PrimerNumero, SegundoNumero;
        double Numero1, Numero2, Resultado;
        bool Continuar = true;

        while (Continuar)
        {
            Console.Clear();
            //Menu  
            Console.WriteLine("Seleccione la operacion que desea realizar");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Salir");

            String SeleccionOp = Console.ReadLine();
            int SeleccionOperacion = Convert.ToInt32(SeleccionOp);

            if (SeleccionOperacion == 5)
            {
                Continuar = false; // Esto termina el bucle
                continue;           // Pasa a la siguiente iteración del while (no hace operaciones)
            }

            //Segun la operacion seleccionada se realiza la operacion
            switch (SeleccionOperacion)

            {
                case 1:
                    //mensaje para ingresar los numeros
                    Console.WriteLine("Ingrese un primer numero");
                    PrimerNumero = Console.ReadLine();
                    Numero1 = Convert.ToDouble(PrimerNumero);
                    //mensaje para ingresar los numeros
                    Console.WriteLine("Ingrese un Segundo numero");
                    SegundoNumero = Console.ReadLine();
                    Numero2 = Convert.ToDouble(SegundoNumero);

                    //Suma
                    Resultado = Numero1 + Numero2;
                    Console.WriteLine("el resultado de la suma es: " + Resultado);
                    Console.WriteLine("Presiona Enter para volver al menú...");
                    Console.ReadLine();
                    break;

                case 2:
                    //mensaje para ingresar los numeros
                    Console.WriteLine("Ingrese un primer numero");
                    PrimerNumero = Console.ReadLine();
                    Numero1 = Convert.ToDouble(PrimerNumero);
                    //mensaje para ingresar los numeros
                    Console.WriteLine("Ingrese un Segundo numero");
                    SegundoNumero = Console.ReadLine();
                    Numero2 = Convert.ToDouble(SegundoNumero);

                    //Resta
                    Resultado = Numero1 - Numero2;
                    Console.WriteLine("el resultado de la resta es: " + Resultado);
                    Console.WriteLine("Presiona Enter para volver al menú...");
                    Console.ReadLine();
                    break;

                case 3:
                    //mensaje para ingresar los numeros
                    Console.WriteLine("Ingrese un primer numero");
                    PrimerNumero = Console.ReadLine();
                    Numero1 = Convert.ToDouble(PrimerNumero);
                    //mensaje para ingresar los numeros
                    Console.WriteLine("Ingrese un Segundo numero");
                    SegundoNumero = Console.ReadLine();
                    Numero2 = Convert.ToDouble(SegundoNumero);

                    //Multiplicacion
                    Resultado = Numero1 * Numero2;
                    Console.WriteLine("el resultado de la Multiplicacion es: " + Resultado);
                    Console.WriteLine("Presiona Enter para volver al menú...");
                    Console.ReadLine();
                    break;

                case 4:
                    //mensaje para ingresar los numeros
                    Console.WriteLine("Ingrese un primer numero");
                    PrimerNumero = Console.ReadLine();
                    Numero1 = Convert.ToDouble(PrimerNumero);
                    //mensaje para ingresar los numeros
                    Console.WriteLine("Ingrese un Segundo numero");
                    SegundoNumero = Console.ReadLine();
                    Numero2 = Convert.ToDouble(SegundoNumero);

                    if (Numero2 == 0)
                    {
                        Console.WriteLine("Error: No se puede Dividir por cero.");
                        Console.WriteLine("Presiona Enter para volver al menú...");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        //Division
                        Resultado = Numero1 / Numero2;
                        Console.WriteLine("el resultado de la Division es: " + Resultado);
                        Console.WriteLine("Presiona Enter para volver al menú...");
                        Console.ReadLine();
                        break;
                    }

                default:
                    Console.WriteLine("Operacion no valida");
                    break;
            }

        }

        Console.WriteLine("Presiona Enter para cerrar la calculadora...");
        Console.ReadLine();


    }


}

