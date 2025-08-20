using Microsoft.Win32;
using SmartCodeLab2.CustomComponents;
using SmartCodeLab2.Models.TreeItemObject;
using SmartCodeLab2.Pages;
using SmartCodeLab2.Pages.CustomTabItem;
using System.Diagnostics;
using System.IO;
using System.Windows;

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

            //for choosing a file as a reference to the student's code
            //fileChooser.button.Click += selectAssociateFiles;
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
            //testCaseContainer.Children.Add(new testCase(testCaseContainer));
        }

        private void CustomButton_Click(object sender, RoutedEventArgs e)
        {
            //Debug.WriteLine(actName.GetTextFieldValue());
        }

        private void CustomButton_Click_1(object sender, RoutedEventArgs e)
        {
            //var task = new Models.Task(actName.GetTextFieldValue(), instruction.GetTextFieldValue(), language.GetSelectedItem());
            //foreach (var item in testCaseContainer.Children.OfType<testCase>())
            //{
            //    task.Add_Test_Case(item.Test_Case());
            //}

            //Debug.WriteLine(task.ToString());
        }

        private void FileMenu_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Create New File");
        }

        private void OpenFolder_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new FolderBrowserDialog();

            DialogResult result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                fileTree.Items.Clear();

                var rootItem = new FileItem(dialog.SelectedPath)
                {
                    Name = new DirectoryInfo(dialog.SelectedPath).Name
                };
                Debug.WriteLine(rootItem);
                fileTree.Items.Add(rootItem);
            }
        }

        private void Open_File_Selected(object sender, RoutedEventArgs e)
        {
            //check if the selected item on the FileTree is a file, if it is a fodler.. tapos ang usapan
            if (File.Exists(((FileItem)fileTree.SelectedItem).FullPath))
            {
                var customHeader = new CustomTabHeader();
                var newTab = new HandyControl.Controls.TabItem()
                {
                    Header = customHeader,
                    Content = new TaskTabItem()
                };
                customHeader.CloseRequested += (sender, e) =>
                {
                    tabControl.Items.Remove(newTab);
                };
                tabControl.Items.Add(newTab);
            }
        }
    }
}
