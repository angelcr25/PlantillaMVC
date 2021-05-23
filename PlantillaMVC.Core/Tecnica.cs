using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantillaMVC.Core
{
    public class Tecnica
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Tecnica> Tecnicas { get; set; }
    }
}
