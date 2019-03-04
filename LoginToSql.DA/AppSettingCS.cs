using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginToSql.DA
{
    public class AppSettingCS
    {
        Configuration config;

        public AppSettingCS()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public string ObtenerActualConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }

        public void GuardarNuevoConnectionString(string key,string nuevoCnx)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = nuevoCnx;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
