using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosAerolinea
{
    public class PrincipalPeticion
    {
        private DateTime fecha_salida;
        private DateTime fecha_retorno;
        private Int32 total_asientos;
        private String origen;
        private String destino;

        public PrincipalPeticion() {

        }

        public DateTime Fecha_salida
        {
            get
            {
                return fecha_salida;
            }

            set
            {
                fecha_salida = value;
            }
        }

        public DateTime Fecha_retorno
        {
            get
            {
                return fecha_retorno;
            }

            set
            {
                fecha_retorno = value;
            }
        }

        public int Total_asientos
        {
            get
            {
                return total_asientos;
            }

            set
            {
                total_asientos = value;
            }
        }

        public string Origen
        {
            get
            {
                return origen;
            }

            set
            {
                origen = value;
            }
        }

        public string Destino
        {
            get
            {
                return destino;
            }

            set
            {
                destino = value;
            }
        }
    }
}
