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
using System.Transactions;
using anbardari.moudle;

namespace anbardari.window
{
    /// <summary>
    /// Interaction logic for add_user.xaml
    /// </summary>
    public partial class win_add_price : Window
    {
        public win_add_price()
        {
            InitializeComponent();
        }
        anbardariEntities udb = new anbardariEntities();
        public string productname;
        public int productid;

        private void btn_create_newprice_Click(object sender, RoutedEventArgs e)
        {
            if(!checknullable()){
                return;
            }

            using (TransactionScope ts = new TransactionScope())
            {
                try
                {


                    productprice pp = new productprice();
                    pp.productpricepurch = Convert.ToInt64(txt_productpurch.Text.Trim());
                    pp.productpricesell = Convert.ToInt64(txt_productsell.Text.Trim());
                    pp.productpricedesc = txt_productdesc.Text.Trim();
                    pp.userid = publicvariable.guserid;
                    pp.productid = productid;
                    pp.productpricedate = tarikh.Text;
                    udb.productprices.Add(pp);
                    udb.SaveChanges();
                    MessageBox.Show("قیمت جدید با موفقیت افزوده شد");
                    //////////
                    udb.sp_updatefee_product(this.productid, Convert.ToInt64(txt_productsell.Text.Trim()));
                    udb.SaveChanges();
                    //////
                   
                    ts.Complete();
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

            ///////دستورات دیتا بیس
            

        }
        private bool checknullable()
        {
         
            if (txt_productpurch.Text == "")
            {
                MessageBox.Show("قیمت خرید مشتری خالی است");
                return false;

            }
            if (txt_productsell.Text == "")
            {
                MessageBox.Show("قیمت فروش خالی است");
                return false;

            }
            return true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbl_productname.Content = this.productname;
            lbl_date.Content= tarikh.Text;
            lbl_username.Content = publicvariable.gname + " " + publicvariable.gfamily;


        }

        private void txt_user_tel_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);

        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
