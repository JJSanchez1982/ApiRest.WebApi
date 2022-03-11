using EjemploApi.Rest.Applicationm;
using EjemploApiRest.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploApiRest.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonajeController : ControllerBase
    {
        IApplication<Personaje> _personaje;

        public PersonajeController(IApplication<Personaje> personaje)
        {
            _personaje = personaje;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personaje.GetAll());

        }

        [HttpPost]
        public IActionResult Save(PersonajeDTO dto)
        {
            var p = new Personaje()
            {
                Nombre = dto.Nombre,
                Edad = dto.Edad,
                Peso = dto.Peso,
                Historia = dto.Historia,
                PelioSerieAsociada = dto.PelioSerieAsociada,
                ImagenPersonaje = dto.ImagenPersonaje
            };
            return Ok(_personaje.Save(p));
        }

        
    }
      
}
