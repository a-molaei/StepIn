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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
using System.Data.OleDb;
using System.Data;
using Stimulsoft.Report;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PlacementForm dr = new PlacementForm();
            dr.ShowDialog();

            btnPlacement.Background = Brushes.Green;
            btnPlacement.IsEnabled = false;
         
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NeedAnalysisForm ans = new NeedAnalysisForm();
            ans.ShowDialog();
            btnNeeds.Background = Brushes.Green;
            btnNeeds.IsEnabled = false;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            LearnersTypeForm lfrm = new LearnersTypeForm();
            lfrm.ShowDialog();
            btnType.Background = Brushes.Green;
            btnType.IsEnabled = false;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            LearnersStyleForm lsfrm = new LearnersStyleForm();
            lsfrm.ShowDialog();
            btnStyle.Background = Brushes.Green;
            btnStyle.IsEnabled = false;
        }

        private void Grid_ContextMenuClosing_1(object sender, ContextMenuEventArgs e)
        {

        }

        private void btnR_Click(object sender, RoutedEventArgs e)
        {
            string str = "";
            if (stl.Style == "حسی")
                str = "Reporthesi.mrt";
            if (stl.Style == "بصری")
                str = "Reportsami.mrt";
            if (stl.Style == "سمعی")
                str = "Reportbasari.mrt";
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + System.AppDomain.CurrentDomain.BaseDirectory + "/test.accdb");
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Student where ID="+stl.Code, con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dt.TableName = "Student";
            con.Close();
            StiReport st = new StiReport();
            st.Load(System.AppDomain.CurrentDomain.BaseDirectory + "/Reportneeds.mrt");
            st.RegData(dt);
            st.Dictionary.Synchronize();
            st.Show();

            OleDbDataAdapter da2 = new OleDbDataAdapter("select name, family, style, type from Student where ID=" + stl.Code, con);
            DataTable dt2 = new DataTable();
            con.Open();
            da2.Fill(dt2);
            dt2.TableName = "Student";
            con.Close();
            StiReport st2 = new StiReport();
            st2.Load(System.AppDomain.CurrentDomain.BaseDirectory + "/" + str);
            st2.RegData(dt2);
            st2.Dictionary.Synchronize();
            st2.Show();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
