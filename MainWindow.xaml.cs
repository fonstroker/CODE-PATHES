using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Приложение
{   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            Autorization.Visibility = Visibility.Visible;
            Registration.Visibility = Visibility.Hidden;
            RegistrationVis.Visibility = Visibility.Visible;
            NameLab.Visibility = Visibility.Hidden;
            Name.Visibility = Visibility.Hidden;
            Back.Visibility = Visibility.Hidden;
            Name.TextChanged += Name_TextChanged;
            LoginA.TextChanged += LoginA_TextChanged;
            PassA.TextChanged += PassA_TextChanged;
        }
        class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Name { get; set; }
            public string Progres { get; set; }
        }
        class FileManager
        {
            private const string usersFilePath = "users.txt";
            private const string usersFilePath1 = "progress.txt";
            private const string OnlineWorker = "OnlineWorker.txt";
            public void OnlineW(string login)
            {
                if (File.Exists(usersFilePath1))
                {
                    string[] lines = File.ReadAllLines(OnlineWorker);
                }
                File.Create(OnlineWorker).Close();
                using (StreamWriter writer = File.AppendText(OnlineWorker))
                {                  
                    writer.WriteLine(login);
                }
            }
            public bool RegisterUser(string login, string password, string name)
            {
                if (File.Exists(usersFilePath))
                {
                    string[] lines = File.ReadAllLines(usersFilePath);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3 && parts[0] == login)
                        {
                            return false;
                        }
                    }
                }
                using (StreamWriter writer = File.AppendText(usersFilePath))
                {
                    writer.WriteLine(login+","+password+","+name);
                }
                using (StreamWriter writer = File.AppendText(usersFilePath1))
                {
                    writer.WriteLine(login + ", 0, 0, 0, 0, 0, 0, 0, 0");
                }
                return true;
            }
            public bool AuthenticateUser(string login, string password)
            {
                if (File.Exists(usersFilePath))
                {
                    string[] lines = File.ReadAllLines(usersFilePath);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3 && parts[0] == login && parts[1] == password)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }
        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if ((LoginA.Text == "" || LoginA.Text == " ") || (PassA.Text == "" || PassA.Text == " ")) 
            {
                MessageBox.Show("Заполните все поля!");
            }
            else { 
            string login = LoginA.Text;
            string password = PassA.Text;
            FileManager fileManager = new FileManager();
            bool isAuthenticated = fileManager.AuthenticateUser(login, password);               
            if (isAuthenticated)
            {
                    fileManager.OnlineW(login);

                    try
                    {
                        Window2 newWin = new Window2();
                        this.Close();
                        newWin.ShowDialog();
                        this.Show();                        
                    }
                    catch { }
                }
                else
            {
                MessageBox.Show("Ошибка аутентификации.");
            }
        }
        }
        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            if ((LoginA.Text == "" || LoginA.Text == " ") || (PassA.Text == "" || PassA.Text == " ") || (Name.Text == "" || Name.Text == " "))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                string login = LoginA.Text;
                string password = PassA.Text;
                string name = Name.Text;
                FileManager fileManager = new FileManager();
                bool isRegistered = fileManager.RegisterUser(login, password, name);
 //               fileManager.RegisterProgress(login);
                if (isRegistered)
                {
                    MessageBox.Show("Пользователь зарегистрирован.");
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!");
                }
            }
        }
        private void RegistrationVis_Click(object sender, RoutedEventArgs e)
        {
            Autorization.Visibility = Visibility.Hidden;
            Registration.Visibility = Visibility.Visible;
            RegistrationVis.Visibility = Visibility.Hidden;
            NameLab.Visibility = Visibility.Visible;
            Name.Visibility = Visibility.Visible;
            Back.Visibility = Visibility.Visible;
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Autorization.Visibility = Visibility.Visible;
            Registration.Visibility = Visibility.Hidden;
            RegistrationVis.Visibility = Visibility.Visible;
            NameLab.Visibility = Visibility.Hidden;
            Name.Visibility = Visibility.Hidden;
            Back.Visibility = Visibility.Hidden;
        }
        private void Close_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;

            // Удаляем все недопустимые символы
            textBox.Text = Regex.Replace(text, @"[^0-9A-Za-zА-Яа-я]", "");
        }
        private void LoginA_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;

            // Удаляем все недопустимые символы
            textBox.Text = Regex.Replace(text, @"[^0-9A-Za-zА-Яа-я]", "");
        }
        private void PassA_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;

            // Удаляем все недопустимые символы
            textBox.Text = Regex.Replace(text, @"[^0-9A-Za-zА-Яа-я]", "");
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
