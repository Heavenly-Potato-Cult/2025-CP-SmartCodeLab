using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;



namespace SmartCodeLab2
{
    public partial class MainWindow : System.Windows.Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void ShowGrid(System.Windows.Controls.UserControl gridToShow)
        {
            cc.Content = gridToShow;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }



        private void SideMenuStudents_Click(object sender, RoutedEventArgs e)
        {
            ShowGrid(new Grid1("Grid 1"));

        }
        private void SideMenuFiles_Click(object sender, RoutedEventArgs e)
        {
            ShowGrid(new Grid2());

        }

        private void SideMenuInstructions_Click(object sender, RoutedEventArgs e)
        {
            ShowGrid(new Grid3());

        }

        private void SideMenuExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }




















        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void AssociateFile_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void DisplayInstruction_Click(object sender, RoutedEventArgs e)
        {
           
        }

        
    }
}