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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Management.xaml
    /// </summary>
    public partial class Management : Window
    {
        public Management()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + System.AppDomain.CurrentDomain.BaseDirectory + "/test.accdb");
                OleDbDataAdapter da = new OleDbDataAdapter("select ID, name from Student where name='" + txtName.Text + "'", con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                gridSearch.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong name!");
            }
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OleDbConnection con3 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + System.AppDomain.CurrentDomain.BaseDirectory + "/test.accdb");
                OleDbDataAdapter da3 = new OleDbDataAdapter("select style from Student where ID=" + Convert.ToInt32(txtID.Text), con3);
                DataTable dt3 = new DataTable();
                con3.Open();
                da3.Fill(dt3);
                con3.Close();
                string str = dt3.Rows[0][0].ToString();

                if (str == "حسی")
                    str = "Reporthesi.mrt";
                if (str == "بصری")
                    str = "Reportsami.mrt";
                if (str == "سمعی")
                    str = "Reportbasari.mrt";
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + System.AppDomain.CurrentDomain.BaseDirectory + "/test.accdb");
                OleDbDataAdapter da = new OleDbDataAdapter("select * from Student where ID=" + Convert.ToInt32(txtID.Text), con);
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

                OleDbDataAdapter da2 = new OleDbDataAdapter("select name, family, style, type from Student where ID=" + Convert.ToInt32(txtID.Text), con);
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
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
