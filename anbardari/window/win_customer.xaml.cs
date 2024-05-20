using datamodel;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace anbardari.window
{
    /// <summary>
    /// Interaction logic for win_user.xaml
    /// </summary>
    public partial class win_customer : Window
    {
        public win_customer()
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
           


            userquery(searchstatement);

        }
        private void userquery(Func<string> searchuser)
        {
            var query = udb.Database.SqlQuery<v_customer>("select * from v_customer where 1=1 " + searchuser());
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
            if (Txt_customer_Name.Text != "")
            {
                searchinfo += "and customername like '%" + Txt_customer_Name.Text.Trim() + "%'";
            }
          



            return searchinfo;
        }

        private void image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            userquery(searchstatement);
        }

        private void image1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Environment.Exit(0);
        }

    

        private void btn_create_customer_Click(object sender, RoutedEventArgs e)
        {
            win_add_user au = new win_add_user();
            au.ShowDialog();

            userquery(searchstatement);
        }
    }

}
