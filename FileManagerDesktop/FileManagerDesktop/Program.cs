using FileManagerDesktop.Client;
using FileManagerDesktop.Client.Implementation;
using FileManagerDesktop.Forms;
using FileManagerDesktop.Services;
using FileManagerDesktop.Services.Implementation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FileManagerDesktop
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddMemoryCache();
                    services.AddSingleton<LoginForm>();
                    services.AddTransient<FileManagerForm>();
                    services.AddTransient<ReAuthenticationForm>();
                    services.AddTransient<IAuthenticationService, AuthenticationService>();
                    services.AddTransient<IAuthenticationClient, AuthenticationClient>();
                    services.AddTransient<ILogService, LogService>();
                    services.AddTransient<IFileClient, FileClient>();
                    services.AddTransient<IFileService, FileService>();

                });
        }
    }
}