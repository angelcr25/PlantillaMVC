﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PlantillaMVC.Web.Controllers
{
    public class TecnicaController : Controller
    {
        public IActionResult Index()
            => View(Repositorio.Tecnicas);

        [HttpPost]
        public IActionResult TecnicaAdd(Jutsu tecnica)
        {
            Repositorio.AgregarTecnica(tecnica);
            return View("TecnicaList", Repositorio.Jutsus);
        }
        public ViewResult TecnicaList() => View(Repositorio.Tecnicas);
    }
}
