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

    public void SetNombre(string nombre)
    {
        this.Nombre = nombre;
    }

    public void SetDescripcion(string descripcion)
    {
        this.Descripcion = descripcion;
    }

    public void SetPrecio(double precio)
    {
        this.Precio = precio;
    }
}
