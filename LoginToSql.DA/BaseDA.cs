using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LoginToSql.DA
{
    public class BaseDA
    {
        public string GetConnectionStrings
        {
            get { return ConfigurationManager.ConnectionStrings["LoginToSqlDbContext"]
                        .ConnectionString;
            }
        }


    }
}
