using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantillaMVC.Web.Models
{
    public class Repositorio
    {
        private static List<Tecnica> tecnicas = new List<Tecnica>();
        public static IEnumerable<Tecnica> Tecnicas => tecnicas;
        public static void AgregarTecnica(Tecnica tecnica) => tecnicas.Add(tecnica);

        private static List<Personaje> personajes = new List<Personaje>();
        public static IEnumerable<Personaje> Personajes => personajes;
        public static void AgregarPersonaje(Personaje personaje) => personajes.Add(personaje);
    }
}
