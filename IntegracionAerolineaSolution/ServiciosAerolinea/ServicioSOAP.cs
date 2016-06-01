using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiciosAerolinea.AerolineaTWS;

namespace ServiciosAerolinea
{
    public class ServicioSOAP
    {
        private ConsultaPWS objTAME= new ConsultaPWS();

        public List<PrincipalRespuesta> consultar(PrincipalPeticion objP) {
            
            List<consultaPasajeRespuesta> respuestas = new List<consultaPasajeRespuesta>();
            List<PrincipalRespuesta> cotizacionesAerolineas = new List<PrincipalRespuesta>();

            respuestas = objTAME.consultaP(castPrincipalPeticionToConsultaPasaje(objP)).ToList();

            foreach(consultaPasajeRespuesta objAux in respuestas)
            {
                cotizacionesAerolineas.Add(castTAMEtoPrincipalRespuesta(objAux,objP,1,"TAME"));
            }

            return cotizacionesAerolineas;
            
        }

        public PrincipalRespuesta castTAMEtoPrincipalRespuesta(consultaPasajeRespuesta objPR,PrincipalPeticion objPP,int cod_aerolinea,String nombre_aerolinea)
        {
            Decimal costo = 0;
            PrincipalRespuesta aux = new PrincipalRespuesta();
            aux.Codigo_vuelo = objPR.codigoVuelo;
            costo = objPR.costoAsiento * objPP.Total_asientos;
            aux.Cotizacion = costo;
            aux.Codigo_aerolinea = cod_aerolinea;
            aux.Nombre_aerolinea = nombre_aerolinea;            
            return aux;
        }

        public consultaPasajePeticion castPrincipalPeticionToConsultaPasaje(PrincipalPeticion objP)
        {
            consultaPasajePeticion aux = new consultaPasajePeticion();
            aux.destino = objP.Destino;
            aux.fechaRetorno = objP.Fecha_retorno;
            aux.fechaSalida = objP.Fecha_salida;
            aux.origen = objP.Origen;
            aux.totalAsientos = objP.Total_asientos;
            return aux;
        }

    }
}
