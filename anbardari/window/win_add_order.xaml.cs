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

namespace anbardari.window
{
    /// <summary>
    /// Interaction logic for add_order.xaml
    /// </summary>
    public partial class win_add_order : Window
    {
        public win_add_order()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, RoutedEventArgs e)
        {
            win_add_orderproduct wao=new win_add_orderproduct();
            wao.ShowDialog();
        }
    }
}
