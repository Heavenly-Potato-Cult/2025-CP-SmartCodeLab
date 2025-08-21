using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SmartCodeLab2.CustomComponents
{
    /// <summary>
    /// Interaction logic for CustomSideMenuButton.xaml
    /// </summary>
    public partial class CustomSideMenuButton : System.Windows.Controls.UserControl
    {
        public System.Windows.Controls.Button InnerButton => PART_Button;
        public CustomSideMenuButton()
        {
            InitializeComponent();

            
            PART_Button.Click += (s, e) =>
            {
                RaiseEvent(new RoutedEventArgs(ClickEvent));
            };
        }

        public bool IsSelected
        {
            get { return (bool)GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }


        public static readonly DependencyProperty IconProperty =
        DependencyProperty.Register(
            "Icon",
            typeof(string),
            typeof(CustomSideMenuButton));

        public static readonly DependencyProperty LabelProperty =
        DependencyProperty.Register(
            "Label",
            typeof(string),
            typeof(CustomSideMenuButton));


        public static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.Register(nameof(IsSelected), typeof(bool), typeof(CustomSideMenuButton),
                new PropertyMetadata(false));

        public string Icon
        {
            get => (string)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }



        
        public event RoutedEventHandler Click
        {
            add { PART_Button.Click += value; }
            remove { PART_Button.Click -= value; }
        }

        public static readonly RoutedEvent ClickEvent =
        EventManager.RegisterRoutedEvent(
            "Click",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(CustomSideMenuButton));


    }
}
