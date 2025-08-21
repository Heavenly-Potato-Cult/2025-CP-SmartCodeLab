using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;



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
            SetActiveMenu(SideMenuStudents);
            ShowGrid(new Grid1("Grid 1"));

        }
        private void SideMenuFiles_Click(object sender, RoutedEventArgs e)
        {
            SetActiveMenu(SideMenuFiles);
            ShowGrid(new Grid2());

        }

        private void SideMenuInstructions_Click(object sender, RoutedEventArgs e)
        {
            SetActiveMenu(SideMenuInstructions);
            ShowGrid(new Grid3());

        }

        private void SideMenuExit_Click(object sender, RoutedEventArgs e)
        {
            SetActiveMenu(SideMenuExit);
            this.Close();

        }


        private void SetActiveMenu(CustomComponents.CustomSideMenuButton selectedButton)
        {
            // Reset all buttons
            SideMenuStudents.PART_Button.Background = System.Windows.Media.Brushes.Transparent;
            SideMenuFiles.PART_Button.Background = System.Windows.Media.Brushes.Transparent;
            SideMenuInstructions.PART_Button.Background = System.Windows.Media.Brushes.Transparent;
            SideMenuExit.PART_Button.Background = System.Windows.Media.Brushes.Transparent;

            // Highlight the selected one
            selectedButton.PART_Button.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(60, 60, 60)); 
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