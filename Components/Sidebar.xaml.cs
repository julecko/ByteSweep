using System.Windows;
using System.Windows.Controls;

namespace ByteSweep.Components
{
    public partial class Sidebar : UserControl
    {
        public Sidebar()
        {
            InitializeComponent();
        }

        private void SidebarButton_Click(object sender, RoutedEventArgs e)
        {
            var tag = (sender as Button)?.Tag?.ToString();
            MessageBox.Show($"Clicked: {tag}");
        }
    }
}