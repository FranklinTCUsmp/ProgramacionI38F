using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosApp.Models.Entidades
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public string Foto { get; set; }
    }
}