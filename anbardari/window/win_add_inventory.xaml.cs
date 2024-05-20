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
    public partial class win_add_inventory : Window
    {
        public win_add_inventory()
        {
            InitializeComponent();
        }
        anbardariEntities udb = new anbardariEntities();
        public string productname;
        public int productid;



        private bool checknullable()
        {
            if (txt_inventory_count.Text == "")
            {
                MessageBox.Show("تعداد کالا خالی است");
                return false;

            }
            
         


            return true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            lbl_username.Content = publicvariable.gname + " " + publicvariable.gfamily;
            lbl_tarikh.Content = tarikh.Text;
            

            cmb_status.Items.Add("افزایش موجودی");
            cmb_status.Items.Add("کاهش موجودی");
            cmb_status.SelectedIndex = 0;
            txt_inventory_count.Focus();
        }



        private void btn_create_inventory_Click(object sender, RoutedEventArgs e)
        {
            if (!checknullable())
            {
                return;
            }

            using (TransactionScope ts = new TransactionScope())
            {
                ///////دستورات دیتا بیس
                try
                {



                    inventory i = new inventory();
                    if (cmb_status.SelectedIndex == 0)
                    {
                        i.inventorycount = Convert.ToInt32(txt_inventory_count.Text.Trim());
                    }
                    else if (cmb_status.SelectedIndex == 1)
                    {
                        i.inventorycount = -Convert.ToInt32(txt_inventory_count.Text.Trim());
                    }

                    i.inventorydate = String.Format("{0:yyyy/mm/dd}", Convert.ToDateTime(tarikh.Text));
                    i.inventorydesc = txt_inventorydesc.Text.Trim();
                    i.userid = publicvariable.guserid;
                    i.productid = this.productid;
                    udb.inventories.Add(i);
                    udb.SaveChanges();
                    MessageBox.Show("add seccessfull");
                    /////////////////////////////////////////
                    udb.sp_update_laststuck(i.inventorycount,this.productid);
                    udb.SaveChanges();
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


        }

        private void txt_inventory_count_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Rectangle_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);

        }
    }
}
