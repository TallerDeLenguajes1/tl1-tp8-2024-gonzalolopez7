public class Calculadora {

    // campos

    private double dato;
    private List<Operacion> operaciones = new List<Operacion>();

    // propiedades

    public double Resultado { get => dato; }
    public List<Operacion> Operaciones { get => operaciones; }

    // metodos

    public void Sumar(double termino) {

        Operaciones.Add(new Operacion(dato, dato+termino, TipoOperacion.Suma));
        dato += termino;
    }

    public void Restar(double termino) {

        Operaciones.Add(new Operacion(dato, dato-termino, TipoOperacion.Resta));
        dato -= termino;
    }

    public void Multiplicar(double termino) {

        Operaciones.Add(new Operacion(dato, dato*termino, TipoOperacion.Multiplicacion));
        dato *= termino;
    }

    public void Dividir(double termino) {

        Operaciones.Add(new Operacion(dato, dato/termino, TipoOperacion.Division));
        dato /= termino;
    }

    public void Limpiar() {

        Operaciones.Add(new Operacion(dato, 0, TipoOperacion.Limpiar));
        dato = 0;
    }

}
