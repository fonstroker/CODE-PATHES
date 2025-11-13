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
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;

namespace Приложение
{
    /// <summary>
    /// Логика взаимодействия для Window14.xaml
    /// </summary>
    public partial class Window14 : Window
    {
        private const string Level6FilePath = "level_6.txt";
        public int k = 0;
        public int[] M = new[] { 269, 132, 77, 100, 106 };
        public int i = 0;
        public Window14()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            MaxHeight = 495;
            MaxWidth = 500;
            MinHeight = 495;
            MinWidth = 500;
            L6Text.IsReadOnly = true;
            Output.IsReadOnly = true;
            TextInterac.IsReadOnly = true;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            L6Text.Height = 188;
            imageFile.Visibility = Visibility.Hidden;
            L6Text.Visibility = Visibility.Visible;
            L6Text.Clear();
            try
            {
                string text = File.ReadAllText(Level6FilePath);
                while (i < M[k])
                {
                    L6Text.Text += Convert.ToString(text[i]);
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
                L6Text.Height = 153;
                int s = 0;
                L6Text.Text = "";
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
                }
                if (k == 3)
                {
                    Image3.Visibility = Visibility.Hidden;
                    Image4.Visibility = Visibility.Hidden;
                    Image5.Visibility = Visibility.Visible;
                    Image6.Visibility = Visibility.Visible;
                }
                if (k == 4)
                {
                    Image5.Visibility = Visibility.Hidden;
                    Image6.Visibility = Visibility.Hidden;
                    Image7.Visibility = Visibility.Visible;
                    Image8.Visibility = Visibility.Visible;
                    NextT.Visibility = Visibility.Hidden;
                    Test.Visibility = Visibility.Visible;
                    Interac.Visibility = Visibility.Visible;
                }
                if (k != 4)
                {
                    Test.Visibility = Visibility.Hidden;
                }
                if (k != 0)
                {
                    BackT.Visibility = Visibility.Visible;
                }
                if (i == 4)
                {
                    NextT.Visibility = Visibility.Hidden;
                    Test.Visibility = Visibility.Visible;
                    Interac.Visibility = Visibility.Visible;
                }
                for (int j = 0; j <= k; j++)
                {
                    s += M[j];
                }
                string text = File.ReadAllText(Level6FilePath);
                while (i < s)
                {
                    L6Text.Text += Convert.ToString(text[i]);
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
                    L6Text.Height = 188;
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
                }
                if (k == 3)
                {
                    Image5.Visibility = Visibility.Visible;
                    Image6.Visibility = Visibility.Visible;
                    Image7.Visibility = Visibility.Hidden;
                    Image8.Visibility = Visibility.Hidden;
                    NextT.Visibility = Visibility.Visible;
                    Interac.Visibility = Visibility.Hidden;
                }
                if (k != 3)
                {
                    Test.Visibility = Visibility.Hidden;
                    NextT.Visibility = Visibility.Visible;
                }
                int s = 0;
                L6Text.Text = "";
                if (i == 3)
                {
                    BackT.Visibility = Visibility.Hidden;
                }
                for (int j = 0; j <= k; j++)
                {
                    s += M[j];
                }
                i = s - M[k];
                string text = File.ReadAllText(Level6FilePath);
                while (i < s)
                {
                    L6Text.Text += Convert.ToString(text[i]);
                    i++;
                }
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
        private void OpenF_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string sF1 = PlaceFile.Text.Replace(" ", ""), sF2 = PlaceFile1.Text.Replace(" ", "");
                if (sF1 == "S=File.ReadAllText(path);" && (sF2 == "Console.WriteLine(S);" || sF2 == "Console.Write(S);"))
                {
                    R1.Visibility = Visibility.Hidden;
                    R2.Visibility = Visibility.Visible;
                    PlaceFile.IsReadOnly = true;
                    PlaceFile1.IsReadOnly = true;
                    Output.Text = "Имя: Sentinel13\r\nДата создания:\r\n13.05.2124\r\nВид: Sentinel (страж)\r\nОсобенности:\r\nИсскусственный интелект, абсорбация";
                }
                else
                {
                    MessageBox.Show("Ой! Что-то пошло не так! Попробуйте снова", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ой! Что-то пошло не так! Попробуйте снова", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Interac_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Hidden;
            L6Text.Visibility = Visibility.Hidden;
            NextT.Visibility = Visibility.Hidden;
            BackT.Visibility = Visibility.Hidden;
            Interac.Visibility = Visibility.Hidden;
            Image7.Visibility = Visibility.Hidden;
            Image8.Visibility = Visibility.Hidden;
            OpenF.Visibility = Visibility.Hidden;
            Test.Visibility = Visibility.Hidden;
            Test.Visibility= Visibility.Hidden;
            R1.Visibility = Visibility.Visible;
            TextInterac.Visibility = Visibility.Visible;
            PlaceFile.Visibility = Visibility.Visible;
            PlaceFile1.Visibility = Visibility.Visible;
            OpenF.Visibility = Visibility.Visible;
            TeFile.Visibility = Visibility.Visible;
            TeFile1.Visibility = Visibility.Visible;
            back1.Visibility = Visibility.Visible;
            Output.Visibility = Visibility.Visible;
        }
        private void back1_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Visible;
            L6Text.Visibility = Visibility.Visible;
            NextT.Visibility = Visibility.Visible;
            BackT.Visibility = Visibility.Visible;
            Interac.Visibility = Visibility.Visible;
            Image7.Visibility = Visibility.Visible;
            Image8.Visibility = Visibility.Visible;
            OpenF.Visibility = Visibility.Visible;
            Test.Visibility = Visibility.Visible;
            Test.Visibility=Visibility.Visible;
            R1.Visibility = Visibility.Hidden;
            R2.Visibility = Visibility.Hidden;
            TextInterac.Visibility = Visibility.Hidden;
            PlaceFile.Visibility = Visibility.Hidden;
            PlaceFile1.Visibility = Visibility.Hidden;
            OpenF.Visibility = Visibility.Hidden;
            TeFile.Visibility = Visibility.Hidden;
            TeFile1.Visibility = Visibility.Hidden;
            back1.Visibility = Visibility.Hidden;
            Output.Visibility = Visibility.Hidden;
        }
        private void Test_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Window15 newWin = new Window15();
                this.Close();
                newWin.ShowDialog();
                this.Show();
            }
            catch { }
        }
    }
}
