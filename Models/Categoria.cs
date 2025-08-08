
namespace NETDEMO.Models;

public class Categoria

{

    public string? CategoriaSeleccionada { get; set; }


    public List<Pelicula> Peliculas { get; set; }

    public Categoria()
        {
            Peliculas = new List<Pelicula>();
        }

}