using ACCESODATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class RUTAS : IDATOS<Rutas>
    {
        private readonly TacServicios _contexto;

        public RUTAS()
        {
            _contexto = new TacServicios();
        }

        public List<Rutas> ObtenerRutas()
        {
            return _contexto.Rutas.ToList();
        }

        // Implementar otros métodos según sea necesario

        public List<Rutas> Listar()
        {
            return ObtenerRutas();
        }

        public bool Nuevo(Rutas item)
        {
            throw new NotImplementedException();
        }

        public bool Actualizar(Rutas item)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Rutas item)
        {
            throw new NotImplementedException();
        }
    }

}
