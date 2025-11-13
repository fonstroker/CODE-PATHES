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
    /// Логика взаимодействия для Window12.xaml
    /// </summary>
    public partial class Window12 : Window
    {
        private const string Level5FilePath = "level_5.txt";
        public int k = 0;
        public int[] M = new[] { 273, 106, 234, 124 };
        public int i = 0;
        public Window12()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            MaxHeight = 495;
            MaxWidth = 500;
            MinHeight = 495;
            MinWidth = 500;
            L5Text.IsReadOnly = true;
            PlaceOutp.IsReadOnly = true;
        }
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Mas.Visibility = Visibility.Hidden;
            L5Text.Visibility = Visibility.Visible;
            L5Text.Clear();
            try
            {
                string text = File.ReadAllText(Level5FilePath);
                while (i < M[k])
                {
                    L5Text.Text += Convert.ToString(text[i]);
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
                L5Text.Text = "";
                k += 1;
                if (k == 1)
                {
                    Image1.Visibility = Visibility.Visible;
                    Image2.Visibility = Visibility.Visible;
                }
                if (k == 2)
                {
                    Image1.Visibility = Visibility.Hidden;
                    Image2.Visibility = Visibility.Hidden;
                    Image3.Visibility = Visibility.Visible;
                    Image4.Visibility = Visibility.Visible;
                    Interac.Visibility = Visibility.Visible;
                }
                if (k == 3)
                {
                    Image3.Visibility = Visibility.Hidden;
                    Image4.Visibility = Visibility.Hidden;
                    Image5.Visibility = Visibility.Visible;
                    Image6.Visibility = Visibility.Visible;
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
                    Interac.Visibility = Visibility.Hidden;
                }
                for (int j = 0; j <= k; j++)
                {
                    s += M[j];
                }
                string text = File.ReadAllText(Level5FilePath);
                while (i < s)
                {
                    L5Text.Text += Convert.ToString(text[i]);
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
                    Image2.Visibility = Visibility.Hidden;
                    BackT.Visibility = Visibility.Hidden;
                }
                if (k == 1)
                {
                    Image1.Visibility = Visibility.Visible;
                    Image2.Visibility = Visibility.Visible;
                    Image3.Visibility = Visibility.Hidden;
                    Image4.Visibility = Visibility.Hidden;
                    NextT.Visibility = Visibility.Visible;
                }
                if (k == 2)
                {
                    Image3.Visibility = Visibility.Visible;
                    Image4.Visibility = Visibility.Visible;
                    Image5.Visibility = Visibility.Hidden;
                    Image6.Visibility = Visibility.Hidden;
                    NextT.Visibility = Visibility.Visible;
                    Interac.Visibility = Visibility.Visible;
                }
                if (k != 2)
                {
                    Test.Visibility = Visibility.Hidden;
                    NextT.Visibility = Visibility.Visible;
                    Interac.Visibility = Visibility.Hidden;
                }
                int s = 0;
                L5Text.Text = "";
                if (i == 2)
                {
                    BackT.Visibility = Visibility.Hidden;
                }
                for (int j = 0; j <= k; j++)
                {
                    s += M[j];
                }
                i = s - M[k];
                string text = File.ReadAllText(Level5FilePath);
                while (i < s)
                {
                    L5Text.Text += Convert.ToString(text[i]);
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
                Window13 newWin = new Window13();
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
        private void Interac_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Hidden;
            L5Text.Visibility = Visibility.Hidden;
            NextT.Visibility = Visibility.Hidden;
            BackT.Visibility = Visibility.Hidden;
            Interac.Visibility = Visibility.Hidden;
            Image3.Visibility = Visibility.Hidden;
            Image4.Visibility = Visibility.Hidden;
            R1.Visibility = Visibility.Visible;
            TextFun.Visibility = Visibility.Visible;
            PlaceFun.Visibility = Visibility.Visible;
            PlaceFun1.Visibility = Visibility.Visible;
            Check.Visibility = Visibility.Visible;
            TeFu.Visibility = Visibility.Visible;
            TeFu1.Visibility = Visibility.Visible;
            TeFu2.Visibility = Visibility.Visible;
            back1.Visibility = Visibility.Visible;
            PlacePoint.Visibility = Visibility.Visible;
            PlaceOutp.Visibility = Visibility.Visible;
        }
        private void Check_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string sF1 = PlaceFun.Text.Replace(" ", ""), sF2 = PlaceFun1.Text.Replace(" ", "");
                int P = Convert.ToInt32(PlacePoint.Text);
                if (sF1 == "publicstaticvoidSqr(intP)" && (sF2 == "Console.WriteLine(P*P);" || sF2 == "Console.Write(P*P);" || sF2 == "Console.WriteLine(Math.Pow(P, 2));" || sF2 == "Console.Write(Math.Pow(P, 2));") && PlacePoint.Text != "") 
                {
                    R1.Visibility = Visibility.Hidden;
                    R2.Visibility = Visibility.Visible;
                    R3.Visibility = Visibility.Hidden;
                    PlaceOutp.Text = Convert.ToString(P * P);
                    PlaceFun.IsReadOnly = true;
                    PlaceFun1.IsReadOnly = true;
                }
                else
                {
                    R3.Visibility = Visibility.Visible;
                    R1.Visibility = Visibility.Hidden;
                    R2.Visibility = Visibility.Hidden;
                    MessageBox.Show("Ой! Что-то пошло не так! Попробуйте снова", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch 
            {
                MessageBox.Show("Ой! Что-то пошло не так! Попробуйте снова", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                R3.Visibility = Visibility.Visible;
                R1.Visibility = Visibility.Hidden;
                R2.Visibility = Visibility.Hidden;
            }
        }
        private void back1_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Visible;
            L5Text.Visibility = Visibility.Visible;
            NextT.Visibility = Visibility.Visible;
            BackT.Visibility = Visibility.Visible;
            Interac.Visibility = Visibility.Visible;
            Image3.Visibility = Visibility.Visible;
            Image4.Visibility = Visibility.Visible;
            R1.Visibility = Visibility.Hidden;
            R2.Visibility = Visibility.Hidden;
            R3.Visibility = Visibility.Hidden;
            TextFun.Visibility = Visibility.Hidden;
            PlaceFun.Visibility = Visibility.Hidden;
            PlaceFun1.Visibility = Visibility.Hidden;
            Check.Visibility = Visibility.Hidden;
            TeFu.Visibility = Visibility.Hidden;
            TeFu1.Visibility = Visibility.Hidden;
            TeFu2.Visibility = Visibility.Hidden;
            back1.Visibility = Visibility.Hidden;
            PlacePoint.Visibility = Visibility.Hidden;
            PlaceOutp.Visibility = Visibility.Hidden;
        }
    }
}

