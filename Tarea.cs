namespace RescursosTareas;

public class Tarea {
    private int tareaID;
    private string descripcion;
    private int duracion;
    private Estado estado;

    public Tarea(int tareaID, string descripcion, int duracion)
    {
        this.TareaID = tareaID;
        this.Descripcion = descripcion;
        this.Duracion = duracion;
        estado = Estado.Pendiente;
    }

    public int TareaID { get => tareaID; set => tareaID = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }

    public void cambiarEstado() {
        if (estado == Estado.Pendiente) {
            estado = Estado.Realizada;
        } else {
            estado = Estado.Pendiente;
        }
    }
    public void mostrarTarea() {
        Console.WriteLine("\nID: " + TareaID);
        Console.WriteLine("Descripción: " + Descripcion);
        Console.WriteLine("Duración: " + Duracion);
        Console.WriteLine("Estado: " + estado);       
    }
}

public enum Estado {
    Pendiente,
    Realizada,
}

