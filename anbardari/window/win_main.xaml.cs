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
using anbardari.moudle;
using datamodel;

namespace anbardari.window
{
    /// <summary>
    /// Interaction logic for win_main.xaml
    /// </summary>
    public partial class win_main : Window
    {
        public win_main()
        {
            InitializeComponent();
        }

        private anbardariEntities udb = new anbardariEntities();

        private void btn_exit_click(object sender, RoutedEventArgs e)
        {
            udb.sp_update_userlog(publicvariable.guserid, String.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(tarikh.Text)) + "-" +
                                                       string.Format("{0:hh:mm:ss}", DateTime.Now));

            udb.SaveChanges();
            System.Environment.Exit(0);
        }

        private void btn_windows_user(object sender, RoutedEventArgs e)
        {
            win_user wu=new win_user();
            wu.ShowDialog();
        }
        publicvariable p=new publicvariable();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbl_name.Content = publicvariable.gname;
            lbl_family.Content = publicvariable.gfamily;
            lbl_time.Content = DateTime.Now.Hour + ":" + DateTime.Now.Minute;
            setsize();

        }
        private void setsize()
        {
            this.MaxHeight = 650;
            this.MinHeight = 650;
            this.MaxWidth = 850;
            this.MinWidth = 850;
        }

        private void showproduct_Click(object sender, RoutedEventArgs e)
        {
            win_product wp=new win_product();
            wp.ShowDialog();
        }

        private void RibbonApplicationSplitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            win_customer wc=new win_customer();
            wc.ShowDialog();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            udb.sp_update_userlog(publicvariable.guserid, String.Format("{0:yyyy/MM/dd}",Convert.ToDateTime( tarikh.Text)) + "-" +
                                                       string.Format("{0:hh:mm:ss}", DateTime.Now));

            udb.SaveChanges();
            System.Environment.Exit(0);
        }

        private void RibbonApplicationSplitMenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            win_userlog wul=new win_userlog();
            wul.ShowDialog();
        }

        private void createfactor_Click(object sender, RoutedEventArgs e)
        {
           win_order f=new win_order();
            f.ShowDialog();
        }

        private void system_part_Click(object sender, RoutedEventArgs e)
        {
            win_systempart ws=new win_systempart();
            ws.ShowDialog();
        }
    }
}
