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
using anbardari.window;
using Microsoft.Win32;
using datamodel;
using System.Security.Cryptography;
using anbardari.moudle;
using System.Net;


namespace anbardari
{
    /// <summary>
    /// Interaction logic for win_login.xaml
    /// </summary>
    public partial class win_login : Window
    {
        public win_login()
        {
            InitializeComponent();
        }
        anbardariEntities udb=new anbardariEntities();
     

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            ////////////////////////////////////هش کردن پسورد
            SHA256CryptoServiceProvider sha2 = new SHA256CryptoServiceProvider();
            Byte[] b1;
            Byte[] b2;
            b1 = UTF8Encoding.UTF8.GetBytes(txt_password.Password.Trim());
            b2 = sha2.ComputeHash(b1);
            string userpasswordhash = BitConverter.ToString(b2);
            /////////////////////////////////////////////جستجو کاربر
             var query=from u in udb.v_users
                       where u.userusername==txt_username.Text.Trim()
                       where u.userpassword==userpasswordhash
                       select u;
            var result = query.ToList();
            /////////////////////////////////////دستورات رجیستری

            RegistryKey UserRegistryKey = Registry.CurrentUser.CreateSubKey("software\\anbardari");
            /////////////////////////////////////////
            try
            {
                if (result.Count>0)
                {
                    ///////////////////////رجیستری
                    UserRegistryKey.SetValue("userkey", txt_username.Text.Trim());
                    ////////////////////////////////ثبت  نام و نام خانوادگی کاربر

                    publicvariable.guserid = result[0].userid;
                    publicvariable.gname = result[0].username;

                    ////////////////////////////////به دست اوردن نام کامپیوتر کاربر
                    string computername = System.Environment.MachineName;
                    
                    /////////////////////////به دست اوردن ای پی
                    string ip = "";
                    IPHostEntry ipe = Dns.GetHostEntry(computername);
                    IPAddress[] ipa = ipe.AddressList;
                    ip = ipa[0].ToString();
                    /////////////////////////اضافه کردن به جدول  کنترل کاربران
                    userlog ul=new userlog();
                    ul.userid= result[0].userid;
                    ul.computername = computername;
                    ul.ipaddress = ip;
                    ul.enterdatetime = String.Format("{0:yyyy/MM/dd}",Convert.ToDateTime( tarikh.Text)) + "-" +
                                       string.Format("{0:hh:mm:ss}", DateTime.Now);
                    udb.userlogs.Add(ul);
                    udb.SaveChanges();




                    this.Close();

                }
                else
                {
                    MessageBox.Show("اشتباه است");
                }
            }
            catch
            {
                MessageBox.Show("خطلای سیستمی");

            }
            finally
            {
                UserRegistryKey.Close();
            }
         
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RegistryKey ru = Registry.CurrentUser.CreateSubKey("software\\anbardari");
            txt_username.Text = Convert.ToString(ru.GetValue("userkey"));

        }

        private void setdate()
        {
            lbl_dayname.Content = Calendar.SelectedDateProperty.ToString();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
            
        }
    }
}
