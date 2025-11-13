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
using static System.Net.Mime.MediaTypeNames;

namespace Приложение
{
    /// <summary>
    /// Логика взаимодействия для Window16.xaml
    /// </summary>
    public partial class Window16 : Window
    {
        private const string Level7FilePath = "level_7.txt";
        public int k = 0;
        public int[] M = new[] { 365, 77, 186, 158 };
        public int i = 0;
        public Window16()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            MaxHeight = 495;
            MaxWidth = 500;
            MinHeight = 495;
            MinWidth = 500;
            L7Text.IsReadOnly = true;
            TextInterac.IsReadOnly = true;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            imageFile.Visibility = Visibility.Hidden;
            L7Text.Visibility = Visibility.Visible;
            L7Text.Clear();
            L7Text.Height = 213;
            try
            {
                string text = File.ReadAllText(Level7FilePath);
                while (i < M[k])
                {
                    L7Text.Text += Convert.ToString(text[i]);
                    i++;
                }
                Start.Visibility = Visibility.Hidden;
                NextT.Visibility = Visibility.Visible;
            }
            catch
            {
            }
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
        private void NextT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                L7Text.Height = 153;
                int s = 0;
                L7Text.Text = "";
                k += 1;
                if (k == 1)
                {
                    Image1.Visibility = Visibility.Visible;
                    L7Text.Height = 153;
                }
                if (k == 2)
                {
                    Image1.Visibility = Visibility.Hidden;
                    Image2.Visibility = Visibility.Visible;
                    Image3.Visibility = Visibility.Visible;
                }
                if (k == 3)
                {
                    Image2.Visibility = Visibility.Hidden;
                    Image3.Visibility = Visibility.Hidden;
                    Image4.Visibility = Visibility.Visible;
                    Image5.Visibility = Visibility.Visible;
                    NextT.Visibility = Visibility.Hidden;
                    Test.Visibility = Visibility.Visible;
                    Interac.Visibility = Visibility.Visible;
                }
                if (k != 3)
                {
                    Test.Visibility = Visibility.Hidden;
                }
                if (k != 0)
                {
                    BackT.Visibility = Visibility.Visible;
                }
                if (i == 3)
                {
                    NextT.Visibility = Visibility.Hidden;
                    Test.Visibility = Visibility.Visible;
                }
                for (int j = 0; j <= k; j++)
                {
                    s += M[j];
                }
                string text = File.ReadAllText(Level7FilePath);
                while (i < s)
                {
                    L7Text.Text += Convert.ToString(text[i]);
                    i++;
                }
            }
            catch
            {
            }
        }
        private void BackT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                k -= 1;
                if (k == 0)
                {
                    Image1.Visibility = Visibility.Hidden;
                    BackT.Visibility = Visibility.Hidden;
                    L7Text.Height = 213;
                }
                if (k == 1)
                {
                    Image1.Visibility = Visibility.Visible;
                    Image2.Visibility = Visibility.Hidden;
                    Image3.Visibility = Visibility.Hidden;
                    NextT.Visibility = Visibility.Visible;
                }
                if (k == 2)
                {
                    Image2.Visibility = Visibility.Visible;
                    Image3.Visibility = Visibility.Visible;
                    Image4.Visibility = Visibility.Hidden;
                    Image5.Visibility = Visibility.Hidden;
                    NextT.Visibility = Visibility.Visible;
                    Interac.Visibility = Visibility.Hidden;
                }
                if (k != 2)
                {
                    Test.Visibility = Visibility.Hidden;
                    NextT.Visibility = Visibility.Visible;
                }
                int s = 0;
                L7Text.Text = "";
                if (i == 2)
                {
                    BackT.Visibility = Visibility.Hidden;
                }
                for (int j = 0; j <= k; j++)
                {
                    s += M[j];
                }
                i = s - M[k];
                string text = File.ReadAllText(Level7FilePath);
                while (i < s)
                {
                    L7Text.Text += Convert.ToString(text[i]);
                    i++;
                }
            }
            catch
            {
            }
        }
        private void Test_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Window17 newWin = new Window17();
                this.Close();
                newWin.ShowDialog();
                this.Show();
            }
            catch { }

        }
        private void Check_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string sF = PlaceList.Text.Replace(" ", "");
                if (sF == "Console.WriteLine(S.Contains(P));" || sF == "Console.Write(S.Contains(P));") 
                {
                    D3.Visibility = Visibility.Hidden;
                    D2.Visibility = Visibility.Visible;
                    PlaceList.IsReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Ой! Что-то пошло не так! Попробуйте снова", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    D3.Visibility = Visibility.Visible;
                    D2.Visibility = Visibility.Hidden;
                }
            }
            catch
            {
                MessageBox.Show("Ой! Что-то пошло не так! Попробуйте снова", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                D3.Visibility = Visibility.Visible;
                D2.Visibility = Visibility.Hidden;
            }
        }
        private void Interac_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Hidden;
            L7Text.Visibility = Visibility.Hidden;
            NextT.Visibility = Visibility.Hidden;
            BackT.Visibility = Visibility.Hidden;
            Interac.Visibility = Visibility.Hidden;
            Image4.Visibility = Visibility.Hidden;
            Image5.Visibility = Visibility.Hidden;
            Test.Visibility = Visibility.Hidden;
            D1.Visibility = Visibility.Visible;
            TextInterac.Visibility = Visibility.Visible;
            PlaceList.Visibility = Visibility.Visible;
            Check.Visibility = Visibility.Visible;
            TeLi.Visibility = Visibility.Visible;
            back1.Visibility = Visibility.Visible;
        }
        private void back1_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Visible;
            L7Text.Visibility = Visibility.Visible;
            NextT.Visibility = Visibility.Visible;
            BackT.Visibility = Visibility.Visible;
            Interac.Visibility = Visibility.Visible;
            Image4.Visibility = Visibility.Visible;
            Image5.Visibility = Visibility.Visible;
            Test.Visibility = Visibility.Visible;
            D1.Visibility = Visibility.Hidden;
            D2.Visibility = Visibility.Hidden;
            D3.Visibility = Visibility.Hidden;
            TextInterac.Visibility = Visibility.Hidden;
            PlaceList.Visibility = Visibility.Hidden;
            Check.Visibility = Visibility.Hidden;
            TeLi.Visibility = Visibility.Hidden;
            back1.Visibility = Visibility.Hidden;
        }
    }
}
