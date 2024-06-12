using System.Windows;

namespace BlockLoader.PresentationLayer
{
    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
        }
        private async void LoadViewersButton_Click(object sender, RoutedEventArgs e)
        {
            await ((MainWindowViewModel)DataContext).LoadViewers();

            viewersColumn.Visibility = Visibility.Visible;

            blocksDataGrid.Items.Refresh();
        }

        private void LoadBlocksButton_Click(object sender, RoutedEventArgs e)
        {
            viewersColumn.Visibility = Visibility.Collapsed;
        }
    }
}
