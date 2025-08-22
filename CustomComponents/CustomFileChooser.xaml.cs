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
    /// Interaction logic for CustomFileChooser.xaml
    /// </summary>
    public partial class CustomFileChooser : System.Windows.Controls.UserControl
    {
        private Boolean doAcceptMultipleFiles;
        public CustomFileChooser()
        {
            InitializeComponent();
            doAcceptMultipleFiles = false;
            this.MaxHeight = 65;
        }

        private void CustomButton_Click(object sender, RoutedEventArgs e)
        {
            this.Height += 30;
            Debug.WriteLine(this.MaxHeight);
            if (!doAcceptMultipleFiles) {
                foreach (var child in fileHolder.Children.OfType<FileContainer>().ToList())
                {
                    fileHolder.Children.Remove(child);
                }
            }
            fileHolder.Children.Add(new FileContainer());
        }

        public string Label
        {
            set => label.Content = value;
        }

        public Boolean AcceptMultipleFiles {
            set {
                doAcceptMultipleFiles = value;
                this.MaxHeight = value ? 100 : 65;
            } 
        }
    }
}
