using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NETDEMO.Models;

namespace NETDEMO.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var model = new Categoria();
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }


    public IActionResult MostrarPeliculas(string categoriaP)
    {
        var viewModel = new Categoria();
        viewModel.CategoriaSeleccionada = categoriaP; 

        ViewData["mensaje"] = "Bienvenido(a), estas son nuestras películas disponibles:";

        switch (categoriaP)
        {
            case "Acción":
                viewModel.Peliculas.Add(new Pelicula { Titulo = "Jurassic World Rebirth (2025)" });
                viewModel.Peliculas.Add(new Pelicula { Titulo = "Cómo entrenar a tu dragón (2025)" });
                viewModel.Peliculas.Add(new Pelicula { Titulo = "Carnicería nocturna" });
                break;

            case "Animación":
                viewModel.Peliculas.Add(new Pelicula { Titulo = "Demon Slayer: Kimetsu no Yaiba Infinity Castle (2025)" });
                viewModel.Peliculas.Add(new Pelicula { Titulo = "Spider-Man: Beyond the Spider-Verse" });
                viewModel.Peliculas.Add(new Pelicula { Titulo = "KPop Demon Hunters (2025)" });
                break;

            case "Terror":
                viewModel.Peliculas.Add(new Pelicula { Titulo = "Final Destination Bloodlines" });
                viewModel.Peliculas.Add(new Pelicula { Titulo = "28 Years Later" });
                viewModel.Peliculas.Add(new Pelicula { Titulo = "Weapons" });
                break;
        }

        return View("Index", viewModel);
    }

    public IActionResult Formulario()
    {
        return View();
    }

    public IActionResult Agradecimiento()
    {
        return View();
    }

    public IActionResult RegistroPelicula(Pelicula pelicula)
    {
        return RedirectToAction("Agradecimiento");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
