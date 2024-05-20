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
    public partial class win_userlog : Window
    {
        public win_userlog()
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
            cmb_username.ItemsSource = udb.v_userlog.ToList();
            cmb_username.DisplayMemberPath = "fullname";
            cmb_username.SelectedValuePath = "userid";

            userquery(searchstatement);

        }
        private void userquery(Func<string> searchuser)
        {
            var query = udb.Database.SqlQuery<v_userlog>("select * from v_userlog where 1=1 " + searchuser());
            //MessageBox.Show(query.Tostring());
            var u = query.ToList();
            DataGridUserLog.ItemsSource = u;

            //    var query = from u in udb.v_users select ("select * from v_users where 1=1" + searchuser());
            //var users = query.ToList();
            //DataGridUser.ItemsSource = users;
        }
        private string searchstatement()
        {
            string timeaz = hour_az.Text.Trim() + ":" + minute_az.Text.Trim() + ":" + second_az.Text.Trim();
            string timeta = hour_ta.Text.Trim() + ":" + minute_ta.Text.Trim() + ":" + second_ta.Text.Trim();

            string searchinfo = " and enterdatetime between '" + String.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(aztarikh.Text)) + "-" + timeaz +
                "' and '" + String.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(tatarikh.Text)) + "-" + timeta + "'";
            if (txt_computername.Text != "")
            {
                searchinfo += "and computername like '"+txt_computername.Text+"'";
            }
            if (txt_ip.Text != "")
            {
                searchinfo += "and ipaddress like '" + txt_ip+ "'";

            }
            if (cmb_username.Text!="")
            {

                searchinfo += "and userid = " + cmb_username.SelectedValue;
            }

            
           
          
         
          
            return searchinfo;
        }

       

        private void image1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, RoutedEventArgs e)
        {
            userquery(searchstatement);
        }
     
    }

}
