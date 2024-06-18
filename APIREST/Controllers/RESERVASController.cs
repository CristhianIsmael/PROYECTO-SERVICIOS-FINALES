using ACCESODATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using DTOS;
using LOGICANEGOCIO;

namespace APIREST.Controllers
{
    public class ReservasController : ApiController
    {
        private readonly RESERVANEGOCIO _reservasNegocio;

        public ReservasController()
        {
            _reservasNegocio = new RESERVANEGOCIO();
        }

        // GET: api/Reservas
        [System.Web.Http.HttpGet]
        public IHttpActionResult Get()
        {
            var reservas = _reservasNegocio.ObtenerReservas();
            var reservasDTO = reservas.Select(reserva => new RESERVADTO
            {
                ID_Reserva = reserva.ID_Reserva,
                ID_Horario = (int)reserva.ID_Horario,
                ID_Pasajero = (int)reserva.ID_Pasajero,
                Numero_Asientos_Reservados = (int)reserva.Numero_Asientos_Reservados,
                Estado_Reserva = reserva.Estado_Reserva,
                Fecha_Reserva = (DateTime)reserva.Fecha_Reserva
            }).ToList();

            return Ok(reservasDTO);
        }

        // POST: api/Reservas
        [System.Web.Http.HttpPost]
        public IHttpActionResult Post(RESERVADTO reservaDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var reserva = new Reservas
            {
                ID_Horario = reservaDTO.ID_Horario,
                ID_Pasajero = reservaDTO.ID_Pasajero,
                Numero_Asientos_Reservados = reservaDTO.Numero_Asientos_Reservados,
                Estado_Reserva = reservaDTO.Estado_Reserva,
                Fecha_Reserva = reservaDTO.Fecha_Reserva
            };

            _reservasNegocio.AgregarReserva(reserva);

            return CreatedAtRoute("DefaultApi", new { id = reserva.ID_Reserva }, reservaDTO);
        }
    }
}
