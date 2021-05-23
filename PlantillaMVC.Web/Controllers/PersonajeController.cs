using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantillaMVC.Web.Controllers
{
    public class PersonajeController
    {
        public IActionResult Index()
            => View(Repositorio.Personajes);

        [HttpPost]
        public IActionResult PersonajeAdd(Personaje personaje)
        {
            Repositorio.AgregarPersonaje(personaje);
            return View("PersonajeList", Repositorio.Personajes);
        }
        public ViewResult PersonajeList() => View(Repositorio.Personajes);
    }
}
