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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SmartCodeLab2.CustomComponents
{
    /// <summary>
    /// Interaction logic for CustomMultilineTextField.xaml
    /// </summary>
    public partial class CustomMultilineTextField : System.Windows.Controls.UserControl
    {
        public CustomMultilineTextField()
        {
            InitializeComponent();
        }

        public string LabelText
        {
            get { return textLabel.Content?.ToString() ?? ""; }
            set { textLabel.Content = value; }
        }
    }
}
