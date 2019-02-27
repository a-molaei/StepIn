using System;
using System.Collections.Generic;
using System.Data.OleDb;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for PlacementForm.xaml
    /// </summary>
    public partial class PlacementForm : Window
    {
        public PlacementForm()
        {
            InitializeComponent();
        }
        int counter1 = 0;
        int counter2 = 0;
        int counter3 = 0;
        int counter4 = 0;
        int counter5 = 0;
        int counter6 = 0;
        int counter7 = 0;
        int counter8 = 0;
        int counter9 = 0;
        bool flag = true;
        private void btnPlay1_Click(object sender, RoutedEventArgs e)
        {
            if (counter1 == 0 && flag)
            {
                flag = false;
                grpx1.Background = Brushes.Tan;
                btnPlay1.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WpfApplication1;component/Resources/Pause.png")));
                // btnPlay.Background = new ImageBrush(new BitmapImage(new Uri(@"/Resources/Pause.png")));
                listening1.Play();
                counter1 = 1;
            }      
        }

        private void listening1_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (counter1 == 1)
            {
                listening1.Stop();
                listening1.Position = TimeSpan.Zero;
                listening1.Play();
                counter1 = 2;
            }
            else
            {
                flag = true;
                grpx1.Background = Brushes.LightGreen;
                btnPlay1.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WpfApplication1;component/Resources/Play.png")));


            }
        }

        private void btnPlay2_Click(object sender, RoutedEventArgs e)
        {
            if (counter2 == 0 && flag)
            {
                flag = false;
                grpx2.Background = Brushes.Tan;
                btnPlay2.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WpfApplication1;component/Resources/Pause.png")));
                listening2.Play();
                counter2 = 1;
            }      

        }

        private void btnPlay3_Click(object sender, RoutedEventArgs e)
        {
            if (counter3 == 0 && flag)
            {
                flag = false;
                grpx3.Background = Brushes.Tan;
                btnPlay3.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WpfApplication1;component/Resources/Pause.png")));
                listening3.Play();
                counter3 = 1;
            }
        }

        private void btnPlay4_Click(object sender, RoutedEventArgs e)
        {
            if (counter4 == 0 && flag)
            {
                flag = false;
                grpx4.Background = Brushes.Tan;
                btnPlay4.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WpfApplication1;component/Resources/Pause.png")));
                listening4.Play();
                counter4 = 1;
            }
        }

        private void btnPlay5_Click(object sender, RoutedEventArgs e)
        {
            if (counter5 == 0 && flag)
            {
                flag = false;
                grpx5.Background = Brushes.Tan;
                btnPlay5.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WpfApplication1;component/Resources/Pause.png")));
                listening5.Play();
                counter5 = 1;
            }
        }

        private void btnPlay6_Click(object sender, RoutedEventArgs e)
        {
            if (counter6 == 0 && flag)
            {
                flag = false;
                grpx6.Background = Brushes.Tan;
                btnPlay6.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WpfApplication1;component/Resources/Pause.png")));
                listening6.Play();
                counter6 = 1;
            }
        }

        private void btnPlay7_Click(object sender, RoutedEventArgs e)
        {
            if (counter7 == 0 && flag)
            {
                flag = false;
                grpx7.Background = Brushes.Tan;
                btnPlay7.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WpfApplication1;component/Resources/Pause.png")));
                listening7.Play();
                counter7 = 1;
            }
        }

        private void btnPlay8_Click(object sender, RoutedEventArgs e)
        {
            if (counter8 == 0 && flag)
            {
                flag = false;
                grpx8.Background = Brushes.Tan;
                btnPlay8.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WpfApplication1;component/Resources/Pause.png")));
                listening8.Play();
                counter8 = 1;
            }
        }

        private void btnPlay9_Click(object sender, RoutedEventArgs e)
        {
            if (counter9 == 0 && flag)
            {
                flag = false;
                grpx9.Background = Brushes.Tan;
                btnPlay9.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WpfApplication1;component/Resources/Pause.png")));
                listening9.Play();
                counter9 = 1;
            }
        }
        private void listening2_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (counter2 == 1)
            {
                listening2.Stop();
                listening2.Position = TimeSpan.Zero;
                listening2.Play();
                counter2 = 2;
            }
            else
            {
                grpx2.Background = Brushes.LightGreen;
                btnPlay2.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WpfApplication1;component/Resources/Play.png")));


            }
        }

        private void listening3_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (counter3 == 1)
            {
                listening3.Stop();
                listening3.Position = TimeSpan.Zero;
                listening3.Play();
                counter3 = 2;
            }
            else
            {
                flag = true;

                grpx3.Background = Brushes.LightGreen;
                btnPlay3.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WpfApplication1;component/Resources/Play.png")));


            }
        }

        private void listening4_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (counter4 == 1)
            {
                listening4.Stop();
                listening4.Position = TimeSpan.Zero;
                listening4.Play();
                counter4 = 2;
            }
            else
            {
                flag = true;

                grpx4.Background = Brushes.LightGreen;
                btnPlay4.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WpfApplication1;component/Resources/Play.png")));


            }
        }

        private void listening5_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (counter5 == 1)
            {
                listening5.Stop();
                listening5.Position = TimeSpan.Zero;
                listening5.Play();
                counter5 = 2;
            }
            else
            {
                flag = true;

                grpx5.Background = Brushes.LightGreen;
                btnPlay5.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WpfApplication1;component/Resources/Play.png")));


            }
        }

        private void listening6_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (counter6 == 1)
            {
                listening6.Stop();
                listening6.Position = TimeSpan.Zero;
                listening6.Play();
                counter6 = 2;
            }
            else
            {
                flag = true;

                grpx6.Background = Brushes.LightGreen;
                btnPlay6.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WpfApplication1;component/Resources/Play.png")));


            }
        }

        private void listening7_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (counter7 == 1)
            {
                listening7.Stop();
                listening7.Position = TimeSpan.Zero;
                listening7.Play();
                counter7 = 2;
            }
            else
            {
                flag = true;

                grpx7.Background = Brushes.LightGreen;
                btnPlay7.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WpfApplication1;component/Resources/Play.png")));


            }
        }

        private void listening8_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (counter8 == 1)
            {
                listening8.Stop();
                listening8.Position = TimeSpan.Zero;
                listening8.Play();
                counter8 = 2;
            }
            else
            {
                flag = true;

                grpx8.Background = Brushes.LightGreen;
                btnPlay8.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WpfApplication1;component/Resources/Play.png")));


            }
        }

        private void listening9_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (counter9 == 1)
            {
                listening9.Stop();
                listening9.Position = TimeSpan.Zero;
                listening9.Play();
                counter9 = 2;
            }
            else
            {
                flag = true;

                grpx9.Background = Brushes.LightGreen;
                btnPlay9.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WpfApplication1;component/Resources/Play.png")));


            }
        }

        private void btnFinish_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            if (rdn13.IsChecked == true)
                sum++;
            if (rdn23.IsChecked == true)
                sum++;
            if (rdn33.IsChecked == true)
                sum++;
            if (rdn44.IsChecked == true)
                sum++;
            if (rdn53.IsChecked == true)
                sum++;
            if (rdn62.IsChecked == true)
                sum++;
            if (rdn72.IsChecked == true)
                sum++;
            if (rdn84.IsChecked == true)
                sum++;
            if (rdn94.IsChecked == true)
                sum++;
            if (rdn103.IsChecked == true)
                sum++;
            if (rdn114.IsChecked == true)
                sum++;
            if (rdn122.IsChecked == true)
                sum++;
            if (rdn133.IsChecked == true)
                sum++;
            if (rdn142.IsChecked == true)
                sum++;
            if (rdn152.IsChecked == true)
                sum++;
            if (rdn164.IsChecked == true)
                sum++;
            if (rdn172.IsChecked == true)
                sum++;
            if (rdn182.IsChecked == true)
                sum++;
            if (rdn191.IsChecked == true)
                sum++;
            if (rdn202.IsChecked == true)
                sum++;
            if (rdn211.IsChecked == true)
                sum++;
            if (rdn221.IsChecked == true)
                sum++;
            if (rdn231.IsChecked == true)
                sum++;
            if (rdn241.IsChecked == true)
                sum++;
            if (rdn253.IsChecked == true)
                sum++;
            if (rdn263.IsChecked == true)
                sum++;
            if (rdn274.IsChecked == true)
                sum++;
            if (rdn284.IsChecked == true)
                sum++;
            if (rdn293.IsChecked == true)
                sum++;
            if (rdn304.IsChecked == true)
                sum++;
            if (rdn312.IsChecked == true)
                sum++;
            if (rdn323.IsChecked == true)
                sum++;
            if (rdn331.IsChecked == true)
                sum++;
            if (rdn342.IsChecked == true)
                sum++;
            if (rdn353.IsChecked == true)
                sum++;
            if (rdn363.IsChecked == true)
                sum++;
            if (rdn373.IsChecked == true)
                sum++;
            if (rdn383.IsChecked == true)
                sum++;
            if (rdn394.IsChecked == true)
                sum++;
            if (rdn404.IsChecked == true)
                sum++;
            if (rdn413.IsChecked == true)
                sum++;
            if (rdn421.IsChecked == true)
                sum++;
            if (rdn432.IsChecked == true)
                sum++;
            if (rdn442.IsChecked == true)
                sum++;
            if (rdn451.IsChecked == true)
                sum++;
            if (rdn463.IsChecked == true)
                sum++;
            if (rdn474.IsChecked == true)
                sum++;
            if (rdn484.IsChecked == true)
                sum++;
            if (rdn492.IsChecked == true)
                sum++;
            if (rdn503.IsChecked == true)
                sum++;
            if (rdn512.IsChecked == true)
                sum++;
            if (rdn522.IsChecked == true)
                sum++;
            if (rdn531.IsChecked == true)
                sum++;
            if (rdn542.IsChecked == true)
                sum++;
            if (rdn551.IsChecked == true)
                sum++;
            if (rdn562.IsChecked == true)
                sum++;
            if (rdn573.IsChecked == true)
                sum++;
            if (rdn583.IsChecked == true)
                sum++;
            if (rdn592.IsChecked == true)
                sum++;
            if (rdn604.IsChecked == true)
                sum++;
            if (rdn614.IsChecked == true)
                sum++;
            if (rdn622.IsChecked == true)
                sum++;
            if (rdn634.IsChecked == true)
                sum++;
            if (rdn643.IsChecked == true)
                sum++;
            if (rdn653.IsChecked == true)
                sum++;
            if (rdn661.IsChecked == true)
                sum++;
            if (rdn672.IsChecked == true)
                sum++;
            if (rdn683.IsChecked == true)
                sum++;
            if (rdn694.IsChecked == true)
                sum++;
            if (rdn703.IsChecked == true)
                sum++;
            string level = "";

            if (sum < 12)
                level = "Starter";
            else if (sum < 24)
                level = "Elementary";
            else if (sum < 37)
                level = "Pre-Intermidiate";
            else if (sum < 50)
                level = "Intermediate";
            else if (sum < 52)
                level = "Upper-Intermidiate";
            else if (sum < 71)
                level = "Advanced";
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + System.AppDomain.CurrentDomain.BaseDirectory + "/test.accdb");
            OleDbCommand cmd = new OleDbCommand("update Student set reallevel ='" + level + "' where ID=" + stl.Code, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
        }

        private void listening1_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }
    }
}
