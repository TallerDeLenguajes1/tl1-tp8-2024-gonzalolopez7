
Tarea[] tareas = {
    new Tarea(1, "descripcion 1", 90),
    new Tarea(2, "descripcion 2", 60),
    new Tarea(3, "descripcion 3", 30),
    new Tarea(4, "descripcion 4", 45),
    new Tarea(5, "descripcion 5", 120)
};

var tareasPendientes = new List<Tarea>();
var tareasRealizadas = new List<Tarea>();

foreach (var tarea in tareas)
{
    tareasPendientes.Add(tarea);
}

int opcion;
bool b;

do
{
    
    Console.WriteLine("\n1. marcar tarea realizada");
    Console.WriteLine("2. buscar tareas pendientes por descripcion");
    Console.WriteLine("3. mostrar tareas");
    Console.WriteLine("4. salir");
    b = int.TryParse(Console.ReadLine(), out opcion) && opcion < 5 && opcion > 0;
    if (b)
    {
        
        if (opcion == 1)
        {
            
            moverTarea(tareasPendientes, tareasRealizadas);

        }
        else if (opcion == 2)
        {
            buscarTarea(tareasPendientes);

        }
        else if (opcion == 3)
        {
            mostrarTareas(tareasPendientes, tareasRealizadas);

            opcion = 3;
        }

    } else
    {
        Console.WriteLine("error");
    }

} while (opcion != 4);

static void moverTarea(List<Tarea> tareasPendientes, List<Tarea> tareasRealizadas)
{

    var tareaAMover = new Tarea();
    bool b; int id;

    do
    {

        Console.WriteLine("\ningresar id de tarea a marcar: ");
        b = int.TryParse(Console.ReadLine(), out id);
        if (b)
        {

            b = false;
            foreach (var tarea in tareasPendientes)
            {
                if (tarea.TareaID == id)
                {
                    tareaAMover = tarea;
                    b = true;
                }
            }
            
            if (b)
            {
                tareasPendientes.Remove(tareaAMover);
                tareasRealizadas.Add(tareaAMover);
            } else
            {
                Console.WriteLine("no existe una tarea con el id ingresado");
                b = true;
            }

        }
        else
        {
            Console.WriteLine("error\n");
        }

    } while (!b);

}

static void buscarTarea(List<Tarea> tareasPendientes)
{
    Console.WriteLine("\ningresar descripcion: ");
    string descripcion = Console.ReadLine();
    bool b = false;
    foreach (var tarea in tareasPendientes)
    {
        if (tarea.Descripcion.Contains(descripcion))
        {

            Console.WriteLine("tarea encontrada");
            Console.WriteLine("id: " + tarea.TareaID + " - descripcion: " + tarea.Descripcion + " - duracion: " + tarea.Duracion);
            b = true;

        }
    }
    if (!b)
    {
        Console.WriteLine("no existe una tarea con la descripcion ingresada");
    }
}

static void mostrarTareas(List<Tarea> tareasPendientes, List<Tarea> tareasRealizadas)
{

    bool b; int opcion;
    do
    {
        
        Console.WriteLine("\n1. tareas pendientes");
        Console.WriteLine("2. tareas realizadas");
        b = int.TryParse(Console.ReadLine(), out opcion) && opcion < 3 && opcion > 0;
        if (b)
        {
            
            if (opcion == 1)
            {

                Console.WriteLine("\ntareas pendientes");
                foreach (var tarea in tareasPendientes)
                {
                    Console.WriteLine("- tarea id: " + tarea.TareaID + " | descripcion: \"" + tarea.Descripcion + "\" | duracion: " + tarea.Duracion);
                }

            }
            else if (opcion == 2)
            {

                Console.WriteLine("\ntareas realizadas");
                foreach (var tarea in tareasRealizadas)
                {
                    Console.WriteLine("- tarea id: " + tarea.TareaID + " | descripcion: \"" + tarea.Descripcion + "\" | duracion: " + tarea.Duracion);
                }

            }

        } else
        {
            Console.WriteLine("error");
        }

    } while (!b);
    
}