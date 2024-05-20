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
using System.IO;
using Microsoft.Win32;
using anbardari.moudle;

namespace anbardari.window
{
    /// <summary>
    /// Interaction logic for add_user.xaml
    /// </summary>
    public partial class win_add_product : Window
    {
        public win_add_product()
        {
            InitializeComponent();
        }
        anbardariEntities udb = new anbardariEntities();
        string imagename,strname;

        private void btn_create_product_Click(object sender, RoutedEventArgs e)
        {
            if (!checknullable())
            {
                return;
            }
            ///////////////////////ثبت اطلاعات ئر ئیتابیس
            try
            {

                if (imagename != "")
                {
                    ///تبدیل عکس به رشته
                    FileStream fs = new FileStream(imagename, FileMode.Open, FileAccess.Read);
                    byte[] imgarray = new byte[fs.Length];
                    fs.Read(imgarray, 0, Convert.ToInt32(fs.Length));
                    fs.Close();
                    ////////////
                    //product p = new product();
                    
                    //p.productname = txt_product_name.Text.Trim();
                    //p.productimage = imgarray;
                    //p.productdesc = txt_productdesc.Text.Trim();
                    //p.userid = publicvariable.guserid;
                    //p.productlastsuply = 0;
                    //p.productlastfee = 0;
                    //udb.products.Add(p);
                    //udb.SaveChanges();
                    //MessageBox.Show("add successful");

                }

            }
            catch
            {
                MessageBox.Show("erooor");
            }
            finally
            {
                this.Close();
            }



        }
        private bool checknullable()
        {
            if (txt_product_name.Text == "")
            {
                MessageBox.Show("نام کالا خالی است");
                return false;

            }
         
            return true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txt_product_name.Focus();
            lbl_username.Content = publicvariable.gname + " " + publicvariable.gfamily;
            lbl_date.Content = tarikh.Text;
        }

        

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void productimage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                FileDialog filedlg = new OpenFileDialog();
                filedlg.Filter = "Image file (*.jpg; *.bmp;*.gif)|*.jpg;*bmp;*.gif";
                filedlg.ShowDialog();
                {
                    strname = filedlg.SafeFileName;
                    imagename = filedlg.FileName;
                    if (imagename != "")
                    {
                        ImageSourceConverter isc = new ImageSourceConverter();
                        productimage.SetValue(Image.SourceProperty, isc.ConvertFromString(imagename));

                    }
                  
                }
                filedlg = null;
            }
            catch(Exception ex) 
            {
                MessageBox.Show("erooor hast va matn eroor ="+ex.ToString());
            }

        }
    }
}
