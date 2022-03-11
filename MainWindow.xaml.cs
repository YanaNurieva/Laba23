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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 
        }

        private void Button_ClickSignIn(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnect"].ConnectionString))
            {
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand command = new SqlCommand("Select * FROM Users WHERE Login = @login AND Password = @password", connection);
                    command.Parameters.AddRange(new SqlParameter[]
                    {
                        new SqlParameter("@login", LogBox.Text),
                        new SqlParameter("@password",PasBox.Password)
                    });
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        string role = string.Empty;
                        while (dataReader.Read())
                        {
                            role = dataReader["Role"].ToString();
                        }
                        
                        if (role.ToUpper() == "USER")
                        {
                            FirstWindow firstWindow = new FirstWindow();
                            firstWindow.Show();
                            firstWindow.SetUser(LogBox.Text);
                            Close();
                        }
                        if (role.ToUpper() == "ADMIN")
                        {
                            AdminFirstWindow adminFirstWindow = new AdminFirstWindow();
                            adminFirstWindow.Show();
                            Owner = adminFirstWindow;
                            Close();
                        }
                        
                    }
                    else
                        MessageBox.Show("Пользователь не найден", "Вход");
                }
            }
        }

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow =  new RegistrationWindow();
            registrationWindow.Show();
            Owner = registrationWindow;
            Close();
        }
    }
}
