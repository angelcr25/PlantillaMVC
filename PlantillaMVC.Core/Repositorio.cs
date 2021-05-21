using System;
using System.Collections.Generic;
using System.Text;

namespace PlantillaMVC.Core
{
    class Repositorio
    {
        static int idPersonaje = 1;
        static int idJutsu = 1;

        private static List<Personaje> personajes = new List<Personaje>();
        public static IEnumerable<Personaje> Personajes => personajes;
        public static void AgregarPersonaje(Personaje personaje)
        {
            personaje.Id = idPersonaje++;
        }


        private static List<Jutsu> jutsus = new List<Jutsu>();

        public static IEnumerable<Jutsu> Jutsus => jutsus;

        public static Jutsu GetJutsu(int id)
                    => jutsus.Find(c => c.Id == id);
        public static void AgregarJutsu(Jutsu jutsu)
        {
            jutsu.Id = idJutsu++;
            jutsus.Add(jutsu);
        }
        public static void EliminarJutsu(Jutsu jutsu)
            => jutsus.RemoveAll(c => c.Id == jutsu.Id);
    }
}
