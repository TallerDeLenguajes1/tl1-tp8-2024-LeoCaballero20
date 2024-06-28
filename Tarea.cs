namespace RecursosTareas;

public class Tarea {
    private int tareaID;
    private string descripcion;
    private int duracion;
    private Estado estado;
    public Tarea(int tarID, string descr, int dur)
    {
        tareaID = tarID;
        descripcion = descr;
        duracion = dur;
        Estado = Estado.Pendiente;
    }
    public int TareaID { get => tareaID; set => tareaID = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }
    public Estado Estado { get => estado; set => estado = value; }

    public void cambiarEstado() {
        if (Estado == Estado.Pendiente) {
            Estado = Estado.Realizada;
        } else {
            Estado = Estado.Pendiente;
        }
    }
    public void mostrarTarea() {
        Console.WriteLine("\nID: " + TareaID);
        Console.WriteLine("Descripción: " + Descripcion);
        Console.WriteLine("Duración: " + Duracion);
        Console.WriteLine("Estado: " + Estado);       
    }
}

public enum Estado {
    Pendiente,
    Realizada,
}

