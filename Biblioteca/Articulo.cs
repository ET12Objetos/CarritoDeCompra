namespace Biblioteca;

public class Articulo
{
    public string Nombre { get; private set; }
    public string Descripcion { get; private set; }
    public double Precio { get; private set; }

    public Articulo(string nombre, string descripcion, double precio)
    {
        Validacion.ValidarCadena(nombre, "El nombre del articulo es incorrecto");
        this.Nombre = nombre;
        Validacion.ValidarCadena(descripcion, "La descripcion del articulo es incorrecta");
        this.Descripcion = descripcion;
        Validacion.ValidarRango(precio, "El precio es incorrecto");
        this.Precio = precio;
    }
}
