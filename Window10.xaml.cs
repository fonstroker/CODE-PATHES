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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Приложение
{
    /// <summary>
    /// Логика взаимодействия для Window10.xaml
    /// </summary>
    public partial class Window10 : Window
    {
        private const string Level4FilePath1 = "level_4.txt";
        public int k = 0;
        public int[] M = new[] { 226, 220, 195, 58, 66, 65 };
        public int i = 0;
        public Window10()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            MaxHeight = 495;
            MaxWidth = 500;
            MinHeight = 495;
            MinWidth = 500;
            L4Text.IsReadOnly = true;
            TextMas1.IsReadOnly = true;
            TextMas2.IsReadOnly = true;
        }
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            image1.Visibility = Visibility.Visible;
            Mas.Visibility = Visibility.Hidden;
            L4Text.Visibility = Visibility.Visible;
            L4Text.Clear();
            Interac.Visibility = Visibility.Visible;
            try
            {
                string text = File.ReadAllText(Level4FilePath1);
                while (i < M[k])
                {
                    L4Text.Text += Convert.ToString(text[i]);
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
                int s = 0;
                L4Text.Text = "";
                k += 1;
                if (k == 1)
                {
                    image1.Visibility = Visibility.Hidden;
                    Interac.Visibility = Visibility.Hidden;
                    Image2.Visibility = Visibility.Visible;
                    Image3.Visibility = Visibility.Visible;
                }
                if (k == 2)
                {
                    Image2.Visibility = Visibility.Hidden;
                    Image3.Visibility = Visibility.Hidden;
                    Image4.Visibility = Visibility.Visible;
                    Interac1.Visibility = Visibility.Visible;
                }
                else
                {
                    Interac1.Visibility= Visibility.Hidden;
                }
                if (k == 3)
                {
                    Image4.Visibility = Visibility.Hidden;
                    Image5.Visibility = Visibility.Visible;
                }
                if (k == 4)
                {
                    Image5.Visibility = Visibility.Hidden;
                    Image6.Visibility = Visibility.Visible;
                }
                if (k == 5)
                {
                    Image6.Visibility = Visibility.Hidden;
                    Image7.Visibility = Visibility.Visible;
                    Image8.Visibility = Visibility.Visible;
                    NextT.Visibility = Visibility.Hidden;
                    Test.Visibility = Visibility.Visible;
                }
                if (k != 5)
                {
                    Test.Visibility = Visibility.Hidden;
                }
                if (k != 0)
                {
                    BackT.Visibility = Visibility.Visible;
                }
                if (i == 5)
                {
                    NextT.Visibility = Visibility.Hidden;
                    Test.Visibility = Visibility.Visible;
                }
                for (int j = 0; j <= k; j++)
                {
                    s += M[j];
                }
                string text = File.ReadAllText(Level4FilePath1);
                while (i < s) 
                {
                    L4Text.Text += Convert.ToString(text[i]);
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
                    image1.Visibility = Visibility.Visible;
                    Interac.Visibility = Visibility.Visible;
                    Image2.Visibility = Visibility.Hidden;
                    Image3.Visibility = Visibility.Hidden;
                    BackT.Visibility = Visibility.Hidden;
                }
                if (k == 1)
                {
                    Image2.Visibility = Visibility.Visible;
                    Image3.Visibility = Visibility.Visible;
                    Image4.Visibility = Visibility.Hidden;
                }
                if (k == 2)
                {
                    Image4.Visibility = Visibility.Visible;
                    Interac1.Visibility = Visibility.Visible;
                    Image5.Visibility = Visibility.Hidden;
                }
                else
                {
                    Interac1.Visibility = Visibility.Hidden;
                }
                if (k == 3)
                {
                    Image5.Visibility = Visibility.Visible;
                    Image6.Visibility = Visibility.Hidden;
                }
                if (k == 4)
                {
                    Image6.Visibility = Visibility.Visible;
                    Image7.Visibility = Visibility.Hidden;
                    Image8.Visibility = Visibility.Hidden;
                    NextT.Visibility = Visibility.Visible;
                }
                if (k != 5)
                {
                    Test.Visibility = Visibility.Hidden;
                    NextT.Visibility = Visibility.Visible;
                }
                int s = 0;
                L4Text.Text = "";
                if (i == 1)
                {
                    BackT.Visibility = Visibility.Hidden;
                }
                for (int j = 0; j <= k; j++)
                {
                    s += M[j];
                }
                i = s - M[k];
                string text = File.ReadAllText(Level4FilePath1);
                while (i < s)
                {
                    L4Text.Text += Convert.ToString(text[i]);
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
                Window11 newWin = new Window11();
                this.Close();
                newWin.ShowDialog();
                this.Show();
            }
            catch { }
        }
        private void MakeBridge_Click(object sender, RoutedEventArgs e)
        {
            string sM = PlaceMas.Text.Replace(" ", "");
            if (sM == "char[]M=newchar[16];")
            {
                bridge1.Visibility = Visibility.Hidden;
                bridge2.Visibility = Visibility.Visible;
                PlaceMas.IsReadOnly = true;
            }
            else
            {
                MessageBox.Show("Ой! Что-то пошло не так! Попробуйте снова", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Interac_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Hidden;
            L4Text.Visibility = Visibility.Hidden;
            NextT.Visibility = Visibility.Hidden;
            Interac.Visibility = Visibility.Hidden;
            image1.Visibility = Visibility.Hidden;
            bridge1.Visibility = Visibility.Visible;
            TextMas1.Visibility = Visibility.Visible;
            PlaceMas.Visibility = Visibility.Visible;
            MakeBridge.Visibility = Visibility.Visible;
            TeMas.Visibility = Visibility.Visible;
            back1.Visibility = Visibility.Visible;
        }
        private void back1_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Visible;
            L4Text.Visibility = Visibility.Visible;
            NextT.Visibility = Visibility.Visible;
            Interac.Visibility = Visibility.Visible;
            image1.Visibility = Visibility.Visible;
            bridge1.Visibility = Visibility.Hidden;
            bridge2.Visibility = Visibility.Hidden;
            TextMas1.Visibility = Visibility.Hidden;
            PlaceMas.Visibility = Visibility.Hidden;
            MakeBridge.Visibility = Visibility.Hidden;
            TeMas.Visibility = Visibility.Hidden;
            back1.Visibility = Visibility.Hidden;
        }

        private void Interac1_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Hidden;
            L4Text.Visibility = Visibility.Hidden;
            NextT.Visibility = Visibility.Hidden;
            BackT.Visibility = Visibility.Hidden;
            Interac1.Visibility = Visibility.Hidden;
            Image4.Visibility = Visibility.Hidden;
            Map.Visibility = Visibility.Visible;
            TextMas2.Visibility = Visibility.Visible;
            PlaceMas2.Visibility = Visibility.Visible;
            MakeMap.Visibility = Visibility.Visible;
            TeMas2.Visibility = Visibility.Visible;
            back2.Visibility = Visibility.Visible;
        }
        private void MakeMap_Click(object sender, RoutedEventArgs e)
        {
            string sM2 = PlaceMas2.Text.Replace(" ", "");
            if (sM2 == "int[,]M=newint[8,8];")
            {
                Map1.Visibility = Visibility.Visible;
                Map.Visibility = Visibility.Hidden;
                PlaceMas2.IsReadOnly = true;
            }
            else
            {
                MessageBox.Show("Ой! Что-то пошло не так! Попробуйте снова", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void back2_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Visible;
            L4Text.Visibility = Visibility.Visible;
            NextT.Visibility = Visibility.Visible;
            BackT.Visibility = Visibility.Visible;
            Interac1.Visibility = Visibility.Visible;
            Image4.Visibility = Visibility.Visible;
            Map.Visibility = Visibility.Hidden;
            Map1.Visibility = Visibility.Hidden;
            TextMas2.Visibility = Visibility.Hidden;
            PlaceMas2.Visibility = Visibility.Hidden;
            MakeMap.Visibility = Visibility.Hidden;
            TeMas2.Visibility = Visibility.Hidden;
            back2.Visibility = Visibility.Hidden;
        }
    }
}
