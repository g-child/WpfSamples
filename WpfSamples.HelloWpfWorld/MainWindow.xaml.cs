using System.Windows;

namespace WpfSamples.HelloWpfWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int ClickCount { get; set; } = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickMe_Click(object sender, RoutedEventArgs e)
        {
            ClickCount++;
            UserInformation.Text = $"Hello WPF World!\n Count: {ClickCount}";
        }
    }
}
