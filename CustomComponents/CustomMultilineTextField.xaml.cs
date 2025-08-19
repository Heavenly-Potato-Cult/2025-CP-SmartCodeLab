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

        public string GetTextFieldValue()
        {
            return textField1.Text.ToString();
        }

        public string LabelText
        {
            get { return textLabel.Content?.ToString() ?? ""; }
            set { textLabel.Content = value; }
        }

        public int LabelWidth
        {
            set { textLabel.Width = value; }
        }

        public int LabelHeight
        {
            set { textLabel.Height = value; }
        }
        public int LabelFontSize
        {
            set { textLabel.FontSize = value; }
        }

        public int TextFieldHeight
        {
            set { textField1.Height = value;
                textField1.MaxHeight = value;
                textField1.MinHeight = value;
            }
        }

        public int TextFieldWidth
        {
            set { textField1.Width = value;
                textField1.MaxWidth = value;
                textField1.MinWidth = value;
            }
        }
    }
}
