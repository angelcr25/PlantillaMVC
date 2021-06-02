using System;
using System.Collections.Generic;
using System.Text;

namespace PlantillaMVC.Core
{
    public class Personaje
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Tecnica> Tecnicas { get; set; }
    }
}
