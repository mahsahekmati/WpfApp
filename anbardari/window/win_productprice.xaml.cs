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
    public partial class win_productprice : Window
    {
        public win_productprice()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        anbardariEntities udb = new anbardariEntities();
        public string productname;
        public int productid;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbl_productname.Content= productname;
           

            userquery(searchstatement);

        }
        private void userquery(Func<string> searchuser)
        {
            var query = udb.Database.SqlQuery<v_productprice>("select * from v_productprice where 1=1 and productid= " + productid + " " + searchuser());
            //MessageBox.Show(query.Tostring());
            var u = query.ToList();
            DataGrid_productprice.ItemsSource = u;

            //var query = from u in udb.v_productprice select ("select * from v_productprice where 1=1 and productid=" +productid+" "+ searchuser());
            //var users = query.ToList();
            //DataGrid_productprice.ItemsSource = users;
        }
        private string searchstatement()
        {
            ///"and logindate between ' " + aztarikh.Text + "' and '" + tatarikh.Text + "'"
            string searchinfo = "";
            if (Txt_username.Text != "")
            {
                searchinfo += "and fullname like '%" + Txt_username.Text.Trim() + "%'";
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

        private void btn_create_productprice_Click(object sender, RoutedEventArgs e)
        {
          win_add_price wac=new win_add_price();
            wac.productname = this.productname;
            wac.productid=this.productid;
            wac.ShowDialog();

            userquery(searchstatement);

        }
    }

}
