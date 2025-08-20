using SmartCodeLab2.Models;
using System.ComponentModel;
using System.Diagnostics;

namespace SmartCodeLab2.CustomComponents
{
    /// <summary>
    /// Interaction logic for CustomTextField.xaml
    /// </summary>
    public partial class CustomTextField : System.Windows.Controls.UserControl
    {
        public CustomTextField()
        {
            InitializeComponent();
        }

        public string GetTextFieldValue()
        {
            return textField1.Text;
        }

        [Category("Appearance")]
        public string LabelText
        {
            get { return textLabel.Content?.ToString() ?? ""; }
            set { textLabel.Content = value; }
        }

        public int LabelWidth
        {
            set {  textLabel.Width = value; }
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
            set { textField1.Height = value; }
        }

        public int TextFieldWidth
        {
            set { textField1.Width = value; }
        }
    }
}
