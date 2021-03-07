using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantillaMVC.Web.Models
{
    public class Personaje
    {
        public string nombre { get; set; }
        public List<Tecnica> Tecnicas { get; set; }
    }
}
