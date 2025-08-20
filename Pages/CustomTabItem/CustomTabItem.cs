using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SmartCodeLab2.Pages.CustomTabItem
{
    internal class CustomTabItem : HandyControl.Controls.TabItem
    {
        public CustomTabItem(string headerText, System.Windows.Controls.UserControl content, System.Windows.Controls.TabControl tabControl)
        {
            var tabHeader = new CustomTabHeader(headerText);
            Header = tabHeader;
            Content = content;
            tabHeader.CloseRequested += (sender, e) =>
            {
                tabControl.Items.Remove(this);
                tabControl.UpdateLayout();
            };
        }
    }
}
