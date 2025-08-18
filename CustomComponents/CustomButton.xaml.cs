using System.Windows;

namespace SmartCodeLab2.CustomComponents
{
    /// <summary>
    /// Interaction logic for CustomButton.xaml
    /// </summary>
    public partial class CustomButton : System.Windows.Controls.Button
    {
        public CustomButton()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register(
            "Text",
            typeof(string),
            typeof(CustomButton),
            new PropertyMetadata(string.Empty, OnTextChanged));

        public string Text
        {
            set => SetValue(TextProperty, value);
        }
        private static void OnTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var button = d as CustomButton;
            if (button != null)
            {
                button.Content = e.NewValue;
            }
        }
    }
}
