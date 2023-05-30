using ConsoleTables;

namespace Biblioteca;
public class Carrito
{
    private List<Articulo> articulos;

    public Carrito()
    {
        this.articulos = new List<Articulo>();
    }

    public void AgregarUn(Articulo articulo)
    {
        this.articulos.Add(articulo);
    }

    public void Informar()
    {
        var tabla = new ConsoleTable("Nombre", "Descripcion", "Precio");

        foreach (Articulo articulo in articulos.OrderBy(articulo => articulo.Nombre))
        {
            tabla.AddRow(articulo.Nombre, articulo.Descripcion, $"$ {articulo.Precio}");
        }

        tabla.AddRow("", "Total", $"$ {this.Total()}");

        tabla.Write(Format.MarkDown);
    }

    public double Total()
    {
        return articulos.Sum(articulo => articulo.Precio);
    }

    public List<Articulo> Buscar(string nombre)
    {
        //Articulo articulo = articulos.Find(articulo => articulo.Nombre == nombre);
        var respuesta = articulos
            .Where(articulo => articulo.Nombre.ToUpper().Contains(nombre.ToUpper()));
        return respuesta.ToList();
    }

    public void Modificar(Articulo nuevo, string nombreArticulo)
    {
        Articulo articulo = articulos.First(articulo => articulo.Nombre == nombreArticulo);

        articulo.SetNombre(nuevo.Nombre);
        articulo.SetDescripcion(nuevo.Descripcion);
        articulo.SetPrecio(nuevo.Precio);
    }

    public void Borrar(string nombre)
    {
        Articulo articulo = Buscar(nombre).First();

        articulos.Remove(articulo);
    }
}