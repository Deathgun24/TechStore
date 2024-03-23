using Microsoft.AspNetCore.Mvc;
using TechStore.Models;


namespace TechStore.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ILogger<ProductoController> _logger;

        public ProductoController(ILogger<ProductoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Nombre,Descripcion,Precio")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                double precioIgv = (double)producto.Precio;
                precioIgv = precioIgv * 1.18;


                ViewData["Message"] = "El costo del producto con IGV es de" + precioIgv;

                return View("Index");
            }
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}