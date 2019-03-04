using System.Security;
using System.Threading.Tasks;
using System.Windows;

namespace LoginToSql.Test
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
            LoginControl.Content = new LoginView();
        }

      
    }
}
