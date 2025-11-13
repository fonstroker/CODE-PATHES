using Microsoft.Win32;
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
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public string sourceImagePath;
        public string login;
        public const string users = "users.txt";
        public const string OnlineWorker = "OnlineWorker.txt";
        public const string pathAvatarFile = "avatarkes.txt";
        const string usersFilePath1 = "progress.txt";
        public Window6()
        {
            InitializeComponent();
            Line1.Source = AddLines(MakeLine(InfoProgress(0)));
            Line2.Source = AddLines(MakeLine(InfoProgress(1)));
            Line3.Source = AddLines(MakeLine(InfoProgress(2)));
            Line4.Source = AddLines(MakeLine(InfoProgress(3)));
            Line5.Source = AddLines(MakeLine(InfoProgress(4)));
            Line6.Source = AddLines(MakeLine(InfoProgress(5)));
            Line7.Source = AddLines(MakeLine(InfoProgress(6)));
            Line8.Source = AddLines(MakeLine(InfoProgress(7)));

            string[] lines = File.ReadAllLines(pathAvatarFile);
            login = File.ReadAllText(OnlineWorker).Trim();
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');

                if (parts.Length >= 2 && parts[0] == login)
                {
                    string imagePath = parts[1]; // Убираем возможные пробелы в начале и конце пути

                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri(parts[1], UriKind.Relative);
                    bitmap.EndInit();
                    Avatar.Source = bitmap; ;
                    break;
                }
            }
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            MaxHeight = 495;
            MaxWidth = 510;
            MinHeight = 495;
            MinWidth = 510;
            if (File.Exists(users))
            {
                string[] li = File.ReadAllLines(users);

                foreach (string line in li)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3 && parts[0] == login)
                    {
                        Name.Content = parts[2];
                        break;
                    }
                    else
                    {
                        Name.Content = "Ошибка";
                    }
                }
            }
        }
        public void AddImage(string imagePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(pathAvatarFile);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts[0] == login)
                    {
                        // Обновляем ссылку на картинку для найденного пользователя
                        lines[i] = login + "," + imagePath;
                        // Перезаписываем файл с обновленными данными
                        File.WriteAllLines(pathAvatarFile, lines);
                        BitmapImage bitmap = new BitmapImage();
                        bitmap.BeginInit();
                        bitmap.UriSource = new Uri(imagePath, UriKind.Relative);
                        bitmap.EndInit();
                        Avatar.Source = bitmap; ;
                        break;
                    }
                }
            } catch { }
            AvaInventor.Visibility = Visibility.Hidden;
        }
        public string MakeLine(string Pointes)
        {
            try
            {
                if (Convert.ToInt32(Pointes) == 100)
                {
                    return "10 очков.png";
                }
                if (Convert.ToInt32(Pointes) >= 90)
                {
                    return "9 очков.png";
                }
                if (Convert.ToInt32(Pointes) >= 80)
                {
                    return "8 очков.png";
                }
                if (Convert.ToInt32(Pointes) >= 70)
                {
                    return "7 очков.png";
                }
                if (Convert.ToInt32(Pointes) >= 60)
                {
                    return "6 очков.png";
                }
                if (Convert.ToInt32(Pointes) >= 50)
                {
                    return "5 очков.png";
                }
                if (Convert.ToInt32(Pointes) >= 40)
                {
                    return "4 очков.png";
                }
                if (Convert.ToInt32(Pointes) >= 30)
                {
                    return "3 очка.png";
                }
                if (Convert.ToInt32(Pointes) >= 20)
                {
                    return "2 очка.png";
                }
                if (Convert.ToInt32(Pointes) >= 10)
                {
                    return "1 очко.png";
                }
            }
            catch { }
            return "0 очков.png";
        }
        public string InfoProgress(int k)
        {
                List<string> info = new List<string>();
                string loginToFind = File.ReadAllText(OnlineWorker).Trim();
                // Считываем все строки из файла в лист строк
                using (StreamReader reader = new StreamReader(usersFilePath1))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        info.Add(line);
                    }
                }
                string[] results = new string[8];
                for (int i = 0; i < info.Count; i++)
                {
                    if (info[i].StartsWith(loginToFind))
                    {
                        string line = info[i];
                        string[] parts = line.Split(',');
                        for (int j = 0; j < 8; j++)
                        {
                            results[j] = parts[j + 1].Trim();
                        }
                        break;
                    }
                }
                Point1.Content = results[0];
                Point2.Content = results[1];
                Point3.Content = results[2];
                Point4.Content = results[3];
                Point5.Content = results[4];
                Point6.Content = results[5];
                Point7.Content = results[6];
                Point8.Content = results[7];
                return results[k];
        }
        public BitmapImage AddLines(string imagePath)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imagePath, UriKind.Relative);
            bitmap.EndInit();
            return bitmap; 
        }
        private void AddAvatar_Click_1(object sender, RoutedEventArgs e)
        {
            AvaInventor.Visibility = Visibility.Visible;
            _1l.Visibility = Visibility.Hidden;
            _2l.Visibility = Visibility.Hidden;
            _3l.Visibility = Visibility.Hidden;
            _4l.Visibility = Visibility.Hidden;
            _5l.Visibility = Visibility.Hidden;
            _6l.Visibility = Visibility.Hidden;
            _7l.Visibility = Visibility.Hidden;
            _8l.Visibility = Visibility.Hidden;
            _9l.Visibility = Visibility.Hidden;
            _10l.Visibility = Visibility.Hidden;
        }
        private void Back_Click(object sender, RoutedEventArgs e)
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
        private void A1_Click(object sender, RoutedEventArgs e)
        {
            AddImage("Аватар 1.jpg");
        }
        private void A2_Click(object sender, RoutedEventArgs e)
        {
            AddImage("Аватар2.jpg");
        }
        private void A3_Click(object sender, RoutedEventArgs e)
        {
            AddImage("Аватар3.jpg");
        }
        private void A4_Click(object sender, RoutedEventArgs e)
        {
            AddImage("Аватар4.png");
        }
        private void A5_Click(object sender, RoutedEventArgs e)
        {
            AddImage("Аватар5.jpg");
        }
        private void A6_Click(object sender, RoutedEventArgs e)
        {
            AddImage("Аватар6.png");
        }
        private void A7_Click(object sender, RoutedEventArgs e)
        {
            AddImage("Аватар7.png");
        }
        private void A8_Click(object sender, RoutedEventArgs e)
        {
            AddImage("Аватар8.jpg");
        }

        private void A9_Click(object sender, RoutedEventArgs e)
        {
            AddImage("Аватар9.jpg");
        }
        private void A10_Click(object sender, RoutedEventArgs e)
        {
            AddImage("Аватар10.png");
        }
        private void A11_Click(object sender, RoutedEventArgs e)
        {
            AddImage("Аватар11.png");
        }
        private void A12_Click(object sender, RoutedEventArgs e)
        {
            AddImage("Аватар12.png");
        }
        private void A13_Click(object sender, RoutedEventArgs e)
        {
            AddImage("Аватар13.png");
        }
        private void A14_Click(object sender, RoutedEventArgs e)
        {
            AddImage("Аватар14.png");
        }
        private void A15_Click(object sender, RoutedEventArgs e)
        {
            AddImage("Аватар15.png");
        }
        private void A16_Click(object sender, RoutedEventArgs e)
        {
            AddImage("Аватар16.jpg");
        }
        private void Back1_Click(object sender, RoutedEventArgs e)
        {
            AvaInventor.Visibility = Visibility.Hidden;
        }
    }
}
