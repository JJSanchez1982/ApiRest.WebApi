using EjemploApiRest.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploApiRest.Entidades
{
    public abstract class Entity : IEntity
    {
        public int id { get; set; }
    }
}
