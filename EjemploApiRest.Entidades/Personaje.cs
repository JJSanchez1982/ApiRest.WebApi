using System;

namespace EjemploApiRest.Entidades
{
    public class Personaje : Entity
    {
        public string Nombre { get; set; }

        public string Edad { get; set; }
        
        public string Peso { get; set; }
        
        public string Historia { get; set; }
        
        public string ImagenPersonaje { get; set; }
        
        public string PelioSerieAsociada { get; set; }
    }
}
