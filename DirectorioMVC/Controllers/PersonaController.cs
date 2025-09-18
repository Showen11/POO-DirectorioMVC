using Microsoft.AspNetCore.Mvc;
using DirectorioMVC.Models;



namespace DirectorioMVC.Controllers
{
    public class PersonaController : Controller
    {
        Persona myPersona = new Persona("Jose", "Morazan");
        
        public IActionResult Index()
        {
            return View(myPersona);
        }
    }
}
