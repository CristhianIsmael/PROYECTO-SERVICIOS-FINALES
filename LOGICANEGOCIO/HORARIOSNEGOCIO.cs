using ACCESODATOS;
using DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICANEGOCIO
{
    public class HORARIOSNEGOCIO
    {
        private readonly IDATOS<Horarios> _horariosDatos;
        public HORARIOSNEGOCIO()
        {
            _horariosDatos = new HORARIOS();
        }

        public List<Horarios> ObtenerHorarios()
        {
            return _horariosDatos.Listar();
        }
    }
}
