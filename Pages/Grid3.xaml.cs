using Microsoft.Win32;
using System.Windows;
using SmartCodeLab2.CustomComponents;
using System.Diagnostics;
using System.Windows.Forms;

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
            fileChooser.button.Click += selectAssociateFiles;
            language.languageCB.SelectionChanged += (e,d) => {
                Debug.WriteLine(language.GetSelectedItem());
            };
        }

        private void selectAssociateFiles(object sender, EventArgs e)
        {
            var openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.Multiselect = true;
            DialogResult result = openFileDialog.ShowDialog();
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
            testCaseContainer.Children.Add(new testCase(testCaseContainer));
        }

        private void CustomButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine(actName.GetTextFieldValue());
        }

        private void CustomButton_Click_1(object sender, RoutedEventArgs e)
        {
            var task = new Models.Task(actName.GetTextFieldValue(), instruction.GetTextFieldValue(), language.GetSelectedItem());
            foreach (var item in testCaseContainer.Children.OfType<testCase>())
            {
                task.Add_Test_Case(item.Test_Case());
            }

            Debug.WriteLine(task.ToString());
        }
    }
}
