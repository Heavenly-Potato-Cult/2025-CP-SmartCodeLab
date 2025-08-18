using System.Windows;
using System.Windows.Controls;

namespace SmartCodeLab2.CustomComponents
{
    /// <summary>
    /// Interaction logic for testCase.xaml
    /// </summary>
    public partial class testCase : Grid
    {
        WrapPanel wp;
        public testCase(WrapPanel wp)
        {
            InitializeComponent();
            this.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            this.wp = wp;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            wp.Children.Remove(this);
        }
    }
}
