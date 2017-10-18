using EventosApp.Models.Entidades;
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
            var lista = new List<Evento>();

            lista.Add(new Evento
            {
                Id = 1,
                Nombre = "Partido Repechaje",
                FechaInicio = new DateTime(2017, 11, 15),
                Foto = "https://cde.peru.com/ima/0/1/7/1/8/1718692/611x458/peru.jpg"
            });

            lista.Add(new Evento
            {
                Id = 2,
                Nombre = "Miaustura",
                FechaInicio = new DateTime(2017, 11, 15),
                Foto = "https://img.peru21.pe/files/article_content_ec_fotos/uploads/2017/09/20/59c28ba453b9c.jpeg"
            });

            return lista;
        }
    }
}