using ACCESODATOS;
using DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICANEGOCIO
{
    public class RESERVANEGOCIO
    {
        private readonly RESERVA _reservasDatos;

        public RESERVANEGOCIO()
        {
            _reservasDatos = new RESERVA();
        }

        public List<Reservas> ObtenerReservas()
        {
            return _reservasDatos.ObtenerReservas();
        }

        public void AgregarReserva(Reservas reserva)
        {
            _reservasDatos.AgregarReserva(reserva);
        }

        // Implementa los demás métodos según sea necesario
    }

}
