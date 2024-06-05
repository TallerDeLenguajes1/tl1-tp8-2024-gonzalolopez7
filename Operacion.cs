public class Operacion
{
    
    double resultadoAnterior;
    double nuevoValor;
    TipoOperacion operacion;

    public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
    {
        
        this.resultadoAnterior = resultadoAnterior;
        this.nuevoValor = nuevoValor;
        this.operacion = operacion;

    }

    public double ResultadoAnterior { get => resultadoAnterior; }
    public double NuevoValor { get => nuevoValor; }
    public TipoOperacion GetOperacion { get => operacion; }
    
}

