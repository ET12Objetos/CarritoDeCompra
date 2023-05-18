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

        foreach (Articulo articulo in articulos)
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
}