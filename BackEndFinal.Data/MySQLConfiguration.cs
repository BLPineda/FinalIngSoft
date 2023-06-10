using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndFinal.Data
{
    public class MySQLConfiguration
    {
        public MySQLConfiguration(string conexionString) { 
        
            ConexionString = conexionString;
        }
        public string ConexionString { get; set; }
    }
}
