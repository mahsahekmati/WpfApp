using datamodel;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace anbardari.window
{
    /// <summary>
    /// Interaction logic for win_user.xaml
    /// </summary>
    public partial class win_product : Window
    {
        public win_product()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        anbardariEntities udb = new anbardariEntities();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmb_status.Items.Add("همه");
            cmb_status.Items.Add("موجود");
            cmb_status.Items.Add("ناموجود");
            cmb_status.SelectedIndex = 0;


            userquery(searchstatement);

        }
        private void userquery(Func<string> searchuser)
        {
            var query = udb.Database.SqlQuery<v_product>("select * from v_product where 1=1 " + searchuser());
            //MessageBox.Show(query.Tostring());
            var u = query.ToList();
            DataGrid_product.ItemsSource = u;

            //    var query = from u in udb.v_users select ("select * from v_users where 1=1" + searchuser());
            //var users = query.ToList();
            //DataGridUser.ItemsSource = users;
        }
        private string searchstatement()
        {
            ///"and logindate between ' " + aztarikh.Text + "' and '" + tatarikh.Text + "'"
            string searchinfo = "";
            if (Txt_product_Name.Text != "")
            {
                searchinfo += "and productname like '%" + Txt_product_Name.Text.Trim() + "%'";
            }
            if (cmb_status.SelectedIndex == 1)
            {
                searchinfo += "and productlastsuply>0";
            }
            if (cmb_status.SelectedIndex == 2)
            {
                searchinfo += "and productlastsuply<=0";
            }



            return searchinfo;
        }

        private void image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            userquery(searchstatement);
        
        }

        private void image1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void btn_create_product_Click(object sender, RoutedEventArgs e)
        {
           win_add_product wap=new win_add_product();
            wap.ShowDialog();

            userquery(searchstatement);
            

        }
        private void showprice_click(object sender, RoutedEventArgs e)
        {
            object item = DataGrid_product.SelectedItem;
           win_productprice wpp=new win_productprice();
            string productname = (DataGrid_product.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            int productid = Convert.ToInt32((DataGrid_product.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
            wpp.productname= productname;
            wpp.productid= productid;

            wpp.ShowDialog();
         

            userquery(searchstatement);


        }
        private void productinventory_click(object sender, RoutedEventArgs e)
        {
            object item = DataGrid_product.SelectedItem;
            win_inventory wi = new win_inventory();
            string productname = (DataGrid_product.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            int productid = Convert.ToInt32((DataGrid_product.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
            wi.productname = productname;
            wi.productid = productid;

            wi.ShowDialog();


            userquery(searchstatement);


        }
    }

}
