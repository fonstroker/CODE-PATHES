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
using System.Windows.Media.Animation;
namespace Приложение
{
    public partial class Window3 : Window
    {
        private const string Level1FilePath2 = "level1.txt";
        public int k = 0;
        public int[] M = new[] { 290, 82, 229, 164 };
        public int i = 0;
        public Window3()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            MaxHeight = 495;
            MaxWidth = 500;
            MinWidth = 500;
            MinHeight = 495;
            L1Text.IsReadOnly = true;
            TextKoster.IsReadOnly = true;
            TextInter.IsReadOnly = true;
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
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            ImaPer.Visibility = Visibility.Hidden;
            L1Text.Visibility = Visibility.Visible;
            L1Text.Clear();
            try
            {
                string text = File.ReadAllText(Level1FilePath2);
                while (i < M[k])
                {
                    L1Text.Text += Convert.ToString(text[i]);
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
                L1Text.Text = "";
                k += 1;
                if (k == 0)
                {
                    Image1.Visibility = Visibility.Hidden;
                }
                if (k == 1)
                {
                    Image1.Visibility = Visibility.Visible;
                }
                if (k == 2)
                {
                    Image2.Visibility = Visibility.Visible;
                    Image1.Visibility = Visibility.Hidden;
                    Interac.Visibility = Visibility.Visible;
                }
                if (k == 3)
                {
                    NextT.Visibility = Visibility.Hidden;
                    Image3.Visibility = Visibility.Visible;
                    Image2.Visibility = Visibility.Hidden;
                    Interac.Visibility = Visibility.Hidden;
                    Test.Visibility = Visibility.Visible;
                    Interac1.Visibility = Visibility.Visible;
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
                }
                for (int j = 0; j <= k; j++)
                {
                    s += M[j];
                }
                string text = File.ReadAllText(Level1FilePath2);
                while (i < s)
                {
                    L1Text.Text += Convert.ToString(text[i]);
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
                if (k == 3)
                {
                    NextT.Visibility = Visibility.Hidden;
                    Image3.Visibility = Visibility.Visible;
                    Image2.Visibility = Visibility.Hidden;
                    Test.Visibility = Visibility.Visible;
                }
                if (k != 3)
                {
                    Test.Visibility = Visibility.Hidden;
                    NextT.Visibility = Visibility.Visible;
                }
                if (k == 0)
                {
                    Image1.Visibility = Visibility.Hidden;
                    BackT.Visibility = Visibility.Hidden;
                }
                if (k == 1)
                {
                    Image1.Visibility = Visibility.Visible;
                    Image2.Visibility = Visibility.Hidden;
                }
                if (k == 2)
                {
                    Interac.Visibility = Visibility.Visible;
                    Image2.Visibility = Visibility.Visible;
                    Image3.Visibility = Visibility.Hidden;
                }
                else 
                { 
                    Interac.Visibility = Visibility.Hidden; 
                }
                if (k == 3)
                {
                    Image3.Visibility = Visibility.Visible;
                    Image2.Visibility = Visibility.Hidden;
                }
                else
                {
                    Interac1.Visibility = Visibility.Hidden;
                }
                int s = 0;
                L1Text.Text = "";
                if (i == 1)
                {
                    BackT.Visibility = Visibility.Hidden;
                }
                for (int j = 0; j <= k; j++)
                {
                    s += M[j];
                }
                i = s - M[k];

                string text = File.ReadAllText(Level1FilePath2);
                while (i < s)
                {
                    L1Text.Text += Convert.ToString(text[i]);
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
                Window4 newWin = new Window4();
                this.Close();
                newWin.ShowDialog();
                this.Show();
            }
            catch { }
        }
        private void Interac_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Hidden;
            L1Text.Visibility = Visibility.Hidden;
            BackT.Visibility = Visibility.Hidden;
            NextT.Visibility = Visibility.Hidden;
            Interac.Visibility = Visibility.Hidden;
            Image2.Visibility = Visibility.Hidden;
            Rob2.Visibility = Visibility.Visible;
            TextInter.Visibility = Visibility.Visible;
            Placeg.Visibility = Visibility.Visible;
            PlaceM.Visibility = Visibility.Visible;
            Check.Visibility = Visibility.Visible;
            TeM.Visibility = Visibility.Visible;
            Teg.Visibility = Visibility.Visible;
            back1.Visibility = Visibility.Visible;
        }
        private void back1_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Visible;
            L1Text.Visibility = Visibility.Visible;
            BackT.Visibility = Visibility.Visible;
            NextT.Visibility = Visibility.Visible;
            Interac.Visibility = Visibility.Visible;
            Image2.Visibility = Visibility.Visible;
            Rob1.Visibility = Visibility.Hidden;
            Rob2.Visibility = Visibility.Hidden;
            TextInter.Visibility = Visibility.Hidden;
            Placeg.Visibility = Visibility.Hidden;
            PlaceM.Visibility = Visibility.Hidden;
            Check.Visibility = Visibility.Hidden;
            TeM.Visibility = Visibility.Hidden;
            Teg.Visibility = Visibility.Hidden;
            back1.Visibility = Visibility.Hidden;
        }
        private void Check_Click(object sender, RoutedEventArgs e)
        {
            string sg = Placeg.Text.Replace(" ", ""), sM = PlaceM.Text.Replace(" ", "");
            if (sM == "intM=2;" && sg == "intg=7;") 
            {
                Rob2.Visibility= Visibility.Hidden;
                Rob1.Visibility= Visibility.Visible;
                Placeg.IsReadOnly= true;
                PlaceM.IsReadOnly = true;
            }
            else 
            {
                MessageBox.Show("Ой! Что-то пошло не так! Попробуйте снова", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Check1_Click(object sender, RoutedEventArgs e)
        {
            string sK = PlaceK.Text.Replace(" ", "");
            if (sK == "K=Convert.ToInt32(M);")
            {
                Kos1.Visibility = Visibility.Hidden;
                Kos2.Visibility = Visibility.Visible;
                Metal.Visibility = Visibility.Hidden;
                Tree.Visibility = Visibility.Visible;
                PlaceK.IsReadOnly = true;
            }
            else
            {
                MessageBox.Show("Ой! Что-то пошло не так! Попробуйте снова", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Interac1_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Hidden;
            L1Text.Visibility = Visibility.Hidden;
            BackT.Visibility = Visibility.Hidden;
            NextT.Visibility = Visibility.Hidden;
            Interac1.Visibility = Visibility.Hidden;
            Image3.Visibility = Visibility.Hidden;
            Metal.Visibility = Visibility.Visible;
            Kos1.Visibility = Visibility.Visible;
            TextKoster.Visibility = Visibility.Visible;
            PlaceK.Visibility = Visibility.Visible;
            Check1.Visibility = Visibility.Visible;
            TeK.Visibility = Visibility.Visible;
            back2.Visibility = Visibility.Visible;
            Test.Visibility = Visibility.Hidden;
        }
        private void back2_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Visible;
            L1Text.Visibility = Visibility.Visible;
            BackT.Visibility = Visibility.Visible;
            Interac1.Visibility = Visibility.Visible;
            Image3.Visibility = Visibility.Visible;
            Test.Visibility = Visibility.Visible;
            Metal.Visibility = Visibility.Hidden;
            Tree.Visibility = Visibility.Hidden;
            Kos1.Visibility = Visibility.Hidden;
            Kos2.Visibility = Visibility.Hidden;
            TextKoster.Visibility = Visibility.Hidden;
            PlaceK.Visibility = Visibility.Hidden;
            Check1.Visibility = Visibility.Hidden;
            TeK.Visibility = Visibility.Hidden;
            back2.Visibility = Visibility.Hidden;
        }
    }
}
