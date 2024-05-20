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
using datamodel;
using anbardari.moudle;

namespace anbardari.window
{
    /// <summary>
    /// Interaction logic for factor.xaml
    /// </summary>
    public partial class win_order : Window
    {
        public win_order()
        {
            InitializeComponent();
        }

        anbardariEntities udb=new anbardariEntities();
        public int orderid;
        long sum = 0;
        public int customerid;
       
        private void userquery(Func<string> searchuser)
        {
            var query = udb.Database.SqlQuery<v_customer>("select * from v_customer where 1=1 " + searchuser());
            //MessageBox.Show(query.Tostring());
            var u = query.ToList();
            datagrid_customer.ItemsSource = u;

            //    var query = from u in udb.v_users select ("select * from v_users where 1=1" + searchuser());
            //var users = query.ToList();
            //DataGridUser.ItemsSource = users;
        }

        private string searchstatement()
        {
            //string timeaz = hour_az.Text.Trim() + ":" + minute_az.Text.Trim() + ":" + second_az.Text.Trim();
            //string timeta = hour_ta.Text.Trim() + ":" + minute_ta.Text.Trim() + ":" + second_ta.Text.Trim();

            //string searchinfo = " and enterdatetime between '" + String.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(aztarikh.Text)) + "-" + timeaz +
            //    "' and '" + String.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(tatarikh.Text)) + "-" + timeta + "'";

            string searchinfo = "";
            
            

            return searchinfo;
        }


        private void userquery2(Func<string> searchuser2)
        {
            var query = udb.Database.SqlQuery<v_product>("select * from v_product where 1=1 " + searchuser2());
            //MessageBox.Show(query.Tostring());
            var u = query.ToList();
            datagrid_product.ItemsSource = u;

            //    var query = from u in udb.v_users select ("select * from v_users where 1=1" + searchuser());
            //var users = query.ToList();
            //DataGridUser.ItemsSource = users;
        }
        private string searchstatement2()
        {
            string searchinfo = "";
            if (txt_productname.Text != "")
            {
                searchinfo += "and productname like '%" + txt_productname.Text.Trim() + "%'";
            }
      
            return searchinfo;
        }

        ///پرکردن گرید جزییات فاکتور
        private void userquery3(Func<string> searchuser3)
        {
            var query = udb.Database.SqlQuery<v_orderdetail>("select * from v_orderdetail where orderid="+Convert.ToInt32(lbl_factorid.Content) + searchuser3());
            //MessageBox.Show(query.Tostring());
            var u = query.ToList();
            datagride_orderdetail.ItemsSource = u;

            //    var query = from u in udb.v_users select ("select * from v_users where 1=1" + searchuser());
            //var users = query.ToList();
            //DataGridUser.ItemsSource = users;
        }
        private string searchstatement3()
        {
            string searchinfo = "";
            //if (txt_productname.Text != "")
            //{
            //    searchinfo += "and productname like '%" + txt_productname.Text.Trim() + "%'";
            //}

            return searchinfo;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            userquery(searchstatement);
            userquery2(searchstatement2);
            btn_chooseproduct.IsEnabled = false;
            btn_createproduct.IsEnabled = false;
            btn_deleteproduct.IsEnabled = false;
            btn_closeorder.IsEnabled= false;
            
        }

       

        private void img_exit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        

        private void btn_create_Click_1(object sender, RoutedEventArgs e)
        {
            object item = datagrid_customer.SelectedItem;
            if (item!=null)
            {
                int customerid = Convert.ToInt32((datagrid_customer.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
                this.customerid = customerid;

                /////////////////////////ثبت اطلاعات در دیتابیس
                try
                {
                    order f = new order();
                    f.orderprice = 0;
                    f.orderdate = String.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(tarikh.Text));
                    f.userid = publicvariable.guserid;
                    f.customerid = customerid;
                    
                    udb.orders.Add(f);
                    udb.SaveChanges();
                    MessageBox.Show("فاکتور جدید با موفقیت افزوده شد");





                }
                catch
                {
                    MessageBox.Show("در ارتباط با دیتا بیس مشکلی به وجود امد");
                }
                finally
                {
                    lbl_tarikh.Content = String.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(tarikh.Text));
                    lbl_userid.Content = publicvariable.gname + " " + publicvariable.gfamily;

                    var query = udb.Database.SqlQuery<order>("select  top 1 * from orders  order by orderid desc");
                    //MessageBox.Show(query.Tostring());
                    var u = query.ToList();
                    this.orderid = u[0].orderid;
                    lbl_factorid.Content = orderid;
                    
                    lbl_sum.Content = sum;
                    lbl_customername.Content = ((datagrid_customer.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text);

                    btn_chooseproduct.IsEnabled = true;
                    btn_create.IsEnabled = false;
                    
                
                }
              
            }

            else
            {
                MessageBox.Show("لطفا ابتدا یک مشتری انتخاب کنید");
                return;

            }
           
            
         
        }

        private void img_search_MouseDown(object sender, MouseButtonEventArgs e)
        {
            userquery(searchstatement);
        }

        private void img_searchproduct_MouseDown(object sender, MouseButtonEventArgs e)
        {
            userquery2(searchstatement2);
        }
        public int productid;
        private void btn_chooseproduct_Click(object sender, RoutedEventArgs e)
        {


            object item = datagrid_product.SelectedItem;
            int productid = Convert.ToInt32((datagrid_product.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
            string productname = (datagrid_product.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            int count= Convert.ToInt32((datagrid_product.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text);
            long price = Convert.ToInt64((datagrid_product.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text);
            lbl_productname.Content=productname;
            lbl_productcount.Content=count;
            lbl_productprice.Content=price;
            
            btn_createproduct.IsEnabled=true;


        }
        #region createproduct

        private void btn_createproduct_Click(object sender, RoutedEventArgs e)
        {
            if (txt_count.Text == "")
            {
                MessageBox.Show("لطفا تعداد کالا را وارد کنید");
                return;
            }
            //////چک کردن موجودی وارد شده با موجودی کالا
            object item = datagrid_product.SelectedItem;
            int countproduct = Convert.ToInt32((datagrid_product.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text);
            long priceproduct = Convert.ToInt64((datagrid_product.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text);
            int count = Convert.ToInt32(txt_count.Text.Trim());
            int productid = Convert.ToInt32((datagrid_product.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);

            if (count > countproduct)
            {
                MessageBox.Show("تعداد وارد شده بیشتر از موجودی کالا است");
                return;
            }
            //////////چک ئکردن سبد کالاها جهت تکراری وارد نشدن
            var query = from u in udb.orderdetails
                        where u.orderid == orderid
                        select u;
            var result=query.ToList();
            for (int i = 0; i < result.Count; i++)
            {
                if(result[i].productid == productid)
                {
                    MessageBox.Show("این کالا قبلا انتخاب شده");
                    return;
                }
                
              
            }

            /////////////محاسبه مبلغ فاکتور
            sum += (count * priceproduct);
            ////////////////اضافه کردن به جدول فاکتور
            try
            {
               

                orderdetail od = new orderdetail();
                od.orderid = Convert.ToInt32(lbl_factorid.Content);
                od.productid = productid;
                od.sumprice = sum;
                od.count = Convert.ToInt32(txt_count.Text.Trim());
                od.price = Convert.ToInt64(lbl_productprice.Content);
                udb.orderdetails.Add(od);
                udb.SaveChanges();
            }
            catch
            {
                MessageBox.Show("در ارتباط با دیتا بیس مشکلی به وجود امد");
            }
            finally
            {
                udb.sp_update_laststuck(-count, productid);
                udb.SaveChanges();
                lbl_productname.Content = "";
                lbl_productprice.Content = "";
                lbl_productcount.Content = "";
                txt_count.Text = "";
                userquery3(searchstatement3);
                userquery2(searchstatement2);

                
                lbl_sum.Content=sum;
                btn_createproduct.IsEnabled = true;
                btn_deleteproduct.IsEnabled = true;
                btn_closeorder.IsEnabled = true;

            }
   
        }
        #endregion
        private void btn_deleteproduct_Click(object sender, RoutedEventArgs e)
        {
            object item = datagride_orderdetail.SelectedItem;
            int productid = Convert.ToInt32((datagride_orderdetail.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
            int count = Convert.ToInt32((datagride_orderdetail.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text);

            int price = Convert.ToInt32((datagride_orderdetail.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text);



            var query = from u in udb.orderdetails
                        where u.orderid == orderid
                        select u;
            var result = query.ToList();
            for (int i = 0; i < result.Count; i++)
            {
                if(result[i].productid == productid)
                {
                    udb.orderdetails.Remove(result[i]);
                    udb.SaveChanges();
                }
                
                
            }
        
            udb.sp_update_laststuck(count, productid);
            udb.SaveChanges();
            sum -= (count * price);
            lbl_sum.Content=sum.ToString();
            userquery3(searchstatement3);
            userquery2(searchstatement2);


        }

        private void btn_closeorder_Click(object sender, RoutedEventArgs e)
        {

            lbl_productcount.Content = "";
            lbl_productname.Content = "";
            lbl_productprice.Content = "";
            txt_count.Text = "";
            lbl_customername.Content = "";
            lbl_factorid.Content = "";
            lbl_tarikh.Content = "";
            lbl_userid.Content = "";
            lbl_sum.Content = "";
            btn_chooseproduct.IsEnabled = false;
            btn_createproduct.IsEnabled = false;
            btn_deleteproduct.IsEnabled = false;
            btn_closeorder.IsEnabled = false;
            btn_create.IsEnabled = true;
            userquery3(searchstatement3);

        }
    }
}
