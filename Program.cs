using RecursosTareas;

List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();

string[] descripciones = new string[5];
descripciones[0] = "realizar tp de taller";
descripciones[1] = "estudiar algoritmos";
descripciones[2] = "practicar metodos numericos";
descripciones[3] = "terminar tp de matematica discreta";
descripciones[4] = "corregir circuito";

Console.WriteLine("Ingrese el número de tareas a crear\n");
string cantIngresada = Console.ReadLine();
Int32.TryParse(cantIngresada, out int N);

for (int i = 0; i < N; i++)
{
    Random random = new Random();
    string descripcionAleatoria = descripciones[random.Next(5)];
    int duracionAleatoria = 10 + random.Next(91);
    Tarea miTarea = new Tarea(i + 1, descripcionAleatoria, duracionAleatoria);
    tareasPendientes.Add(miTarea);
}

mostrarTareas(tareasPendientes);

int seguir = 1;
do
{
    Console.WriteLine("\nInserte el ID de la tarea que quiere marcar como realizada (inserte 0 para salir): ");
    string numIngresado = Console.ReadLine();
    Int32.TryParse(numIngresado, out int num);
    if (num != 0)
    {
        foreach (var tarea in tareasPendientes)
        {
        if (tarea.TareaID == num) {
            tarea.cambiarEstado();
            tareasRealizadas.Add(tarea);
            tareasPendientes.Remove(tarea);
            break;
        } 
        }
    }
    else
    {
        seguir = 0;
        Console.WriteLine("\nLas tareas pendientes son: ");
        mostrarTareas(tareasPendientes);
        Console.WriteLine("\nLas tareas realizadas son: ");
        mostrarTareas(tareasRealizadas);
    }
} while (seguir == 1);

void mostrarTareas(List<Tarea> listaTareas)
{
    foreach (Tarea tarea in listaTareas)
    {
        tarea.mostrarTarea();
    }
}


Console.WriteLine("\nInserte una descripción para buscar una tarea pendiente (inserte 'salir' para terminar búsqueda):");
string descrip = Console.ReadLine();
List<Tarea> tareasEncontradas = new List<Tarea>();
foreach (Tarea t in tareasPendientes) {
    if (t.Descripcion.Contains(descrip)) {
        tareasEncontradas.Add(t);
    }
}
Console.WriteLine("\nTareas coincidentes:");
mostrarTareas(tareasEncontradas);