using SmartCodeLab2.CustomComponents;
using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace SmartCodeLab2.Pages.CustomTabItem
{
    /// <summary>
    /// Interaction logic for TaskTabItem.xaml
    /// </summary>
    public partial class TaskTabItem : CustomTabContent
    {
        public TaskTabItem(string headerText) : base(headerText)
        {
            InitializeComponent();
            setFields([taskName.textField1, instruction.textField1]);
        }
        private void CustomButton_Click(object sender, RoutedEventArgs e)
        {
            testCaseContainer.Children.Add(new testCase(testCaseContainer));
        }
    }
}
