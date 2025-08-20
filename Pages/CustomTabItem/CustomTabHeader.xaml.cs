using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SmartCodeLab2.Pages.CustomTabItem
{
    /// <summary>
    /// Interaction logic for CustomTabHeader.xaml
    /// </summary>
    public partial class CustomTabHeader : System.Windows.Controls.UserControl
    {
        public event EventHandler CloseRequested;
        public CustomTabHeader(string headerDisplay)
        {
            InitializeComponent();
            headerText.Content = headerDisplay;
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            CloseRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
