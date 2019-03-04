using LoginToSql.DA;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LoginToSql.Test
{
    public class LoginViewModel:ObservableObject
    {
        //public string UnsecurePass { get; set; }

        public ICommand ProbarConexionCommand { get; private set; }
        public ICommand GuardarConexionCommand { get; private set; }

        public LoginViewModel()
        {
            ProbarConexionCommand = new RelayCommand2(onProbar);
            GuardarConexionCommand = new RelayCommand2(onGuardar);
        }

        private void onGuardar(object param)
        {
            var test = new TestConnectionSQL();

            var pass = param as PasswordBox;
            var UnsecurePass = pass.Password;

            try
            {
                var connectionString = string.Format("Data Source=DESKTOP-PSEELEV\\VDELGADO;Initial Catalog = AdventureWorksDW2014; User ID = sa; Password = {0};", UnsecurePass);
                if (test.GetNewConnection(connectionString))
                {
                    var set = new AppSettingCS();

                    set.GuardarNuevoConnectionString("LoginToSqlDbContext", connectionString);

                    MessageBox.Show("Clave guardada","Mensaje",MessageBoxButton.OK,MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Clave no guardada","Mensaje",MessageBoxButton.OK,MessageBoxImage.Warning);
                }
            }
            catch (SqlException)
            {

            }
        }

        private void onProbar(object param)
        {
            var test = new TestConnectionSQL();

            var pass = param as PasswordBox;
            var UnsecurePass = pass.Password;

            try
            {
                var connectionString = string.Format("Data Source=DESKTOP-PSEELEV\\VDELGADO;Initial Catalog = AdventureWorksDW2014; User ID = sa; Password = {0};", UnsecurePass);
                if (test.GetNewConnection(connectionString))
                {
                    MessageBox.Show("Conexión exitosa");
                }
                else
                {
                    MessageBox.Show("Conexión no establecida");
                }
            }
            catch (SqlException)
            {
               
            }
        }


    }
}
