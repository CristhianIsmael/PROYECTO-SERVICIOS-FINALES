using ACCESODATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICANEGOCIO
{
    public class RUTASNEGOCIO
    {
        private readonly DATOS.RUTAS _rutasDatos;

        public RUTASNEGOCIO()
        {
            _rutasDatos = new DATOS.RUTAS();
        }

        public List<Rutas> ObtenerRutas()
        {
            return _rutasDatos.ObtenerRutas();
        }

    }
}
