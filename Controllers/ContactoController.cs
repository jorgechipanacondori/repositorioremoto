using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using calculadoramvc.Models;
using calculadoramvc.Data;

namespace calculadoramvc.Controllers
{
    public class ContactoController : Controller
    {

       private readonly ILogger<ContactoController> _logger;
       private readonly DatabaseContext _context;


        public ContactoController(ILogger<ContactoController> logger,
            DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Contacto objContacto){
            if (ModelState.IsValid)
            {
                _context.Add(objContacto);
                _context.SaveChanges();
                objContacto.Response = "Gracias estamos en contacto";
            }
            return View("index", objContacto);
        }

    }
}