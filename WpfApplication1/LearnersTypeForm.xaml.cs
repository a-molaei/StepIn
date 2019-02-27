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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for LearnersTypeForm.xaml
    /// </summary>
    public partial class LearnersTypeForm : Window
    {
        public LearnersTypeForm()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int typeA=0;
            int typeB = 0;
            int typeC = 0;
            int typeD = 0;


            if (rdn11.IsChecked==true)
                typeA++;
            if (rdn21.IsChecked == true)
                typeA++;
            if (rdn31.IsChecked == true)
                typeA++;
            if (rdn41.IsChecked == true)
                typeA++;
            if (rdn51.IsChecked == true)
                typeA++;
            if (rdn61.IsChecked == true)
                typeA++;
            if (rdn71.IsChecked == true)
                typeA++;
            if (rdn81.IsChecked == true)
                typeA++;
            if (rdn91.IsChecked == true)
                typeA++;
            if (rdn101.IsChecked == true)
                typeA++;


            if (rdn12.IsChecked == true)
                typeB++;
            if (rdn22.IsChecked == true)
                typeB++;
            if (rdn32.IsChecked == true)
                typeB++;
            if (rdn42.IsChecked == true)
                typeB++;
            if (rdn52.IsChecked == true)
                typeB++;
            if (rdn62.IsChecked == true)
                typeB++;
            if (rdn72.IsChecked == true)
                typeB++;
            if (rdn82.IsChecked == true)
                typeB++;
            if (rdn92.IsChecked == true)
                typeB++;
            if (rdn102.IsChecked == true)
                typeB++;


            if (rdn13.IsChecked == true)
                typeC++;
            if (rdn23.IsChecked == true)
                typeC++;
            if (rdn33.IsChecked == true)
                typeC++;
            if (rdn43.IsChecked == true)
                typeC++;
            if (rdn53.IsChecked == true)
                typeC++;
            if (rdn63.IsChecked == true)
                typeC++;
            if (rdn73.IsChecked == true)
                typeC++;
            if (rdn83.IsChecked == true)
                typeC++;
            if (rdn93.IsChecked == true)
                typeC++;
            if (rdn103.IsChecked == true)
                typeC++;


            if (rdn14.IsChecked == true)
                typeD++;
            if (rdn24.IsChecked == true)
                typeD++;
            if (rdn34.IsChecked == true)
                typeD++;
            if (rdn44.IsChecked == true)
                typeD++;
            if (rdn54.IsChecked == true)
                typeD++;
            if (rdn64.IsChecked == true)
                typeD++;
            if (rdn74.IsChecked == true)
                typeD++;
            if (rdn84.IsChecked == true)
                typeD++;
            if (rdn94.IsChecked == true)
                typeD++;
            if (rdn104.IsChecked == true)
                typeD++;

            string maxstr="";
            string typename = "";
            int max = typeA;
            if (max < typeB)
                max = typeB; ;
            if (max < typeC)
                max = typeC; ;
            if (max < typeD)
                max = typeD;
            if (max == typeA)
            {
                maxstr = "از نظر نوع زبان آموزی شما در دسته شغلی قرار می گیرید. شما به واسطه شغل خود به ایجاد ارتباط با زبان انگلیسی علاقه دارید. شما نیاز دارید تا به شکل صحیح زبان استفاده شده در شغل خود ازجمله نامه نگاری، لغات و غیره واقف باشید. مواردی مانند گفتار عامیانه، گرامرهای پیشرفته و امثالهم برای شما مفید نیستند. به اینترنت مراجعه کنید و انواع نامه های انگلیسی مانند درخواست نامه، شکایت نامه و غیره را بیاموزید. سعی کنید لغات مربوط به شغل خود را بیاموزید (تمام این لغات در اینترنت موجود هستند).";
                typename = "A";
            }
            if (max == typeB)
            {
                maxstr = "از نظر نوع زبان آموزی شما در دسته عمومی قرار می گیرید. شما به ارتباط برقرار کردن با زبان انگلیسی علاقه دارید. فرهنگ آمریکایی و بریتانیایی برای شما اهمیتی ندارد، زیرا شما فقط به ایجاد ارتباط با زبان انگلیسی اهمیت می دهید. شما ممکن است با افرادی از قسمت¬های مختلف جهان ارتباط داشته باشید. مواردی مانند اصطلاحات و ضرب المثل¬ها زیاد برای شما مفید نیستند. کتاب های سیستماتیکی که در مؤسسات تدریس می¬شوند برای شما بسیار مناسب هستند و سعی کنید که در بحث¬های آزاد نیز شرکت کنید.";
                typename = "B";

            }
            if (max == typeC)
            {
                typename = "C";

                maxstr = "از نظر نوع زبان آموزی شما در دسته محیطی قرار می گیرید. دلیل علاقه شما به یادگیری زبان، زندگی در کشوری انگلیسی زبان است. شما نیاز دارید که تلفظ خوبی داشته باشید و اصطلاحات و همچنین عبارات عامیانه را به خوبی بیاموزید. خواندن داستان¬ها انگلیسی برای شما بسیار مناسب است. سعی کنید برنامه¬های تلویزیونی مختلف مانند اخبار، فیلم و غیره به زبان انگلیسی را گوش دهید. چند دوست اینترنتی پیدا کنید و به زبان انگلیسی با آن¬ها چت کنید. روزنامه ها و مجله های انگلیسی برای شما بسیار مفید هستند. آزمون هایی که جهت اطمینان از سطح زبان خود می توانید در آن¬ها شرکت کنید، CAE و CPE نام دارند.";
            }
            if (max == typeD)
            {
                typename = "D";
                maxstr = "از نظر نوع زبان آموزی شما در دسته تفریحی قرار می گیرید. شما علاقه دارید که نیازهای اولیه خود را بتوانید با زبان انگلیسی رفع کنید. برای مثال شما باید بتوانید در یک رستوران غذا سفارش دهید یا با دیگران مختصراً صحبت کنید. مواردی که شما نیاز به آموختن آن ها دارید تعدادی جمله ثابت است که معمولاً توسط انگلیسی زبان¬ها در مناسبت¬های خاص مانند رستوران، تاکسی، مدرسه، مراکز خرید و غیره  به صورت مکرر استفاده می¬شوند. کتاب¬هایی مانند انگلیسی در سفر که در مورد نیاز توریست ها هستند، مفید می باشند. چیزهایی مانند گفتگوهای عامیانه، گرامر پیشرفته و غیره مورد نیاز شما نیستند. آزمون هایی که جهت اطمینان از سطح زبان خود می توانید در آن¬ها شرکت کنید KET و PET نام دارند.";
            }
                            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + System.AppDomain.CurrentDomain.BaseDirectory + "/test.accdb");
            OleDbCommand cmd = new OleDbCommand("update Student set type ='" + maxstr + "', typename= '"+typename+"' where ID=" + stl.Code, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            this.Close();
     
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

        private void rdn14_Checked(object sender, RoutedEventArgs e)
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

        private void rdn24_Checked(object sender, RoutedEventArgs e)
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

        private void rdn34_Checked(object sender, RoutedEventArgs e)
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

        private void rdn44_Checked(object sender, RoutedEventArgs e)
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

        private void rdn54_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx5.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx6.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx6.Visibility = Visibility.Visible;
        }

        private void rdn61_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx6.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx7.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx7.Visibility = Visibility.Visible;
        }

        private void rdn62_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx6.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx7.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx7.Visibility = Visibility.Visible;
        }

        private void rdn63_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx6.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx7.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx7.Visibility = Visibility.Visible;
        }

        private void rdn64_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx6.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx7.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx7.Visibility = Visibility.Visible;
        }

        private void rdn71_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx7.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx8.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx8.Visibility = Visibility.Visible;
        }

        private void rdn72_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx7.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx8.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx8.Visibility = Visibility.Visible;
        }

        private void rdn73_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx7.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx8.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx8.Visibility = Visibility.Visible;
        }

        private void rdn74_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx7.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx8.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx8.Visibility = Visibility.Visible;
        }

        private void rdn81_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx8.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx9.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx9.Visibility = Visibility.Visible;
        }

        private void rdn82_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx8.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx9.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx9.Visibility = Visibility.Visible;
        }

        private void rdn83_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx8.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx9.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx9.Visibility = Visibility.Visible;
        }

        private void rdn84_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx8.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx9.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx9.Visibility = Visibility.Visible;
        }

        private void rdn91_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx9.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx10.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx10.Visibility = Visibility.Visible;
        }

        private void rdn92_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx9.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx10.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx10.Visibility = Visibility.Visible;
        }

        private void rdn93_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx9.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx10.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx10.Visibility = Visibility.Visible;
        }

        private void rdn94_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx9.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx10.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx10.Visibility = Visibility.Visible;
        }

        private void rdn101_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx10.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            btn.BeginAnimation(GroupBox.OpacityProperty, c);
            btn.Visibility = Visibility.Visible;
        }

        private void rdn102_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx10.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            btn.BeginAnimation(GroupBox.OpacityProperty, c);
            btn.Visibility = Visibility.Visible;
        }

        private void rdn103_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx10.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            btn.BeginAnimation(GroupBox.OpacityProperty, c);
            btn.Visibility = Visibility.Visible;
        }

        private void rdn104_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx10.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            btn.BeginAnimation(GroupBox.OpacityProperty, c);
            btn.Visibility = Visibility.Visible;
        }

        private void rdn33_Checked(object sender, RoutedEventArgs e)
        {
            DoubleAnimation b = new DoubleAnimation(0, TimeSpan.FromSeconds(2));
            grpx3.BeginAnimation(GroupBox.OpacityProperty, b);
            DoubleAnimation c = new DoubleAnimation(1, TimeSpan.FromSeconds(2));
            grpx4.BeginAnimation(GroupBox.OpacityProperty, c);
            grpx4.Visibility = Visibility.Visible;
        }
    }
}
