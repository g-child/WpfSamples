using System.Windows;
using WpfSamples.GenericHostSample.Services;

namespace WpfSamples.GenericHostSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IUserService _userService;

        public MainWindow(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private async void ClickMe_Click(object sender, RoutedEventArgs e)
        {
            var user = await _userService.GetUserAsync("12345");
            UserInformation.Text = user.Text;
        }
    }
}
