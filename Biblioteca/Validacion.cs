namespace Biblioteca;
public static class Validacion
{
    public static void ValidarRango(int valor, string mensajeError)
    {
        if (valor <= 0)
            throw new Exception(mensajeError);
    }

    public static void ValidarRango(double valor, string mensajeError)
    {
        if (valor <= 0)
            throw new Exception(mensajeError);
    }

    public static void ValidarCadena(string cadena, string mensajeError)
    {
        if (string.IsNullOrEmpty(cadena))
            throw new Exception(mensajeError);
    }
}