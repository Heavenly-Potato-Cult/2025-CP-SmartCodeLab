using Microsoft.Win32;
using System.Windows;
using SmartCodeLab2.CustomComponents;
using System.Diagnostics;

namespace SmartCodeLab2
{
    /// <summary>
    /// Interaction logic for Grid3.xaml
    /// </summary>
    public partial class Grid3 : System.Windows.Controls.UserControl
    {
        public Grid3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Console.WriteLine(folderBrowserDialog.SelectedPath);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            con.Children.Add(new testCase(con));
        }

        private void CustomButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine(actName.getText());
        }
    }
}
