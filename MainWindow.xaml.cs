using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using HandyControl.Controls;



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

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            ShowGrid(grid3);

        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}