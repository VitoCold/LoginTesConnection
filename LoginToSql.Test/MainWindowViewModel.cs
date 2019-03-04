using LoginToSql.DA;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LoginToSql.Test
{
   public class MainWindowViewModel:ObservableObject
    {

        private bool _Conexion = false;

        public bool Conexion
        {
            get { return _Conexion; }
            set { SetProperty(ref _Conexion, value); }
        }

        Timer _timer;

        public MainWindowViewModel()
        {
            _timer = new Timer { Interval = 1000, AutoReset = true };

            _timer.Start();
            _timer.Elapsed += TimerElapsed;
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            TestConnectionSQL test = new TestConnectionSQL();
            Conexion = test.GetConnection();
        }
    }
}
