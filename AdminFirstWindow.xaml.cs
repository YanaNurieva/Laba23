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
using System.Collections.ObjectModel;
using System.Configuration;

namespace WpfLabaTsi
{
    /// <summary>
    /// Логика взаимодействия для AdminFirstWindow.xaml
    /// </summary>
    public partial class AdminFirstWindow : Window
    {
        public AdminFirstWindow()
        {
            InitializeComponent();
            AppUsers.ItemsSource = MyListCheck();
            
        }
        class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
            public User(int id, string name,string pasword, string role)
            {
                Id = id;
                Name = name;
                Password = pasword;
                Role = role;
            }
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button btn && ChangeRoleBox.Text != string.Empty)
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnect"].ConnectionString))
                {
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand command = new SqlCommand("Update Users Set Role = @role WHERE Id = @id", connection);
                        command.Parameters.AddRange(new SqlParameter[] { new SqlParameter ("@role", btn.Content), new SqlParameter("@id", ChangeRoleBox.Text) });
                        command.ExecuteNonQuery();
                        MessageBox.Show("Роль изменена");
                        AppUsers.ItemsSource = MyListCheck();
                    }

                }
            }
        }

        private ObservableCollection<User> MyListCheck()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnect"].ConnectionString))
            {
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand command = new SqlCommand("Select * FROM Users", connection);
                    Task<SqlDataReader> task = command.ExecuteReaderAsync();
                    SqlDataReader dataReader = task.Result;
                    if (dataReader.HasRows)
                    {
                        ObservableCollection<User> users = new ObservableCollection<User>();
                        while (dataReader.Read())
                        {
                            users.Add(new User(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3)));
                        }
                        return users;
                    }  
                }
                return default;
            }
        }

        private void ChangeRoleBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.Background = new SolidColorBrush();
        }

        private void ChangeRoleBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (ChangeRoleBox.Text == string.Empty)    
                ChangeRoleBox.Background = new ImageBrush(new BitmapImage(new Uri(@"E:\VsProjects\WpfLabaTsi\img\placeholder.PNG", UriKind.Absolute))) { Stretch = Stretch.UniformToFill};
            
        }
    }
}
