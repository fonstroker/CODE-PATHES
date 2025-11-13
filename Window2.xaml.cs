using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Linq;

namespace Приложение
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            MaxHeight = 495;
            MaxWidth = 400;
            MinHeight = 495;
            MinWidth = 400;
        }
        private void Variables_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Window3 newWin = new Window3();
                this.Close();
                newWin.ShowDialog();
                this.Show();
            }
            catch { }
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow newWin = new MainWindow();
                this.Close();
                newWin.ShowDialog();
                this.Show();
            }
            catch  { }
        }
        public string[] InfoProg()
        {
            const string usersFilePath1 = "progress.txt";
            const string OnlineWorker = "OnlineWorker.txt";
            List<string> lines = new List<string>();
            string loginToFind = File.ReadAllText(OnlineWorker).Trim();
            // Считываем все строки из файла в лист строк
            using (StreamReader reader = new StreamReader(usersFilePath1))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            string[] results = new string[8];
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].StartsWith(loginToFind))
                {
                    string line = lines[i];
                    string[] parts = line.Split(',');
                    for (int j = 0; j < 8; j++)
                    {
                        results[j] = parts[j + 1].Trim();
                    }
                    break;
                }
            }
            return results;
        }
        private void InstrumWork_Click(object sender, RoutedEventArgs e)
        {
            string [] a = InfoProg();
            if (a[0] != "0")  
            {
                Window5 newwin = new Window5();
                this.Close();
                newwin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пройдите предыдущие уровни!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        const string pathAvatarFile = "avatarkes.txt";
        const string OnlineWorker = "OnlineWorker.txt";
        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            string login = File.ReadAllText(OnlineWorker).Trim();
            string[] lines = File.ReadAllLines(pathAvatarFile);

            bool userFound = false;

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts[0] == login)
                {
                    userFound = true;
                    Window6 newwin = new Window6();
                    this.Close();
                    newwin.ShowDialog();
                    break; // Выходим из цикла, т.к. пользователь найден
                }
            }
            if (!userFound)
            {
                using (StreamWriter writer = File.AppendText(pathAvatarFile))
                {
                    writer.WriteLine(login + ", " + "NulAvatarka.png");
                }

                Window6 newwin = new Window6();
                this.Close();
                newwin.ShowDialog();
            }
        }
        private void Operations_Click(object sender, RoutedEventArgs e)
        {
            string[] a = InfoProg();
            if (a[1] != "0")
            {
                Window8 newwin = new Window8();
                this.Close();
                newwin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пройдите предыдущие уровни!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Mass_Click(object sender, RoutedEventArgs e)
        {
            string[] a = InfoProg();
            if (a[2] != "0")
            {
                Window10 newwin = new Window10();
                this.Close();
                newwin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пройдите предыдущие уровни!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Function_Click(object sender, RoutedEventArgs e)
        {
            string[] a = InfoProg();
            if (a[3] != "0")
            {
                Window12 newwin = new Window12();
                this.Close();
                newwin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пройдите предыдущие уровни!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Faile_Click(object sender, RoutedEventArgs e)
        {
            string[] a = InfoProg();
            if (a[4] != "0")
            {
                Window14 newwin = new Window14();
                this.Close();
                newwin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пройдите предыдущие уровни!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ListL_Click(object sender, RoutedEventArgs e)
        {
            string[] a = InfoProg();
            if (a[5] != "0")
            {
                Window16 newwin = new Window16();
                this.Close();
                newwin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пройдите предыдущие уровни!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void tryW_Click(object sender, RoutedEventArgs e)
        {
            string[] a = InfoProg();
            if (a[6] != "0")
            {
                Window18 newwin = new Window18();
                this.Close();
                newwin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пройдите предыдущие уровни!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
