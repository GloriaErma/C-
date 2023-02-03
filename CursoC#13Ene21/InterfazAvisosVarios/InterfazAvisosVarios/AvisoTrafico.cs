using System;
using System.Collections.Generic;
using System.Text;

namespace InterfazAvisosVarios
{
    class AvisoTrafico : IAvisos
    {
        // CONTRUCTOR X DEFECTO
        public AvisoTrafico()
        {
            remitente = "DGT";
            mensaje = "SANCIÓN COMETIDA";
            fecha = "";
        }
        // CONTRUCTOR PARÁMETROS
        public AvisoTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }
        public string GetFecha() => fecha;

        public void MostrarAviso()
        {
            Console.WriteLine("Mensje {0} ha sido enviado por {1} el día {2}", mensaje,remitente,fecha );
        }
        private string remitente;
        private string mensaje;
        private string fecha;
    }
}
