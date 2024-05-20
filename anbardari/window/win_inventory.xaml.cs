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
    public partial class win_inventory : Window
    {
        public win_inventory()
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
            cmb_status.Items.Add("همه");
            cmb_status.Items.Add("افزایش موجودی");
            cmb_status.Items.Add("کاهش موجودی");
            cmb_status.SelectedIndex = 0;
            lbl_productname.Content= productname;
           

            userquery(searchstatement);

        }
        private void userquery(Func<string> searchuser)
        {
            var query = udb.Database.SqlQuery<v_inventory>("select * from v_inventory where 1=1 and productid= "+productid+" " + searchuser());
            //MessageBox.Show(query.Tostring());
            var u = query.ToList();
            DataGrid_inventory.ItemsSource = u;

            //    var query = from u in udb.v_users select ("select * from v_users where 1=1" + searchuser());
            //var users = query.ToList();
            //DataGridUser.ItemsSource = users;
        }
        private string searchstatement()
        {
            ///"and logindate between ' " + aztarikh.Text + "' and '" + tatarikh.Text + "'"
            string searchinfo = "";
            if (Txt_user.Text != "")
            {
                searchinfo += "and fullname like '%" + Txt_user.Text.Trim() + "%'";
            }
            if (cmb_status.SelectedIndex == 1)
            {
                searchinfo += "and inventorycount>1";
            }
            if (cmb_status.SelectedIndex == 2)
            {
                searchinfo += "and inventorycount<0";
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

        private void btn_create_producinventory_Click(object sender, RoutedEventArgs e)
        {
           
            win_add_inventory wai= new win_add_inventory();
          
            wai.productname = this.productname;
            wai.productid = this.productid;

            wai.ShowDialog();

            userquery(searchstatement);

        }
    }

}
