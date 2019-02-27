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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            this.DragMove();

        }

     

        private void btnStudent_Click(object sender, RoutedEventArgs e)
        {
            Profile pr = new Profile();
            pr.ShowDialog();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnManagement_Click(object sender, RoutedEventArgs e)
        {
            Management mn = new Management();
            mn.ShowDialog();
        }
    }
}
