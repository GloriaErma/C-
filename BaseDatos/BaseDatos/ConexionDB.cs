using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//agregar using;
using System.Data.OracleClient;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using Microsoft.Extensions.Configuration;

namespace BaseDatos
{
    public class ConexionDB
    {
        // GECS para aceder a la configuracion appSettings.json
        // inyectar interface IConfiguration 
        // string conexionstring= ConfigurationManager.ConnectionStrings
        private readonly IConfiguration _config;
        // GECS variable con suficiente alcance se define a nivel de class NO dentro de metodo.
        private static string coneStr;
        private static string otroPar;

        // GECS inyectar IConfiguration por parametro en constructor clase ConexionDB
        public ConexionDB(IConfiguration config)
        {
            _config = config;
        }

        // GECS acceder a los metodos de configuracion, dentro de un metodo de clase
        // GetSection, GetConnectionString, GetReloadToken
        public void ObtenerSetting()
        {
            var     otroPar = _config.GetSection("OtroParametro").Value;
            string  coneStr  = _config.GetSection("ConnectionStrings:ModelContext").Value;
        }

            OracleConnection ora = new OracleConnection(coneStr);
       
    }
}
