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
    /// Логика взаимодействия для Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        private const string Level3FilePath1 = "level_3.txt";
        public int k = 0;
        public int[] M = new[] {149, 168, 293, 76, 95, 105};
        public int i = 0;
        public Window8()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            MaxHeight = 495;
            MaxWidth = 500;
            MinHeight = 495;
            MinWidth = 500;
            L3Text.IsReadOnly = true;
            TextCat.IsReadOnly = true;
            TextCalcul.IsReadOnly = true;
            PlaceDigat.IsReadOnly = true;
        }
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            image1.Visibility = Visibility.Visible;
            Image2.Visibility = Visibility.Visible;
            ImaInstrum.Visibility = Visibility.Hidden;
            L3Text.Visibility = Visibility.Visible;
            L3Text.Clear();
            Interac.Visibility = Visibility.Visible;
            try
            {
                string text = File.ReadAllText(Level3FilePath1);
                while (i < M[k])
                {
                    L3Text.Text += Convert.ToString(text[i]);
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
                L3Text.Text = "";
                k += 1;
                if (k == 1)
                {
                    image1.Visibility = Visibility.Hidden;
                    Image2.Visibility = Visibility.Hidden;
                    Interac.Visibility = Visibility.Hidden;
                    Image3.Visibility = Visibility.Visible;
                    Image4.Visibility = Visibility.Visible;
                }
                if (k == 2)
                {
                    Image3.Visibility = Visibility.Hidden;
                    Image4.Visibility = Visibility.Hidden;
                    Image5.Visibility = Visibility.Visible;
                    Image6.Visibility = Visibility.Visible;
                }
                if (k == 3)
                {
                    Image5.Visibility = Visibility.Hidden;
                    Image6.Visibility = Visibility.Hidden;
                    Image7.Visibility = Visibility.Visible;
                    Image8.Visibility = Visibility.Visible;
                }
                if (k == 4)
                {
                    Image7.Visibility = Visibility.Hidden;
                    Image8.Visibility = Visibility.Hidden;
                    Image9.Visibility = Visibility.Visible;
                    Image10.Visibility = Visibility.Visible;
                    Interac1.Visibility = Visibility.Visible;
                }
                else
                {
                    Interac1.Visibility = Visibility.Hidden;
                }
                if (k == 5)
                {
                    Image9.Visibility = Visibility.Hidden;
                    Image10.Visibility = Visibility.Hidden;
                    Image11.Visibility = Visibility.Visible;
                    Image12.Visibility = Visibility.Visible;
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
                    Interac1.Visibility = Visibility.Visible;
                }
                for (int j = 0; j <= k; j++)
                {
                    s += M[j];
                }
                string text = File.ReadAllText(Level3FilePath1);
                while (i < s)
                {
                    L3Text.Text += Convert.ToString(text[i]);
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
                    Interac.Visibility = Visibility.Visible;
                    Image3.Visibility = Visibility.Hidden;
                    Image4.Visibility = Visibility.Hidden;
                    BackT.Visibility = Visibility.Hidden;
                }
                if (k == 1)
                {
                    Image3.Visibility = Visibility.Visible;
                    Image4.Visibility = Visibility.Visible;
                    Image5.Visibility = Visibility.Hidden;
                    Image6.Visibility = Visibility.Hidden;
                }
                if (k == 2)
                {
                    Image5.Visibility = Visibility.Visible;
                    Image6.Visibility = Visibility.Visible;
                    Image7.Visibility = Visibility.Hidden;
                    Image8.Visibility = Visibility.Hidden;
                }
                if (k == 3)
                {
                    Image7.Visibility = Visibility.Visible;
                    Image8.Visibility = Visibility.Visible;
                    Image9.Visibility = Visibility.Hidden;
                    Image10.Visibility = Visibility.Hidden;
                }
                if (k == 4)
                {
                    Image9.Visibility = Visibility.Visible;
                    Image10.Visibility = Visibility.Visible;
                    Image11.Visibility = Visibility.Hidden;
                    Image12.Visibility = Visibility.Hidden;
                    NextT.Visibility = Visibility.Visible;
                    Interac1.Visibility = Visibility.Visible;
                }
                else
                {
                    Interac1.Visibility= Visibility.Hidden;
                }
                if (k != 5)
                {
                    Test.Visibility = Visibility.Hidden;
                    NextT.Visibility = Visibility.Visible;
                }
                int s = 0;
                L3Text.Text = "";
                if (i == 1)
                {
                    BackT.Visibility = Visibility.Hidden;
                }
                for (int j = 0; j <= k; j++)
                {
                    s += M[j];
                }
                i = s - M[k];
                string text = File.ReadAllText(Level3FilePath1);
                while (i < s)
                {
                    L3Text.Text += Convert.ToString(text[i]);
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
                Window9 newWin = new Window9();
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
            L3Text.Visibility = Visibility.Hidden;
            BackT.Visibility = Visibility.Hidden;
            NextT.Visibility = Visibility.Hidden;
            Interac.Visibility = Visibility.Hidden;
            image1.Visibility = Visibility.Hidden;
            Image2.Visibility = Visibility.Hidden;
            K1.Visibility = Visibility.Visible;
            TextCat.Visibility = Visibility.Visible;
            PlaceIF.Visibility = Visibility.Visible;
            PlaceT.Visibility = Visibility.Visible;
            PlaceF.Visibility = Visibility.Visible;
            Check.Visibility = Visibility.Visible;
            TeIF.Visibility = Visibility.Visible;
            TeT.Visibility = Visibility.Visible;
            TeF.Visibility = Visibility.Visible;
            back1.Visibility = Visibility.Visible;
            Val.Visibility = Visibility.Visible;
        }
        private void Check_Click(object sender, RoutedEventArgs e)
        {
            string sIF = PlaceIF.Text.Replace(" ", "");
            string sT = PlaceT.Text.Replace(" ", "");
            string sF = PlaceF.Text.Replace(" ", "");
            if (sIF == "if(A==\"Хочукушать\")"&& (sT=="Console.WriteLine(\"Хочукушать\");"|| sT == "Console.Write(\"Хочукушать\");")&& (sF == "Console.WriteLine(\"Нехочукушать\");" || sF == "Console.Write(\"Нехочукушать\");"))
            {

                PlaceIF.IsReadOnly = true;
                PlaceT.IsReadOnly = true;
                PlaceF.IsReadOnly = true;
                if (Val.Text == "Хочу кушать")
                {
                    K2.Visibility = Visibility.Visible;
                    K3.Visibility = Visibility.Hidden;
                }
                else if (Val.Text == "Не хочу кушать")
                {
                    K3.Visibility = Visibility.Visible;
                    K2.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("Ой! Что-то пошло не так! Попробуйте снова", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Ой! Что-то пошло не так! Попробуйте снова!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void back1_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Visible;
            L3Text.Visibility = Visibility.Visible;
            NextT.Visibility = Visibility.Visible;
            Interac.Visibility = Visibility.Visible;
            image1.Visibility = Visibility.Visible;
            Image2.Visibility = Visibility.Visible;
            K1.Visibility = Visibility.Hidden;
            K2.Visibility = Visibility.Hidden;
            K3.Visibility = Visibility.Hidden;
            TextCat.Visibility = Visibility.Hidden;
            PlaceIF.Visibility = Visibility.Hidden;
            PlaceT.Visibility = Visibility.Hidden;
            PlaceF.Visibility = Visibility.Hidden;
            Check.Visibility = Visibility.Hidden;
            TeIF.Visibility = Visibility.Hidden;
            TeT.Visibility = Visibility.Hidden;
            TeF.Visibility = Visibility.Hidden;
            back1.Visibility = Visibility.Hidden;
            Val.Visibility = Visibility.Hidden;
        }
        private void Interac1_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Hidden;
            L3Text.Visibility = Visibility.Hidden;
            BackT.Visibility = Visibility.Hidden;
            NextT.Visibility = Visibility.Hidden;
            Interac1.Visibility = Visibility.Hidden;
            Image9.Visibility = Visibility.Hidden;
            Image10.Visibility = Visibility.Hidden;
            Rob1.Visibility = Visibility.Visible;
            TextCalcul.Visibility = Visibility.Visible;
            PlaceFOR.Visibility = Visibility.Visible;
            PlaceBody.Visibility = Visibility.Visible;
            Calcul.Visibility = Visibility.Visible;
            TeFOR.Visibility = Visibility.Visible;
            TeBody.Visibility = Visibility.Visible;
            back2.Visibility = Visibility.Visible;
            ValueCalc.Visibility = Visibility.Visible;
            PlaceDigat.Visibility = Visibility.Visible;
        }
        private void Calcul_Click(object sender, RoutedEventArgs e)
        {
            string sFOR = PlaceFOR.Text.Replace(" ", "");
            string sBody = PlaceBody.Text.Replace(" ", "");
            if ((sFOR == "for(inti=1;i<10;i++)" || sFOR == "for(i=1;i<=9;i++)") && (sBody == "Console.WriteLine(K*i);" || sBody == "Console.WriteLine(i*K);")) 
            {
                PlaceFOR.IsReadOnly = true;
                PlaceBody.IsReadOnly = true;
                Rob1.Visibility= Visibility.Hidden;
                Rob2.Visibility = Visibility.Visible;
                PlaceDigat.Text = null;
                for (int i = 1; i < 10; i++)  
                {
                    PlaceDigat.Text += (i * Convert.ToInt32(ValueCalc.Text)) + "\n";
                }
            }
            else
            {
                MessageBox.Show("Ой! Что-то пошло не так! Попробуйте снова!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void back2_Click(object sender, RoutedEventArgs e)
        {
            Back.Visibility = Visibility.Visible;
            L3Text.Visibility = Visibility.Visible;
            BackT.Visibility = Visibility.Visible;
            NextT.Visibility = Visibility.Visible;
            Interac1.Visibility = Visibility.Visible;
            Image9.Visibility = Visibility.Visible;
            Image10.Visibility = Visibility.Visible;
            Rob1.Visibility = Visibility.Hidden;
            Rob2.Visibility = Visibility.Hidden;
            TextCalcul.Visibility = Visibility.Hidden;
            PlaceFOR.Visibility = Visibility.Hidden;
            PlaceBody.Visibility = Visibility.Hidden;
            Calcul.Visibility = Visibility.Hidden;
            TeFOR.Visibility = Visibility.Hidden;
            TeBody.Visibility = Visibility.Hidden;
            back2.Visibility = Visibility.Hidden;
            ValueCalc.Visibility = Visibility.Hidden;
            PlaceDigat.Visibility = Visibility.Hidden;
        }
    }
}
