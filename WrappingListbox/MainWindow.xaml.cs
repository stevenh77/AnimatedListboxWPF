using System.Linq;

namespace WrappingListbox 
{
    using System.Windows;
    using System.Windows.Controls;

    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            listbox1.ItemsSource = Enumerable.Range(1, 100);
        }

        public void ListBoxItemSelected(object sender, RoutedEventArgs e)
        {
            Panel.SetZIndex((UIElement)sender, 999);
        }
    }
}