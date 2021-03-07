using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlantillaMVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PlantillaMVC.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View("Index");

        public IActionResult TecnicaAdd()
        {
            List<Personaje> personajes = Repositorio.Personajes.ToList();
            ViewBag.Personajes = personajes;
            return View("TecnicaAdd");
        }

        public IActionResult PersonajeAdd() => View("PersonajeAdd");

        [HttpPost]
        public IActionResult PersonajeAdd(Personaje personaje)
        {
            Repositorio.AgregarPersonaje(personaje);
            return View("PersonajeList", Repositorio.Personajes);
        }

        [HttpPost]
        public IActionResult TecnicaAdd(Tecnica tecnica)
        {
            Repositorio.AgregarTecnica(tecnica);
            return View("TecnicaList", Repositorio.Tecnicas);
        }

        public ViewResult TecnicaList() => View(Repositorio.Tecnicas);
        public ViewResult PersonajeList() => View(Repositorio.Personajes);
    }
}
