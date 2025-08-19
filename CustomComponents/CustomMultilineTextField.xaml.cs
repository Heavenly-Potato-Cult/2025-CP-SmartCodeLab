using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SmartCodeLab2.CustomComponents
{
    /// <summary>
    /// Interaction logic for CustomMultilineTextField.xaml
    /// </summary>
    public partial class CustomMultilineTextField : System.Windows.Controls.UserControl
    {
        public CustomMultilineTextField()
        {
            InitializeComponent();
            textField1.KeyDown += (sender, e) => {
                textField1.Height += 30;
            };
        }

        private void textField1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as System.Windows.Controls.TextBox;

            // Force wrap at specific character count (e.g., 50 characters per line)
            if (textBox.Text.Length > 0)
            {
                var lines = textBox.Text.Split('\n');
                bool modified = false;

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Length > 50) // Adjust this number as needed
                    {
                        // Insert line break every 50 characters
                        lines[i] = string.Join("\n", SplitIntoChunks(lines[i], 50));
                        modified = true;
                    }
                }

                if (modified)
                {
                    int cursorPos = textBox.SelectionStart;
                    textBox.Text = string.Join("\n", lines);
                    textBox.SelectionStart = cursorPos;
                }
            }
        }

        private string[] SplitIntoChunks(string text, int chunkSize)
        {
            var chunks = new List<string>();
            for (int i = 0; i < text.Length; i += chunkSize)
            {
                chunks.Add(text.Substring(i, Math.Min(chunkSize, text.Length - i)));
            }
            return chunks.ToArray();
        }

        public string LabelText
        {
            get { return textLabel.Content?.ToString() ?? ""; }
            set { textLabel.Content = value; }
        }

        public int LabelWidth
        {
            set { textLabel.Width = value; }
        }

        public int LabelHeight
        {
            set { textLabel.Height = value; }
        }
        public int LabelFontSize
        {
            set { textLabel.FontSize = value; }
        }

        public int TextFieldHeight
        {
            set { textField1.Height = value;
                textField1.MaxHeight = value;
                textField1.MinHeight = value;
            }
        }

        public int TextFieldWidth
        {
            set { textField1.Width = value;
                textField1.MaxWidth = value;
                textField1.MinWidth = value;
            }
        }
    }
}
