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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        private const string Level2FilePath2 = "level_2.txt";
        public int k = 0;
        public int[] M = new[] {197, 254, 99, 118,  143, 135, 115};
        public int i = 0;
        public Window5()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            MaxHeight = 495;
            MaxWidth = 500;
            MinHeight = 495;
            MinWidth = 500;
            L2Text.IsReadOnly = true;
            TextInter.IsReadOnly = true;
            TextInter1.IsReadOnly = true;
        }
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            image1.Visibility = Visibility.Visible;
            Image2.Visibility = Visibility.Visible;
            ImaInstrum.Visibility = Visibility.Hidden;
            L2Text.Visibility = Visibility.Visible;
            L2Text.Clear();
            Interac.Visibility = Visibility.Visible;
            try
            {
                string text = File.ReadAllText(Level2FilePath2);
                while (i < M[k])
                {
                    L2Text.Text += Convert.ToString(text[i]);
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
                L2Text.Text = "";
                k += 1;
                if (k == 0)
                {
                    image1.Visibility = Visibility.Visible;
                    Image2.Visibility = Visibility.Visible;
                    BackT.Visibility = Visibility.Hidden;
                }
                if (k == 1)
                {
                    image1.Visibility = Visibility.Hidden;
                    Image2.Visibility = Visibility.Hidden;
                    Image3.Visibility = Visibility.Visible;
                    Interac.Visibility = Visibility.Hidden;
                }
                if (k == 2)
                {
                    Image3.Visibility = Visibility.Hidden;
                    Image4.Visibility = Visibility.Visible;
                    Image5.Visibility = Visibility.Visible;
                }
                if (k == 3)
                {
                    Image4.Visibility = Visibility.Hidden;
                    Image5.Visibility = Visibility.Hidden;
                    Image6.Visibility = Visibility.Visible;
                    Image7.Visibility = Visibility.Visible;
                }
                if (k == 4)
                {
                    Image6.Visibility = Visibility.Hidden;
                    Image7.Visibility = Visibility.Hidden;
                    Image8.Visibility = Visibility.Visible;
                    Image9.Visibility = Visibility.Visible;
                }
                if (k == 5)
                {
                    Image8.Visibility = Visibility.Hidden;
                    Image9.Visibility = Visibility.Hidden;
                    Image10.Visibility = Visibility.Visible;
                    Image11.Visibility = Visibility.Visible;
                    Interac1.Visibility = Visibility.Visible;
                }
                else
                {
                    Interac1.Visibility=Visibility.Hidden;
                }
                if (k == 6)
                {
                    Image10.Visibility = Visibility.Hidden;
                    Image11.Visibility = Visibility.Hidden;
                    Image12.Visibility = Visibility.Visible;
                    Image13.Visibility = Visibility.Visible;
                    NextT.Visibility = Visibility.Hidden;
                    Test.Visibility = Visibility.Visible;
                }
                if (k != 6)
                {
                    Test.Visibility = Visibility.Hidden;
                }
                if (k != 0)
                {
                    BackT.Visibility = Visibility.Visible;
                    Interac.Visibility = Visibility.Hidden;
                }
                if (i == 6)
                {
                    NextT.Visibility = Visibility.Hidden;
                }
                for (int j = 0; j <= k; j++)
                {
                    s += M[j];
                }
                string text = File.ReadAllText(Level2FilePath2);
                while (i < s)
                {
                    L2Text.Text += Convert.ToString(text[i]);
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
                    Image2.Visibility = Visibility.Visible;
                    Image3.Visibility = Visibility.Hidden;
                    BackT.Visibility = Visibility.Hidden;
                    Interac.Visibility = Visibility.Visible;
                }
                if (k == 1)
                {
                    Image3.Visibility = Visibility.Visible;
                    Image4.Visibility = Visibility.Hidden;
                    Image5.Visibility = Visibility.Hidden;
                }
                if (k == 2)
                {
                    Image6.Visibility = Visibility.Hidden;
                    Image7.Visibility = Visibility.Hidden;
                    Image4.Visibility = Visibility.Visible;
                    Image5.Visibility = Visibility.Visible;
                }

                if (k == 3)
                {
                    Image8.Visibility = Visibility.Hidden;
                    Image9.Visibility = Visibility.Hidden;
                    Image6.Visibility = Visibility.Visible;
                    Image7.Visibility = Visibility.Visible;
                }
                if (k == 4)
                {
                    Image10.Visibility = Visibility.Hidden;
                    Image11.Visibility = Visibility.Hidden;
                    Image8.Visibility = Visibility.Visible;
                    Image9.Visibility = Visibility.Visible;
                }
                if (k == 5)
                {
                    Image12.Visibility = Visibility.Hidden;
                    Image13.Visibility = Visibility.Hidden;
                    Image10.Visibility = Visibility.Visible;
                    Image11.Visibility = Visibility.Visible;
                    NextT.Visibility = Visibility.Visible;
                    Interac1.Visibility = Visibility.Visible;
                }
                else
                {
                    Interac1.Visibility= Visibility.Hidden;
                }
                if (k !=6)
                {
                    Test.Visibility = Visibility.Hidden;
                    NextT.Visibility = Visibility.Visible;
                }
                int s = 0;
                L2Text.Text = "";
                if (i == 1)
                {
                    BackT.Visibility = Visibility.Hidden;
                }
                for (int j = 0; j <= k; j++)
                {
                    s += M[j];
                }
                i = s - M[k];
                string text = File.ReadAllText(Level2FilePath2);
                while (i < s)
                {
                    L2Text.Text += Convert.ToString(text[i]);
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
                Window7 newWin = new Window7();
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
        private void Check1_Click(object sender, RoutedEventArgs e)
        {
            string sC = PlaceConsole.Text.Replace(" ", "");
            if (sC == "Console.WriteLine(\"Приветмир!\");"|| sC == "Console.Write(\"Приветмир!\");")
            {
                Rob2.Visibility = Visibility.Hidden;
                Rob1.Visibility = Visibility.Visible;
                PlaceConsole.IsReadOnly = true;
            }
            else
            {
                MessageBox.Show("Ой! Что-то пошло не так! Попробуйте снова|"+sC+"|", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Interac_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Hidden;
            L2Text.Visibility = Visibility.Hidden;
            BackT.Visibility = Visibility.Hidden;
            NextT.Visibility = Visibility.Hidden;
            Interac.Visibility = Visibility.Hidden;
            image1.Visibility = Visibility.Hidden;
            Image2.Visibility = Visibility.Hidden;
            Interac.Visibility = Visibility.Hidden;    
            Rob2.Visibility = Visibility.Visible;
            TextInter.Visibility = Visibility.Visible;
            PlaceConsole.Visibility = Visibility.Visible;
            Study.Visibility = Visibility.Visible;
            TeConsole.Visibility = Visibility.Visible;
            back1.Visibility = Visibility.Visible;
        }
        private void back1_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Visible;
            L2Text.Visibility = Visibility.Visible;
            NextT.Visibility = Visibility.Visible;
            Interac.Visibility = Visibility.Visible;
            image1.Visibility = Visibility.Visible;
            Image2.Visibility = Visibility.Visible;
            Rob1.Visibility = Visibility.Hidden;
            Rob2.Visibility = Visibility.Hidden;
            TextInter.Visibility = Visibility.Hidden;
            PlaceConsole.Visibility = Visibility.Hidden;
            Study.Visibility = Visibility.Hidden;
            TeConsole.Visibility = Visibility.Hidden;
            back1.Visibility = Visibility.Hidden;
        }
        private void Check_Click(object sender, RoutedEventArgs e)
        {
            string sC = PlaceCheck.Text.Replace(" ", "");
            if (sC == "C=K==S&&K!=M;" || sC == "C=K!=M&&K==S;"|| sC == "C=M!=K&&S==K;"|| sC == "C=S==K&&M!=K;")
            {
                Kos1.Visibility = Visibility.Hidden;
                Kos2.Visibility = Visibility.Visible;
                PlaceConsole.IsReadOnly = true;
            }
            else
            {
                MessageBox.Show("Ой! Что-то пошло не так! Попробуйте снова|" + sC + "|", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void back2_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Visible;
            L2Text.Visibility = Visibility.Visible;
            NextT.Visibility = Visibility.Visible;
            BackT.Visibility = Visibility.Visible;
            Interac1.Visibility = Visibility.Visible;
            Image10.Visibility = Visibility.Visible;
            Image11.Visibility = Visibility.Visible;
            Kos1.Visibility = Visibility.Hidden;
            Kos2.Visibility = Visibility.Hidden;
            TextInter1.Visibility = Visibility.Hidden;
            PlaceCheck.Visibility = Visibility.Hidden;
            Check.Visibility = Visibility.Hidden;
            TeC.Visibility = Visibility.Hidden;
            back2.Visibility = Visibility.Hidden;
        }
        private void Interac1_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Hidden;
            L2Text.Visibility = Visibility.Hidden;
            BackT.Visibility = Visibility.Hidden;
            NextT.Visibility = Visibility.Hidden;
            Interac1.Visibility = Visibility.Hidden;
            Image10.Visibility = Visibility.Hidden;
            Image11.Visibility = Visibility.Hidden;
            Kos1.Visibility = Visibility.Visible;
            TextInter1.Visibility = Visibility.Visible;
            PlaceCheck.Visibility = Visibility.Visible;
            Check.Visibility = Visibility.Visible;
            TeC.Visibility = Visibility.Visible;
            back2.Visibility = Visibility.Visible;
        }
    }
}
