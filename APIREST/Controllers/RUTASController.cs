using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using ACCESODATOS;
using LOGICANEGOCIO;
using DTOS;

namespace APIREST.Controllers
{
    public class RUTASController : ApiController
    {
        private readonly RUTASNEGOCIO _rutasNegocio;

        public RUTASController()
        {
            _rutasNegocio = new RUTASNEGOCIO();
        }

        // GET: api/Rutas
        [System.Web.Http.HttpGet]
        public IHttpActionResult Get()
        {
            var rutas = _rutasNegocio.ObtenerRutas();
            var rutasDTO = rutas.Select(ruta => new RutasDTO
            {
                ID_Ruta = ruta.ID_Ruta,
                Origen = ruta.Origen,
                Destino = ruta.Destino,
                Distancia = ruta.Distancia,
                Duracion_Estimada = ruta.Duracion_Estimada
            }).ToList();

            return Ok(rutasDTO);
        }
    }
}
