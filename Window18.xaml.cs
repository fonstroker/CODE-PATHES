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
using static System.Net.Mime.MediaTypeNames;

namespace Приложение
{
    /// <summary>
    /// Логика взаимодействия для Window18.xaml
    /// </summary>
    public partial class Window18 : Window
    {
        private const string Level8FilePath = "level_8.txt";
        public int k = 0;
        public int[] M = new[] { 287, 471, 145, 318 };
        public int i = 0;
        public Window18()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            MaxHeight = 495;
            MaxWidth = 500;
            MinHeight = 495;
            MinWidth = 500;
            L8Text.IsReadOnly = true;
            TextInterac.IsReadOnly = true;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            imagetry.Visibility = Visibility.Hidden;
            L8Text.Visibility = Visibility.Visible;
            L8Text.Clear();
            L8Text.Height = 213;
            try
            {
                string text = File.ReadAllText(Level8FilePath);
                while (i < M[k])
                {
                    L8Text.Text += Convert.ToString(text[i]);
                    i++;
                }
                Start.Visibility = Visibility.Hidden;
                NextT.Visibility = Visibility.Visible;
            }
            catch
            {
            }
        }

        private void NextT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int s = 0;
                L8Text.Text = "";
                k += 1;
                if (k == 2)
                {
                    L8Text.Height = 153;
                    Image1.Visibility = Visibility.Visible;
                    Image2.Visibility = Visibility.Visible;
                    Interac.Visibility = Visibility.Visible;
                }
                if (k == 3)
                {
                    Image1.Visibility = Visibility.Hidden;
                    Image2.Visibility = Visibility.Hidden;
                    Image3.Visibility = Visibility.Visible;
                    Image4.Visibility = Visibility.Visible;
                    NextT.Visibility = Visibility.Hidden;
                    Test.Visibility = Visibility.Visible;
                    Interac.Visibility = Visibility.Hidden;
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
                string text = File.ReadAllText(Level8FilePath);
                while (i < s)
                {
                    L8Text.Text += Convert.ToString(text[i]);
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
                }
                if (k == 1)
                {
                    L8Text.Height = 238;
                    Interac.Visibility = Visibility.Hidden;
                    Image1.Visibility = Visibility.Hidden;
                    Image2.Visibility = Visibility.Hidden;
                }
                if (k == 2)
                {
                    Image1.Visibility = Visibility.Visible;
                    Image2.Visibility = Visibility.Visible;
                    Image3.Visibility = Visibility.Hidden;
                    Image4.Visibility = Visibility.Hidden;
                    NextT.Visibility = Visibility.Visible;
                    Interac.Visibility = Visibility.Visible;
                }
                if (k != 2)
                {
                    Test.Visibility = Visibility.Hidden;
                    NextT.Visibility = Visibility.Visible;
                }
                int s = 0;
                L8Text.Text = "";
                if (i == 2)
                {
                    BackT.Visibility = Visibility.Hidden;
                }
                for (int j = 0; j <= k; j++)
                {
                    s += M[j];
                }
                i = s - M[k];
                string text = File.ReadAllText(Level8FilePath);
                while (i < s)
                {
                    L8Text.Text += Convert.ToString(text[i]);
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
                Window19 newWin = new Window19();
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
                Window2 newWin = new Window2();
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
                string sF = Placetry.Text.Replace(" ", "").Replace("\n", "").Replace("\r", "");
                if (sF == "try{pass();}catch(Exceptionex){Console.WriteLine(\"Ошибка:\"+ex.Message);}") 
                {
                    Placetry.IsReadOnly = true;
                    S1.Visibility = Visibility.Visible;
                    S2.Visibility = Visibility.Hidden;
                    MessageBox.Show("Молодцы! Вор не смог взломать сейф", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Ой! Что-то пошло не так! Попробуйте снова", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    S2.Visibility = Visibility.Visible;
                    S1.Visibility = Visibility.Hidden;
                }
            }
            catch
            {
                MessageBox.Show("Ой! Что-то пошло не так! Попробуйте снова", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                S2.Visibility = Visibility.Visible;
                S1.Visibility = Visibility.Hidden;
            }
        }
        private void Interac_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Hidden;
            L8Text.Visibility = Visibility.Hidden;
            NextT.Visibility = Visibility.Hidden;
            BackT.Visibility = Visibility.Hidden;
            Interac.Visibility = Visibility.Hidden;
            Image1.Visibility = Visibility.Hidden;
            Image2.Visibility = Visibility.Hidden;
            Test.Visibility = Visibility.Hidden;
            S1.Visibility = Visibility.Visible;
            TextInterac.Visibility = Visibility.Visible;
            Placetry.Visibility = Visibility.Visible;
            Check.Visibility = Visibility.Visible;
            TeLi.Visibility = Visibility.Visible;
            back1.Visibility = Visibility.Visible;
        }
        private void back1_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Visible;
            L8Text.Visibility = Visibility.Visible;
            NextT.Visibility = Visibility.Visible;
            BackT.Visibility = Visibility.Visible;
            Interac.Visibility = Visibility.Visible;
            Image1.Visibility = Visibility.Visible;
            Image2.Visibility = Visibility.Visible;
            Test.Visibility = Visibility.Visible;
            S1.Visibility = Visibility.Hidden;
            TextInterac.Visibility = Visibility.Hidden;
            Placetry.Visibility = Visibility.Hidden;
            Check.Visibility = Visibility.Hidden;
            TeLi.Visibility = Visibility.Hidden;
            back1.Visibility = Visibility.Hidden;
            Placetry.IsReadOnly = false;
        }
    }
}
