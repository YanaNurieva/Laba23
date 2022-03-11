using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Configuration;
namespace WpfLabaTsi
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            if (logBox.Text != string.Empty && pasBox.Text != string.Empty)
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnect"].ConnectionString))
                {
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand command = new SqlCommand("INSERT Users VALUES (@login, @password, 'User')", connection);
                        command.Parameters.AddRange(new SqlParameter[]
                        {
                        new SqlParameter("@login", logBox.Text),
                        new SqlParameter("@password", pasBox.Text)
                        });
                        command.ExecuteNonQuery();
                    }
                }
                MainWindow registrationWindow = new MainWindow();
                registrationWindow.Show();
                Owner = registrationWindow;
                Close();
            }
            
        }
    }
}
