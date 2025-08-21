using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SmartCodeLab2.Pages.CustomTabItem
{
    public class CustomTabContent : System.Windows.Controls.UserControl
    {
        private CustomTabHeader _tabHeader;
        
        public CustomTabContent(string headerText)
        {
            _tabHeader = new CustomTabHeader(headerText);
        }

        public void setFields(System.Windows.Controls.TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.TextChanged += (sender, e) =>
                {
                    _tabHeader.FontWeight = System.Windows.FontWeights.Bold;
                };
            }
        }
        public CustomTabHeader TabHeader
        {
            get { return _tabHeader; }
        }
    }
}
