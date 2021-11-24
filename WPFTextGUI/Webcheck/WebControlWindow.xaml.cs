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

namespace WPFTextGUI.Webcheck
{
    /// <summary>
    /// Interaction logic for WebControlPanel.xaml
    /// </summary>
    public partial class WebControlPanel : Window
    {
        public WebControlPanel()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            var url = TxtUrl.Text;
            var term = TxtTerm.Text;

            if (Webs.WebsToCheck.TryAdd(url, true))
            {
                WebCheck wc = new WebCheck(url, term);
                WebCheckWindow wcw = new WebCheckWindow(wc);
                wcw.Show();
            }

            TxtUrl.Text = TxtTerm.Text = "";
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            var url = TxtUrl.Text;

            var success =Webs.WebsToCheck.TryUpdate(url, false, true);

            if (!success)
                MessageBox.Show("Failed to stop " + url, "Error", MessageBoxButton.OK);
        }
    }
}
