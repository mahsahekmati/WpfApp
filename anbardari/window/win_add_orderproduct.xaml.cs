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

namespace anbardari.window
{
    /// <summary>
    /// Interaction logic for add_orderproduct.xaml
    /// </summary>
    public partial class win_add_orderproduct : Window
    {
        public win_add_orderproduct()
        {
            InitializeComponent();
        }

        anbardariEntities udb=new anbardariEntities();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmb_product.ItemsSource = udb.products.ToList();
            cmb_product.DisplayMemberPath = "productname";
            cmb_product.SelectedValuePath = "productid";
            //var price=udb.v_orderdetail.FirstOrDefault(o=>o.productid==Convert.ToInt32( cmb_product.SelectedValuePath));
            //lbl_productprice.Content =price.productlastfee ;
        }

        private void cmb_product_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string id = cmb_product.SelectedValue.ToString();
            
            var query = from u in udb.v_product
                        where u.productid ==Convert.ToInt32(id)
                        
                        select u;
            var result = query.ToList();
            lbl_productprice.Content=result[0].productlastfee.ToString();
        }
    }
    

    
}



