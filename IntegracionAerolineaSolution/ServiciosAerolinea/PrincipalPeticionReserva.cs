using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosAerolinea
{
    public class PrincipalPeticionReserva
    {
        private Int32 codigo_vuelo;
        private Int32 numero_pasajeros;

        public int Codigo_vuelo
        {
            get
            {
                return codigo_vuelo;
            }

            set
            {
                codigo_vuelo = value;
            }
        }

        public int Numero_pasajeros
        {
            get
            {
                return numero_pasajeros;
            }

            set
            {
                numero_pasajeros = value;
            }
        }
    }
}
