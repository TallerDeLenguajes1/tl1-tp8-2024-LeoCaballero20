namespace EspacioCalculadora;

public class Calculadora {
    private double dato;
    public Calculadora() {
        dato = 0;
    }
    public double Resultado {
        get => dato;
    }
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
}