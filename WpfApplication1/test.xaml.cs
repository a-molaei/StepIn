using System;
using System.Collections.Generic;
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
    /// Interaction logic for test.xaml
    /// </summary>
    public partial class test : Window
    {
        public test()
        {
            InitializeComponent();
        }
        int counter = 0;
        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            if (counter == 0)
            {
                btnPlay.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WpfApplication1;component/Resources/Pause.png")));
                // btnPlay.Background = new ImageBrush(new BitmapImage(new Uri(@"/Resources/Pause.png")));
                me.Play();
                counter = 1;
            }       
        }

        private void me_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (counter == 1)
            {
                me.Stop();
                me.Position = TimeSpan.Zero;
                me.Play();
                counter = 2;
            }
            else
            {
             
                btnPlay.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/WpfApplication1;component/Resources/Play.png")));


            }
        }

        private void btnPlay_MouseEnter(object sender, MouseEventArgs e)
        {

        }
       
    }
}
