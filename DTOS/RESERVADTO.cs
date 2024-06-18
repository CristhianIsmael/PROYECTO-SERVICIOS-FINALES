using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOS
{
    public class RESERVADTO
    {
        public int ID_Reserva { get; set; }
        public int ID_Horario { get; set; }
        public int ID_Pasajero { get; set; }
        public int Numero_Asientos_Reservados { get; set; }
        public string Estado_Reserva { get; set; }
        public DateTime Fecha_Reserva { get; set; }

    }
}
