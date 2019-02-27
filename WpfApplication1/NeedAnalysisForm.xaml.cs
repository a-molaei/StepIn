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
    /// Interaction logic for NeedAnalysisForm.xaml
    /// </summary>
    public partial class NeedAnalysisForm : Window
    {
        public NeedAnalysisForm()
        {
            InitializeComponent();
         
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                //useful
                string usefulness = null;
                if (rdnt1q11.IsChecked == true)
                {
                    usefulness = usefulness + lblt1q1.Content + ", ";
                }
                if (rdnt1q21.IsChecked == true)
                {
                    usefulness = usefulness + lblt1q2.Content + ", ";
                }
                if (rdnt1q31.IsChecked == true)
                {
                    usefulness = usefulness + lblt1q3.Content + ", ";
                }
                if (rdnt1q41.IsChecked == true)
                {
                    usefulness = usefulness + lblt1q4.Content + ", ";
                }
                if (rdnt1q51.IsChecked == true)
                {
                    usefulness = usefulness + lblt1q5.Content + ", ";
                }
                if (rdnt1q61.IsChecked == true)
                {
                    usefulness = usefulness + lblt1q6.Content + ", ";
                }
                if (rdnt1q71.IsChecked == true)
                {
                    usefulness = usefulness + lblt1q7.Content + ", ";
                }
                if (rdnt1q81.IsChecked == true)
                {
                    usefulness = usefulness + lblt1q8.Content + ", ";
                }
                if (rdnt1q91.IsChecked == true)
                {
                    usefulness = usefulness + lblt1q9.Content + ", ";
                }
                if (rdnt1q101.IsChecked == true)
                {
                    usefulness = usefulness + lblt1q10.Content + ", ";
                }

                //unuseful
                string unusefulness = null;
                if (rdnt1q12.IsChecked == true)
                {
                    unusefulness = unusefulness + lblt1q1.Content + ", ";
                }
                if (rdnt1q22.IsChecked == true)
                {
                    unusefulness = unusefulness + lblt1q2.Content + ", ";
                }
                if (rdnt1q32.IsChecked == true)
                {
                    unusefulness = unusefulness + lblt1q3.Content + ", ";
                }
                if (rdnt1q42.IsChecked == true)
                {
                    unusefulness = unusefulness + lblt1q4.Content + ", ";
                }
                if (rdnt1q52.IsChecked == true)
                {
                    unusefulness = unusefulness + lblt1q5.Content + ", ";
                }
                if (rdnt1q62.IsChecked == true)
                {
                    unusefulness = unusefulness + lblt1q6.Content + ", ";
                }
                if (rdnt1q72.IsChecked == true)
                {
                    unusefulness = unusefulness + lblt1q7.Content + ", ";
                }
                if (rdnt1q82.IsChecked == true)
                {
                    unusefulness = unusefulness + lblt1q8.Content + ", ";
                }
                if (rdnt1q92.IsChecked == true)
                {
                    unusefulness = unusefulness + lblt1q9.Content + ", ";
                }
                if (rdnt1q102.IsChecked == true)
                {
                    unusefulness = unusefulness + lblt1q10.Content + ", ";

                }


                //level
                string level = " ";
                if (rdn131.IsChecked == true)
                    level = rdn131.Content.ToString();
                if (rdn132.IsChecked == true)
                    level = rdn132.Content.ToString();
                if (rdn133.IsChecked == true)
                    level = rdn133.Content.ToString();
                if (rdn134.IsChecked == true)
                    level = rdn134.Content.ToString();
                if (rdn135.IsChecked == true)
                    level = rdn135.Content.ToString();
                if (rdn136.IsChecked == true)
                    level = rdn136.Content.ToString();


                //very true
                string verytrue = " ";
                if (rdnt2q11.IsChecked == true)
                {
                    verytrue = verytrue + lblt2q1.Content + ", ";
                }
                if (rdnt2q21.IsChecked == true)
                {
                    verytrue = verytrue + lblt2q2.Content + ", ";
                }
                if (rdnt2q31.IsChecked == true)
                {
                    verytrue = verytrue + lblt2q3.Content + ", ";
                }
                if (rdnt2q41.IsChecked == true)
                {
                    verytrue = verytrue + lblt2q4.Content + ", ";
                }
                if (rdnt2q51.IsChecked == true)
                {
                    verytrue = verytrue + lblt2q5.Content + ", ";
                }
                if (rdnt2q61.IsChecked == true)
                {
                    verytrue = verytrue + lblt2q6.Content + ", ";
                }
                if (rdnt2q71.IsChecked == true)
                {
                    verytrue = verytrue + lblt2q7.Content + ", ";
                }

                string sometrue = " ";
                if (rdnt2q12.IsChecked == true)
                {
                    sometrue = sometrue + lblt2q1.Content + ", ";
                }
                if (rdnt2q22.IsChecked == true)
                {
                    sometrue = sometrue + lblt2q2.Content + ", ";
                }
                if (rdnt2q32.IsChecked == true)
                {
                    sometrue = sometrue + lblt2q3.Content + ", ";
                }
                if (rdnt2q42.IsChecked == true)
                {
                    sometrue = sometrue + lblt2q4.Content + ", ";
                }
                if (rdnt2q52.IsChecked == true)
                {
                    sometrue = sometrue + lblt2q5.Content + ", ";
                }
                if (rdnt2q62.IsChecked == true)
                {
                    sometrue = sometrue + lblt2q6.Content + ", ";
                }
                if (rdnt2q72.IsChecked == true)
                {
                    sometrue = sometrue + lblt2q7.Content + ", ";
                }
                string nottrue = " ";
                if (rdnt2q13.IsChecked == true)
                {
                    nottrue = nottrue + lblt2q1.Content + ", ";
                }
                if (rdnt2q23.IsChecked == true)
                {
                    nottrue = nottrue + lblt2q2.Content + ", ";
                }
                if (rdnt2q33.IsChecked == true)
                {
                    nottrue = nottrue + lblt2q3.Content + ", ";
                }
                if (rdnt2q43.IsChecked == true)
                {
                    nottrue = nottrue + lblt2q4.Content + ", ";
                }
                if (rdnt2q53.IsChecked == true)
                {
                    nottrue = nottrue + lblt2q5.Content + ", ";
                }
                if (rdnt2q63.IsChecked == true)
                {
                    nottrue = nottrue + lblt2q6.Content + ", ";
                }
                if (rdnt2q73.IsChecked == true)
                {
                    nottrue = nottrue + lblt2q7.Content + ", ";
                }


                // teacher 
                string no = " ";
                if (rdnt3q11.IsChecked == true)
                {
                    no = no + lblt3q1.Content + ", ";
                }
                if (rdnt3q21.IsChecked == true)
                {
                    no = no + lblt3q2.Content + ", ";
                }
                if (rdnt3q31.IsChecked == true)
                {
                    no = no + lblt3q3.Content + ", ";
                }
                if (rdnt3q41.IsChecked == true)
                {
                    no = no + lblt3q4.Content + ", ";
                }
                if (rdnt3q51.IsChecked == true)
                {
                    no = no + lblt3q5.Content + ", ";
                }
                string little = " ";
                if (rdnt3q12.IsChecked == true)
                {
                    little = little + lblt3q1.Content + ", ";
                }
                if (rdnt3q22.IsChecked == true)
                {
                    little = little + lblt3q2.Content + ", ";
                }
                if (rdnt3q32.IsChecked == true)
                {
                    little = little + lblt3q3.Content + ", ";
                }
                if (rdnt3q42.IsChecked == true)
                {
                    little = little + lblt3q4.Content + ", ";
                }
                if (rdnt3q52.IsChecked == true)
                {
                    little = little + lblt3q5.Content + ", ";
                }
                string good = " ";
                if (rdnt3q13.IsChecked == true)
                {
                    good = good + lblt3q1.Content + ", ";
                }
                if (rdnt3q23.IsChecked == true)
                {
                    good = good + lblt3q2.Content + ", ";
                }
                if (rdnt3q33.IsChecked == true)
                {
                    good = good + lblt3q3.Content + ", ";
                }
                if (rdnt3q43.IsChecked == true)
                {
                    good = good + lblt3q4.Content + ", ";
                }
                if (rdnt3q53.IsChecked == true)
                {
                    good = good + lblt3q5.Content + ", ";
                }
                string best = " ";
                if (rdnt3q14.IsChecked == true)
                {
                    best = best + lblt3q1.Content + ", ";
                }
                if (rdnt3q24.IsChecked == true)
                {
                    best = best + lblt3q2.Content + ", ";
                }
                if (rdnt3q34.IsChecked == true)
                {
                    best = best + lblt3q3.Content + ", ";
                }
                if (rdnt3q44.IsChecked == true)
                {
                    best = best + lblt3q4.Content + ", ";
                }
                if (rdnt3q54.IsChecked == true)
                {
                    best = best + lblt3q5.Content + ", ";
                }

                // Feeling
                string feeling = " ";
                if (rdn137.IsChecked == true)
                {
                    feeling = "crying";
                }
                if (rdn138.IsChecked == true)
                {
                    feeling = "sad";
                }
                if (rdn139.IsChecked == true)
                {
                    feeling = "no feeling";
                }
                if (rdn140.IsChecked == true)
                {
                    feeling = "smile";
                }
                if (rdn141.IsChecked == true)
                {
                    feeling = "happy";
                }

                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + System.AppDomain.CurrentDomain.BaseDirectory + "/test.accdb");
                OleDbCommand cmd = new OleDbCommand("update Student set useful='" + usefulness + "' , unuseful='" + unusefulness + "' , expectedlevel ='" + level + "', years='"+ cbxYears.Text + "' , verytrue='" + verytrue + "' , sometrue='" + sometrue + "' , nottrue='" + nottrue + "' , noo='" + no + "',little='" + little + "',good='" + good + "',best='" + best + "',feeling='" + feeling + "' where ID=" + stl.Code, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           /* OleDbDataAdapter da = new OleDbDataAdapter("select * from Needs where ID=17", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dt.TableName = "Needs";
            con.Close();
            StiReport st = new StiReport();
            st.Load(System.AppDomain.CurrentDomain.BaseDirectory + "/Report2.mrt");
            st.RegData(dt);
            st.Dictionary.Synchronize();
            st.Show();*/
        }
    }
}
