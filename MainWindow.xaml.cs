using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using HandyControl.Controls;
using System.IO;



namespace SmartCodeLab2
{
    public partial class MainWindow : System.Windows.Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void ShowGrid(Grid gridToShow)
        {
            // Hide all
            grid1.Visibility = Visibility.Collapsed;
            grid2.Visibility = Visibility.Collapsed;
            grid3.Visibility = Visibility.Collapsed;

            // Show only the one requested
            gridToShow.Visibility = Visibility.Visible;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

       

       
 
        private void StudentsButton_Click(object sender, RoutedEventArgs e)
        {
            ShowGrid(grid1);
        }

        private void FilesButton_Click(object sender, RoutedEventArgs e)
        {
            ShowGrid(grid2);

        }
        private void InstructionsButton_Click(object sender, RoutedEventArgs e)
        {
            ShowGrid(grid3);
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {

        }


        private void AddFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = "Code Files|*.cpp;*.cs;*.java;*.txt|All Files|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileList.Items.Add(dlg.FileName);
            }
        }

        private void DeleteFile_Click(object sender, RoutedEventArgs e)
        {
            if (FileList.SelectedItem != null)
            {
                FileList.Items.Remove(FileList.SelectedItem);
                FilePreview.Clear();
            }
        }

        private void FileList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FileList.SelectedItem != null)
            {
                string filePath = FileList.SelectedItem.ToString();
                FilePreview.Text = File.ReadAllText(filePath);
            }
        }



        private void AddInstruction_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(InstructionBox.Text))
            {
                InstructionList.Items.Add($"{TaskNameBox.Text}: {InstructionBox.Text}");
                InstructionBox.Clear();
                TaskNameBox.Clear();
            }
        }

        private void EditInstruction_Click(object sender, RoutedEventArgs e)
        {
            if (InstructionList.SelectedItem != null)
            {
                
                string selected = InstructionList.SelectedItem.ToString();
                InstructionBox.Text = selected;
                InstructionList.Items.Remove(selected);
            }
        }

        private void DeleteInstruction_Click(object sender, RoutedEventArgs e)
        {
            if (InstructionList.SelectedItem != null)
            {
                InstructionList.Items.Remove(InstructionList.SelectedItem);
            }
        }

        private void InstructionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DisplayInstructionButton.Visibility = InstructionList.SelectedItem != null
                ? Visibility.Visible
                : Visibility.Collapsed;
        }
        private void AssociateFile_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void DisplayInstruction_Click(object sender, RoutedEventArgs e)
        {
           
        }




    }
}