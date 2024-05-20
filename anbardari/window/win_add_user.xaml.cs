using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using datamodel;
using System.Security.Cryptography;

namespace anbardari.window
{
    /// <summary>
    /// Interaction logic for add_user.xaml
    /// </summary>
    public partial class win_add_user : Window
    {
        public win_add_user()
        {
            InitializeComponent();
        }
        anbardariEntities udb = new anbardariEntities();

        private void btn_create_user_Click(object sender, RoutedEventArgs e)
        {
            if (!checknullable())
            {
                return;
            }
            SHA256CryptoServiceProvider sha2 = new SHA256CryptoServiceProvider();
            Byte[] b1;
            Byte[] b2;
            b1 = UTF8Encoding.UTF8.GetBytes(txt_user_password.Text.Trim());
            b2 = sha2.ComputeHash(b1);
            string userpasshash = BitConverter.ToString(b2);
            //////////////////////////
            var query = from u2 in udb.users
                        where u2.userusername == txt_user_username.Text.Trim()
                        select u2;
            var result = query.ToList();
            if (result.Count > 0)
            {
                MessageBox.Show("این نام کاربری از قبل وجود دارد");
                txt_user_username.Focus();
                return;


                ///////دستورات دیتا بیس
                try
                {
                    user u = new user();
                    u.username = txt_user_name.Text;
                    u.userfamily = txt_user_lastname.Text;
                    u.usertel = txt_user_tel.Text;
                    u.userusername = txt_user_username.Text;
                    u.userpassword = userpasshash;
                    u.logindate = tarikh.Text;
                    udb.users.Add(u);
                    udb.SaveChanges();
                    MessageBox.Show("کاربر جدید با موفقیت افزوده شد");
                }
                catch
                {
                    MessageBox.Show("در ارتباط با دیتا بیس مشکلی به وجود امد");
                }
                finally
                {
                    this.Close();
                }

            }
        }
        private bool checknullable()
        {
            if (txt_user_name.Text == "")
            {
                MessageBox.Show("نام مشتری خالی است");
                return false;

            }
            if (txt_user_lastname.Text == "")
            {
                MessageBox.Show("نام خانوادگی مشتری خالی است");
                return false;

            }
            if (txt_user_tel.Text == "")
            {
                MessageBox.Show("شماره مشتری خالی است");
                return false;

            }
            return true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbl_tarikh.Content= tarikh.Text;
            txt_user_name.Focus();
        }

        private void txt_user_tel_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);

        }
    }
}
