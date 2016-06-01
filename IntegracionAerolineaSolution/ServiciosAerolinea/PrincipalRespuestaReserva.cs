using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosAerolinea
{
    public class PrincipalRespuestaReserva
    {
        private Boolean estado;
        private Int32 num_reserva;
        private String mensaje_error;

        public bool Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public int Num_reserva
        {
            get
            {
                return num_reserva;
            }

            set
            {
                num_reserva = value;
            }
        }

        public string Mensaje_error
        {
            get
            {
                return mensaje_error;
            }

            set
            {
                mensaje_error = value;
            }
        }
    }
}
