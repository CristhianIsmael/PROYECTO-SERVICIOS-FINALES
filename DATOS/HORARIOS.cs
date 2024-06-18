using ACCESODATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class HORARIOS : IDATOS<Horarios>
    {
        private TacServicios _contexto = new TacServicios();

        public HORARIOS()
        {
            _contexto = new TacServicios();
        }

        public List<Horarios> Listar()
        {
            return _contexto.Horarios.ToList();
        }

        // Implementación explícita del método Listar() de la interfaz IDATOS<Horarios>

        // Métodos no implementados de la interfaz IDATOS<Horarios>
        bool IDATOS<Horarios>.Nuevo(Horarios item)
        {
            throw new NotImplementedException();
        }

        bool IDATOS<Horarios>.Actualizar(Horarios item)
        {
            throw new NotImplementedException();
        }

        bool IDATOS<Horarios>.Eliminar(Horarios item)
        {
            throw new NotImplementedException();
        }
    }
}
