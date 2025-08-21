namespace SmartCodeLab2.Pages.CustomTabItem
{
    internal class CustomTabItem : HandyControl.Controls.TabItem
    {
        public CustomTabItem(CustomTabContent content, System.Windows.Controls.TabControl tabControl)
        {
            var tabHeader = content.TabHeader;
            Header = tabHeader;
            Content = content;
            tabHeader.CloseRequested += (sender, e) =>
            {
                tabControl.Items.Remove(this);
                tabControl.UpdateLayout();
            };
            tabControl.SelectedIndex = tabControl.Items.Count;
        }
    }
}
