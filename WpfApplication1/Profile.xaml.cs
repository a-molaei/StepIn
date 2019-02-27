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
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtCode.Text.Trim() == "" || txtName.Text.Trim() == "" || txtFamily.Text.Trim() == "")
                {
                    MessageBox.Show("لطفاً سه فیلد اول را کامل وارد کنید!", "اطلاعات ناقص!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {

                    stl.Code = Convert.ToInt32(txtCode.Text);
                    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + System.AppDomain.CurrentDomain.BaseDirectory + "/test.accdb");
                    OleDbCommand cmd = new OleDbCommand("insert into Student (ID, name, family, mail, registrationdate)  values (" + stl.Code + ",'" + txtName.Text + "','" + txtFamily.Text + "', '" + txtMail.Text + "','" + DateTime.Now + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MainWindow mw = new MainWindow();
                    mw.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("لطفاً اطلاعات را صحیح وارد نمایید!", "اخطار!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
         
        }
    }
}
