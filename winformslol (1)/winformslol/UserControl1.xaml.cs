using System;
using System.Collections.Generic;
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
using ICSharpCode.AvalonEdit;

namespace winformslol
{
    // Winform Avalon Tabs by Lxnny
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            maintabs.Items.Add(CreateTab("-- Welcome!", "Script" + " " + this.maintabs.Items.Count.ToString()));

        }

        public monaco_api current_monaco()
        {
            return maintabs.SelectedContent as monaco_api;
        }

        public void add_tab_with_text(string text)
        {
            maintabs.Items.Add(CreateTab(text, "Script" + " " + this.maintabs.Items.Count.ToString()));
        }

        

        private void ButtonTabs(object sender, RoutedEventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "AddT":
                    maintabs.Items.Add(CreateTab("-- Welcome!", "Script" + " " + this.maintabs.Items.Count.ToString()));

                    break;
                case "RemoveT":
                    try
                    {
                        if (maintabs.Items.Count > 1)
                        {
                            maintabs.Items.Remove(maintabs.SelectedItem);

                        }
                    }
                    catch { }
                    break;
            }
        }
        public monaco_api CreateEditor(string Start) => new monaco_api(Start);



        public TabItem CreateTab(string content, string Title = "Untitled") => 
            new TabItem
            {
                Header = Title,
                Style = TryFindResource("EETABSSSSSS") as Style,
                Foreground = Brushes.White,
                FontSize = 12,
                Content = CreateEditor(content),
                IsSelected = true,
            };

    }
}
