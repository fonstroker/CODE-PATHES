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

namespace Приложение
{
    /// <summary>
    /// Логика взаимодействия для Window17.xaml
    /// </summary>
    public partial class Window17 : Window
    {
        public Window17()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            MaxHeight = 495;
            MaxWidth = 500;
            MinHeight = 495;
            MinWidth = 500;
            Q1.IsReadOnly = true;
            Q2.IsReadOnly = true;
            Q3.IsReadOnly = true;
            Q4.IsReadOnly = true;
            A1.Visibility = Visibility.Hidden;
            A2.Visibility = Visibility.Hidden;
            A3.Visibility = Visibility.Hidden;
            A4.Visibility = Visibility.Hidden;
            Q1.Visibility = Visibility.Hidden;
            Q2.Visibility = Visibility.Hidden;
            Q3.Visibility = Visibility.Hidden;
            Q4.Visibility = Visibility.Hidden;
            Checked.Visibility = Visibility.Hidden;
        }
        private void StartT_Click(object sender, RoutedEventArgs e)
        {
            Checked.Visibility = Visibility.Visible;
            A1.Visibility = Visibility.Visible;
            A2.Visibility = Visibility.Visible;
            A3.Visibility = Visibility.Visible;
            A4.Visibility = Visibility.Visible;
            Q1.Visibility = Visibility.Visible;
            Q2.Visibility = Visibility.Visible;
            Q3.Visibility = Visibility.Visible;
            Q4.Visibility = Visibility.Visible;
            StartT.Visibility = Visibility.Hidden;
            ImageTest.Visibility = Visibility.Hidden;
            Checked.Visibility = Visibility.Visible;
        }
        private void Checked_Click(object sender, RoutedEventArgs e)
        {
            if (A1.Text == "" || A2.Text == "" || A3.Text == "" || A4.Text == "")
            {
                MessageBox.Show("Необходимо ответите на все вопросы!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Backed.Visibility = Visibility.Visible;
                Checked.Visibility = Visibility.Hidden;
                A1.IsEnabled = false;
                A2.IsEnabled = false;
                A3.IsEnabled = false;
                A4.IsEnabled = false;
                int k = 0;

                Back.Visibility = Visibility.Hidden;
                if (A1.Text == "bool")
                {
                    k++;
                    A1.Foreground = Brushes.Green;
                }
                else
                {
                    A1.Foreground = Brushes.Red;
                }
                if (A2.Text == "List<int> numbers = new List<int>();")
                {
                    k++;
                    A2.Foreground = Brushes.Green;
                }
                else
                {
                    A2.Foreground = Brushes.Red;
                }
                if (A3.Text == "list.Add(5);")
                {
                    k++;
                    A3.Foreground = Brushes.Green;
                }
                else
                {
                    A3.Foreground = Brushes.Red;
                }
                if (A4.Text == "list.RemoveAt(0);")
                {
                    k++;
                    A4.Foreground = Brushes.Green;
                }
                else
                {
                    A4.Foreground = Brushes.Red;
                }
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
                string lineToChange = loginToFind + ", " + results[0] + ", " + results[1] + ", " + results[2] + ", " + results[3] + ", " + results[4] + ", " + results[5] + ", " + k * 25 + ", " + results[7];
                string ch = loginToFind + ", " + results[0] + ", " + results[1] + ", " + results[2] + ", " + results[3] + ", " + results[4] + ", " + results[5] + ", " + results[6] + ", " + results[7];
                // Находим нужный логин и изменяем его результат
                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i] == ch)
                    {
                        lines[i] = lineToChange;
                        break;
                    }
                }
                // Перезаписываем файл с обновленными данными
                using (StreamWriter writer = new StreamWriter(usersFilePath1))
                {
                    foreach (string line in lines)
                    {
                        writer.WriteLine(line);
                    }
                }

                if (k == 0 || k == 1)
                {
                    MessageBox.Show("Вы очень плохо усвоили материал, мы настойчиво рекомендуем повторить его и пройти тест заново ", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                if (k == 2)
                {
                    MessageBox.Show("Вы плохо усвоили материал, мы рекомендуем повторить его и пройти тест заново ", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                if (k == 3)
                {
                    MessageBox.Show("Вы практически идеально усвоили материал, мы можем посоветовать вам повторить изученный материал, для закрепления результата", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                if (k == 4)
                {
                    MessageBox.Show("Вы безупречно усвоили материал!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Window16 newWin = new Window16();
                this.Close();
                newWin.ShowDialog();
                this.Show();
            }
            catch { }
        }
        private void Backed_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Window2 newWin = new Window2();
                this.Close();
                newWin.ShowDialog();
                this.Show();
            }
            catch { }
        }
    }
}
