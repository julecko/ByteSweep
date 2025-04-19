using System.Windows.Controls;
using System.Windows;

namespace ByteSweep.Components
{
    public partial class SidebarOption : UserControl
    {
        public SidebarOption()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(SidebarOption), new PropertyMetadata(string.Empty));

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(object), typeof(SidebarOption), new PropertyMetadata(null));

        public object Icon
        {
            get => GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        private void SidebarButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle click if needed
        }
    }
};