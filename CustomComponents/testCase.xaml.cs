using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SmartCodeLab2.CustomComponents
{
    /// <summary>
    /// Interaction logic for testCase.xaml
    /// </summary>
    public partial class testCase : Grid, IDisposable
    {
        private WrapPanel _parentPanel;
        private bool _disposed = false;

        public testCase(WrapPanel parentPanel)
        {
            InitializeComponent();
            _parentPanel = parentPanel;

            closeBtn.MouseDown += CloseBtn_MouseDown;
        }

        public KeyValuePair<string,string> Test_Case()
        {
            return new KeyValuePair<string, string>(inputs.GetTextFieldValue(), output.GetTextFieldValue());
        }

        private void CloseBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Dispose();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                // Free managed resources
                closeBtn.MouseDown -= CloseBtn_MouseDown;

                // Remove event handlers from other controls if any
                // this.Click -= SomeHandler;

                // Remove from parent
                if (_parentPanel != null && _parentPanel.Children.Contains(this))
                {
                    _parentPanel.Children.Remove(this);
                }

                _parentPanel = null; // Remove reference
            }

            // Free unmanaged resources here (if any)

            _disposed = true;
        }
    }
}
