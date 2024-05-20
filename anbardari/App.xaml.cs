using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using anbardari.window;

namespace anbardari
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void win_start(object sender, StartupEventArgs e)
        {
            win_login wl=new win_login();
            wl.ShowDialog();
            win_main wm=new win_main();
            wm.ShowDialog();


        }
    }
}
