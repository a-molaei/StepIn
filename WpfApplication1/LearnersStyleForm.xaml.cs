using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for LearnersStyleForm.xaml
    /// </summary>
    public partial class LearnersStyleForm : Window
    {
        public LearnersStyleForm()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int visual = 0;
            int auditory = 0;
            int kinesthedic = 0;

            if (rdn11.IsChecked==true)
                visual++;
            if (rdn21.IsChecked == true)
                visual++;
            if (rdn31.IsChecked == true)
                visual++;
            if (rdn41.IsChecked == true)
                visual++;
            if (rdn51.IsChecked == true)
                visual++;
            if (rdn61.IsChecked == true)
                visual++;
            if (rdn71.IsChecked == true)
                visual++;
            if (rdn81.IsChecked == true)
                visual++;
            if (rdn91.IsChecked == true)
                visual++;
            if (cbx11.IsChecked == true)
                visual++;
            if (cbx12.IsChecked == true)
                visual++;
            if (cbx15.IsChecked == true)
                visual++;
            


            if (rdn12.IsChecked == true)
                auditory++;
            if (rdn22.IsChecked == true)
                auditory++;
            if (rdn32.IsChecked == true)
                auditory++;
            if (rdn42.IsChecked == true)
                auditory++;
            if (rdn52.IsChecked == true)
                auditory++;
            if (rdn62.IsChecked == true)
                auditory++;
            if (rdn72.IsChecked == true)
                auditory++;
            if (rdn82.IsChecked == true)
                auditory++;
            if (rdn92.IsChecked == true)
                auditory++;
            if (cbx22.IsChecked == true)
                auditory++;
            if (cbx24.IsChecked == true)
                auditory++;
            if (cbx26.IsChecked == true)
                auditory++;



            if (rdn13.IsChecked == true)
                kinesthedic++;
            if (rdn23.IsChecked == true)
                kinesthedic++;
            if (rdn33.IsChecked == true)
                kinesthedic++;
            if (rdn43.IsChecked == true)
                kinesthedic++;
            if (rdn53.IsChecked == true)
                kinesthedic++;
            if (rdn63.IsChecked == true)
                kinesthedic++;
            if (rdn73.IsChecked == true)
                kinesthedic++;
            if (rdn83.IsChecked == true)
                kinesthedic++;
            if (rdn93.IsChecked == true)
                kinesthedic++;
            if (cbx31.IsChecked == true)
                kinesthedic++;

            if (cbx33.IsChecked == true)
                kinesthedic++;
          
            
            if (cbx36.IsChecked == true)
                kinesthedic++;
            int max = visual; ;
            string maxstr  = "";
            if (max < visual)
                max = visual;
            if (visual < auditory)
                max = auditory; ;
            if (max < kinesthedic)
                max = kinesthedic; ;
            if (max == auditory)
                maxstr = "سمعی";
            if (max == kinesthedic)
                maxstr = "حسی";
            if (max == visual)
                maxstr = "بصری";
            if (visual == 0 && auditory ==0 && kinesthedic == 0)
                maxstr = "";
            stl.Style = maxstr;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + System.AppDomain.CurrentDomain.BaseDirectory + "/test.accdb");
            OleDbCommand cmd = new OleDbCommand("update Student set style ='" + maxstr + "' where ID="+stl.Code, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            this.Close();

       /*   string name="amir";
            string family="rad";

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + System.AppDomain.CurrentDomain.BaseDirectory + "/test.accdb");
            OleDbCommand cmd = new OleDbCommand("insert into stl (ID,name,family, style) values (5,'" + name + "', '"+ family+"', '" + max + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from stl where ID=5", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dt.TableName = "stl";
            con.Close();
            StiReport st = new StiReport();
            st.Load(System.AppDomain.CurrentDomain.BaseDirectory + "/Report.mrt");
            st.RegData(dt);
            st.Dictionary.Synchronize();
            st.Show(); */

        }

     

        

    
       

        private void rdn11_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx1.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx2.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx2.Visibility = Visibility.Visible;
        }

        private void rdn12_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx1.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx2.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx2.Visibility = Visibility.Visible;
        }

        private void rdn13_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx1.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx2.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx2.Visibility = Visibility.Visible;
        }


        private void rdn21_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx2.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx3.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx3.Visibility = Visibility.Visible;
        }

        private void rdn22_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx2.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx3.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx3.Visibility = Visibility.Visible;
        }

        private void rdn23_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx2.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx3.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx3.Visibility = Visibility.Visible;
        }

        private void rdn31_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx3.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx4.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx4.Visibility = Visibility.Visible;
        }

        private void rdn32_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx3.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx4.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx4.Visibility = Visibility.Visible;
        }

        private void rdn33_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx3.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx4.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx4.Visibility = Visibility.Visible;
        }

        private void rdn41_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx4.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx5.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx5.Visibility = Visibility.Visible;
        }

        private void rdn42_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx4.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx5.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx5.Visibility = Visibility.Visible;
        }

        private void rdn43_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx4.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx5.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx5.Visibility = Visibility.Visible;
        }

        private void rdn51_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx5.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx6.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx6.Visibility = Visibility.Visible;
        }

        private void rdn52_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx5.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx6.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx6.Visibility = Visibility.Visible;
        }

        private void rdn53_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx5.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx6.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx6.Visibility = Visibility.Visible;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx6.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx7.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx7.Visibility = Visibility.Visible;
        }

        private void rdn61_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx7.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx8.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx8.Visibility = Visibility.Visible;
        }

        private void rdn62_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx7.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx8.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx8.Visibility = Visibility.Visible;
        }

        private void rdn63_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx7.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx8.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx8.Visibility = Visibility.Visible;
        }

        private void rdn71_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx8.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx9.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx9.Visibility = Visibility.Visible;
        }

        private void rdn72_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx8.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx9.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx9.Visibility = Visibility.Visible;
        }

        private void rdn73_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx8.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx9.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx9.Visibility = Visibility.Visible;
        }

        private void rdn81_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx9.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx10.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx10.Visibility = Visibility.Visible;
        }

        private void rdn82_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx9.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx10.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx10.Visibility = Visibility.Visible;
        }

        private void rdn83_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx9.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx10.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx10.Visibility = Visibility.Visible;
        }

        private void rdn91_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx10.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            btn.BeginAnimation(GroupBox.OpacityProperty, c);
            btn.Visibility = Visibility.Visible;
        }

        private void rdn92_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx10.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            btn.BeginAnimation(GroupBox.OpacityProperty, c);
            btn.Visibility = Visibility.Visible;
        }

        private void rdn93_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx10.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            btn.BeginAnimation(GroupBox.OpacityProperty, c);
            btn.Visibility = Visibility.Visible;
        }

    }
}