using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            net();
        }

        int[,] map = new int[3, 3];
        int side = 0;
        bool play;
        int step;
        int x;
        int y;
        public void Logic()
        {
            Init();
        }

        private void net()
        {
            k1.IsHitTestVisible = false;
            k2.IsHitTestVisible = false;
            k3.IsHitTestVisible = false;

            k4.IsHitTestVisible = false;
            k5.IsHitTestVisible = false;
            k6.IsHitTestVisible = false;

            k7.IsHitTestVisible = false;
            k8.IsHitTestVisible = false;
            k9.IsHitTestVisible = false;
        }
        public void ochish()
        {
            k1.Background = null;
            k2.Background = null;
            k3.Background = null;

            k4.Background = null;
            k5.Background = null;
            k6.Background = null;

            k7.Background = null;
            k8.Background = null;
            k9.Background = null;
        }
        public void Init()
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    map[x, y] = 0;
                }
            }
            side = 1;
            play = true;
            step = 0;
            Finish();
        }

        public string Finish()
        {
            bool win = false;
            if (map[x, 0] == side && map[x, 1] == side && map[x, 2] == side) win = true;
            if (map[0, y] == side && map[1, y] == side && map[2, y] == side) win = true;
            if (map[0, 0] == side && map[1, 1] == side && map[2, 2] == side) win = true;
            if (map[2, 0] == side && map[1, 1] == side && map[0, 2] == side) win = true;
            if (win)
            {
                if (side == 1)
                {
                    return "winx";
                }
                else
                {
                    return "wino";
                }
            }
            else
            {
                if (step == 9)
                {
                    return "drow";
                }
                else
                {
                    return "play";
                }
            }
        }

        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            k1.IsHitTestVisible = false;
            hod(sender);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            k2.IsHitTestVisible = false;
            hod(sender);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            k3.IsHitTestVisible = false;
            hod(sender);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            k4.IsHitTestVisible = false;
            hod(sender);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            k5.IsHitTestVisible = false;
            hod(sender);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            k6.IsHitTestVisible = false;
            hod(sender);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            k7.IsHitTestVisible = false;
            hod(sender);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            k8.IsHitTestVisible = false;
            hod(sender);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            k9.IsHitTestVisible = false;
            hod(sender);

        }
        private void hod(object sender)
        {
            if (side == 1)
            {

                (sender as Button).Background = new ImageBrush(new BitmapImage(new Uri("C:\\Users\\porfi\\OneDrive\\Изображения\\Снимки экрана\\Снимок экрана_20230202_161018.png")));

            }
            else
            {
                (sender as Button).Background = new ImageBrush(new BitmapImage(new Uri("C:\\Users\\porfi\\OneDrive\\Изображения\\Снимки экрана\\Снимок экрана_20230202_161133.png")));

            }
            if (side == 1)
            {
                side = 2;
            }
            else
            {
                side = 1;
            }

        }

        private void knachalo_Click(object sender, RoutedEventArgs e)
        {
            ochish();
            k1.IsHitTestVisible = true;
            k2.IsHitTestVisible = true;
            k3.IsHitTestVisible = true;

            k4.IsHitTestVisible = true;
            k5.IsHitTestVisible = true;
            k6.IsHitTestVisible = true;

            k7.IsHitTestVisible = true;
            k8.IsHitTestVisible = true;
            k9.IsHitTestVisible = true;
        }


    }
}


