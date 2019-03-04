using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LoginToSql.DA
{
    public class TestConnectionSQL:BaseDA
    {
        SqlConnection Cnx;

        public TestConnectionSQL()
        {
            Cnx = new SqlConnection(GetConnectionStrings);
        }

        public bool GetConnection()
        {
                try
                {
                    if (Cnx.State == ConnectionState.Closed)
                    {
                        Cnx.Open();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (SqlException)
                {
                    return false;
                }
        }

        public bool GetNewConnection(string GetNewCnx)
        {
           var NewCnx = new SqlConnection(GetNewCnx);

            try
            {
                if (NewCnx.State == ConnectionState.Closed)
                    NewCnx.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
