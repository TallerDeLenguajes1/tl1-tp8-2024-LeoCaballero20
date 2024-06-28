namespace EspacioCalculadora;

public class Calculadora {
    private double dato;
    private List<Operacion> historial;
    public Calculadora() {
        dato = 0;
        historial = new List<Operacion>();
    }
    public double Resultado {
        get => dato;
    }
    public List<Operacion> Historial { get => historial; }

    public void Sumar (double Termino) {
        dato = dato + Termino;
    }
    public void Restar (double Termino) {
        dato = dato - Termino;
    }
    public void Multiplicar (double Termino) {
        dato = dato * Termino;
    }
    public void Dividir (double Termino) {
        dato = dato / Termino;
    }
    public void Limpiar () {
        dato = 0;
    }
    public void verHistorial() {
        Console.WriteLine("\nHISTORIAL");
        foreach (Operacion op in Historial) {
            op.mostrarOperacion();
        }
        Console.WriteLine("\nValor actual en la calculadora: " + dato);
    }
}

public class Operacion {
    private double resultadoAnterior;
    private double nuevoValor;
    private TipoOperacion operacion;

    public double Resultado { get => resultadoAnterior; }
    public double NuevoValor { get => nuevoValor; }
    public Operacion(double ant, double nuevo, TipoOperacion op) {
        resultadoAnterior = ant;
        nuevoValor = nuevo;
        operacion = op;
    }
    public void mostrarOperacion() {
        Console.WriteLine("\nResultado anterior: " + resultadoAnterior);
        Console.WriteLine("Nuevo valor: " + nuevoValor);
        Console.WriteLine("Tipo de operación: " + operacion);
    }
}


public enum TipoOperacion{
    Suma,
    Resta,
    Multiplicacion,
    Division,
    Limpiar
}
