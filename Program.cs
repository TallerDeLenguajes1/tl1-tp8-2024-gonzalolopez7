int opcion;
double termino;
bool b;
var nuevaCalculadora = new Calculadora();

do
{
    
    Console.WriteLine("\n-. dato = " + nuevaCalculadora.Resultado);
    Console.WriteLine("1. suma");
    Console.WriteLine("2. resta");
    Console.WriteLine("3. multiplicacion");
    Console.WriteLine("4. division");
    Console.WriteLine("5. limpiar");
    Console.WriteLine("6. historial de operaciones");
    Console.WriteLine("7. salir");

    b = int.TryParse(Console.ReadLine(), out opcion) && opcion < 8 && opcion > 0;
    if (b)
    {



        switch (opcion)
        {
            case 1:
                termino = pedirTermino();
                nuevaCalculadora.Sumar(termino);
                break;

            case 2:
                termino = pedirTermino();
                nuevaCalculadora.Restar(termino);
                break;

            case 3:
                termino = pedirTermino();
                nuevaCalculadora.Multiplicar(termino);
                break;

            case 4:
                termino = pedirTermino();
                nuevaCalculadora.Dividir(termino);
                break;
            
            case 5:
                nuevaCalculadora.Limpiar();
                break;

            case 6:
                foreach (var operacion in nuevaCalculadora.Operaciones)
                {
                    System.Console.WriteLine("- resultado: " + operacion.ResultadoAnterior + " | operacion: " + operacion.GetOperacion + " | nuevo valor: " + operacion.NuevoValor);
                }
                break;

            default:
                break;
        }

    } else 
    {
        Console.WriteLine("opcion no valida");
    }

} while (opcion != 7);

static double pedirTermino() {

    bool b; double termino;

    do
        {

            Console.WriteLine("\ningresar un numero: ");
            b = double.TryParse(Console.ReadLine(), out termino);
            if (!b)
            {
                Console.WriteLine("numero no valido");
            }

        } while (!b);

    return termino;
}