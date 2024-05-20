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
    public partial class win_user : Window
    {
        public win_user()
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
            var query = udb.Database.SqlQuery<v_users>("select * from v_users where 1=1 " + searchuser());
            //MessageBox.Show(query.Tostring());
            var u = query.ToList();
            DataGridUser.ItemsSource = u;

            //    var query = from u in udb.v_users select ("select * from v_users where 1=1" + searchuser());
            //var users = query.ToList();
            //DataGridUser.ItemsSource = users;
        }
        private string searchstatement()
        {
            ///"and logindate between ' " + aztarikh.Text + "' and '" + tatarikh.Text + "'"
            string searchinfo = "";
            if (Txt_User_Name.Text != "")
            {
                searchinfo += "and username like '%" + Txt_User_Name.Text.Trim() + "%'";
            }
            if (string.IsNullOrEmpty(Txt_User_LastName.Text))
            {
                searchinfo += "and userfamily like '%" + Txt_User_LastName.Text.Trim() + "%'";

            }
            if (rdbactive.IsChecked == true)
            {
                searchinfo += "and useractive = 0";
            }
            if(rdbdeactive.IsChecked==true) 
                    {
                searchinfo += "and useractive=1";

            }
            if (string.IsNullOrEmpty(txt_user_tel.Text))
            {
                searchinfo+="and usertel like '%"+txt_user_tel.Text.Trim()+"%'";
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

        private void btn_create_User_Click(object sender, RoutedEventArgs e)
        {
            win_add_user au = new win_add_user();
            au.ShowDialog();

            userquery(searchstatement);

        }
    }

}
