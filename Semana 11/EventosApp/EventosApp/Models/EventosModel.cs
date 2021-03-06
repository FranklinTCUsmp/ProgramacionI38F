﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventosApp.Models
{
    public class EventosModel
    {
        public List<Evento> ListadoEventos()
        {
            var contexto = new EventosAppEntities();

            var eventos = contexto.Eventos.Where(e => e.FechaInicio >= DateTime.Now).ToList();

            return eventos;
        }

        public Evento GetEventoPorId(int id)
        {
            var contexto = new EventosAppEntities();

            var evento = contexto.Eventos.FirstOrDefault(e => e.Id == id);

            return evento;
        }
    }
}