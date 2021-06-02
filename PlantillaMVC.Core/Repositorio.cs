using System;
using System.Collections.Generic;
using System.Text;

namespace PlantillaMVC.Core
{
    public class Repositorio
    {
        static int idPersonaje = 1;
        static int idTecnica = 1;

        private static List<Personaje> personajes = new List<Personaje>();
        public static IEnumerable<Personaje> Personajes => personajes;

        public static void AgregarPersonaje(Personaje personaje)
        {
            personaje.Id = idPersonaje++;
            personajes.Add(personaje);
        }

        public static void EliminarPersonaje(Personaje personaje)
        => personajes.RemoveAll(c => c.Id == personaje.Id);


        private static List<Tecnica> tecnicas = new List<Tecnica>();

        public static IEnumerable<Tecnica> Tecnicas => tecnicas;

        public static Tecnica Getenica(int id)
                    => tecnicas.Find(c => c.Id == id);
        public static void AgregarTecnica(Tecnica tecnica)
        {
            tecnica.Id = idTecnica++;
            tecnicas.Add(tecnica);
        }
        public static void EliminarTecnica(Tecnica tecnica)
         => tecnicas.RemoveAll(c => c.Id == tecnica.Id);
    }
}
