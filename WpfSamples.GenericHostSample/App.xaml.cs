using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using WpfSamples.GenericHostSample.Repositories;
using WpfSamples.GenericHostSample.Services;

namespace WpfSamples.GenericHostSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost _host = CreateHostBuilder().Build();

        private async void StartApplication(object sender, StartupEventArgs e)
        {
            await _host.StartAsync();

            var mainWindow = _host.Services.GetService<MainWindow>();
            mainWindow.Show();
        }

        private async void ExitApplication(object sender, ExitEventArgs args)
        {
            using (_host)
                await _host.StopAsync();
        }

        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddScoped<IUserService, UserService>();
                    services.AddSingleton<IUserRepository, UserRepository>();

                    services.AddSingleton<MainWindow>();
                });
        }
    }
}
