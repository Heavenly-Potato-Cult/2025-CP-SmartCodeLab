using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for ComboBox.xaml
    /// </summary>
    public partial class ComboBox : System.Windows.Controls.UserControl
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        public string GetSelectedItem()
        {

            return languageCB.SelectedValue != null ? 
                languageCB.SelectedValue.ToString() : 
                string.Empty;
        }

        public string SetItems
        {
            set
            {
                // Clear existing items
                languageCB.Items.Clear();

                // Split the string by commas and add each item
                if (!string.IsNullOrEmpty(value))
                {
                    var items = value.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var item in items)
                    {
                        languageCB.Items.Add(item.Trim()); // Trim to remove spaces
                    }
                }
            }
        }

        [Category("Appearance")]
        public string LabelText
        {
            set { textLabel.Content = value; }
        }
    }
}
