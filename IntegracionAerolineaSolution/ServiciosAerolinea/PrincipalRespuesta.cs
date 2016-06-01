using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosAerolinea
{
    public class PrincipalRespuesta
    {
        private Int32 codigo_vuelo;
        private Int32 codigo_aerolinea;
        private String nombre_aerolinea;
        private Decimal cotizacion;

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

        public int Codigo_aerolinea
        {
            get
            {
                return codigo_aerolinea;
            }

            set
            {
                codigo_aerolinea = value;
            }
        }

        public string Nombre_aerolinea
        {
            get
            {
                return nombre_aerolinea;
            }

            set
            {
                nombre_aerolinea = value;
            }
        }

        public decimal Cotizacion
        {
            get
            {
                return cotizacion;
            }

            set
            {
                cotizacion = value;
            }
        }

        public PrincipalRespuesta() {
        }

        
    }
}
