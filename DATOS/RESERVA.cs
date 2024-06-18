using ACCESODATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class RESERVA : IDATOS<RESERVA>
    {
        private TacServicios _contexto = new TacServicios();

        public RESERVA()
        {
            _contexto = new TacServicios();
        }

        public List<Reservas> ObtenerReservas()
        {
            return _contexto.Reservas.ToList();
        }

        public void AgregarReserva(Reservas reserva)
        {
            _contexto.Reservas.Add(reserva);
            _contexto.SaveChanges();
        }

        public List<RESERVA> Listar()
        {
            throw new NotImplementedException();
        }

        public bool Nuevo(RESERVA item)
        {
            throw new NotImplementedException();
        }

        public bool Actualizar(RESERVA item)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(RESERVA item)
        {
            throw new NotImplementedException();
        }
    }
}
