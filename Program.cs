// See https://aka.ms/new-console-template for more information
using RescursosTareas;

List<Tarea> listaTareas = new List<Tarea>();

string [] descripciones = new string[5];
descripciones[0] = "realizar tp de taller";
descripciones[1] = "estudiar algoritmos";
descripciones[2] = "practicar metodos numericos";
descripciones[3] = "terminar tp de matematica discreta";
descripciones[4] = "corregir circuito";

Console.WriteLine("Ingrese el número de tareas a crear\n");
string cantIngresada = Console.ReadLine();
Int32.TryParse(cantIngresada, out int N);

for (int i=0; i<N; i++) {
    Random random = new Random();
    string descripcionAleatoria = descripciones[random.Next(5)];
    int duracionAleatoria = 10 + random.Next(91);
    Tarea miTarea = new Tarea(i+1, descripcionAleatoria, duracionAleatoria);
    listaTareas.Add(miTarea);
}

Console.WriteLine("\nLas tareas creadas son:");
foreach (Tarea tarea in listaTareas) {
    tarea.mostrarTarea();
    
}
