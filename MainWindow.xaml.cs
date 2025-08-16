using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using HandyControl.Controls;



namespace SmartCodeLab2
{
    public partial class MainWindow : System.Windows.Window
    {
        public double MenuWidth { get; set; } = 180;
        public string OverviewHeader { get; set; } = "Overview";
        public string FilesHeader { get; set; } = "Files";
        public string ExitHeader { get; set; } = "Exit";

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void ToggleMenu_Click(object sender, RoutedEventArgs e)
        {
            if (MenuWidth > 60)
            {
                MenuWidth = 50; // collapsed
                OverviewHeader = "";
                FilesHeader = "";
                ExitHeader = "";
            }
            else
            {
                MenuWidth = 100; // expanded
                OverviewHeader = "Overview";
                FilesHeader = "Files";
                ExitHeader = "Exit";

            }

            DataContext = null;
            DataContext = this; // refresh bindings
        }

        private void ToggleStudents_Click(object sender, RoutedEventArgs e)
        {
            grid1.Visibility = Visibility.Collapsed;
            grid2.Visibility = Visibility.Visible;
            grid3.Visibility = Visibility.Collapsed;
        }

        private void MySideMenu_SelectionChanged(object sender, HandyControl.Data.FunctionEventArgs<object> e)
        {
            //if (MySideMenu.SelectedItem is hcSideMenuItem item)
            //{
            //    string header = item.Header?.ToString();

            //    grid1.Visibility = (header == "Overview") ? Visibility.Visible : Visibility.Collapsed;
            //    grid2.Visibility = (header == "Files") ? Visibility.Visible : Visibility.Collapsed;
            //    grid3.Visibility = (header == "Exit") ? Visibility.Visible : Visibility.Collapsed;

            //    if (header == "Exit")
            //    {
            //        this.Close();
            //    }
            //}

        }
    }
}