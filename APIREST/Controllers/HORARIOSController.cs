using ACCESODATOS;
using DTOS;
using LOGICANEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace APIREST.Controllers
{
    public class HORARIOSController : ApiController
    {
        private readonly HORARIOSNEGOCIO _horariosNegocio;

        public HORARIOSController()
        {
            _horariosNegocio = new HORARIOSNEGOCIO();
        }

        // GET: api/Horarios
        [HttpGet]
        public IHttpActionResult Get()
        {
            var horarios = _horariosNegocio.ObtenerHorarios();
            var horariosDTO = horarios.Select(horario => new HORARIODTOS
            {
                ID_Horario = horario.ID_Horario,
                ID_Ruta = (int)horario.ID_Ruta,
                ID_Bus = horario.ID_Bus ?? 0, // Conversion explícita
                ID_Conductor = horario.ID_Conductor ?? 0, // Conversion explícita
                Dia_Semana = horario.Dia_Semana,
                Hora_Salida = horario.Hora_Salida ?? TimeSpan.Zero, // Conversion explícita
                Hora_Llegada = horario.Hora_Llegada ?? TimeSpan.Zero // Conversion explícita
            }).ToList();

            return Ok(horariosDTO);
        }
    }
}
