using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Приложение
{
    public partial class Window1 : Window
    {
        public DispatcherTimer timer;
        public Window1()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            /*WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += Timer_Tick;
            timer.Start();*/
        }
        /*private void Timer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Timer ticked!");
        }*/
        private void Level1_Click(object sender, RoutedEventArgs e)
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

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow newWin = new MainWindow();
                this.Close();
                newWin.ShowDialog();
                this.Show();
            }
            catch  
            { 

            }
        }
    }
}



