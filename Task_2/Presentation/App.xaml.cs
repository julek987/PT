using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Presentation.View;
using Presentation.ViewModel;

namespace Presentation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IServiceProvider serviceProvider;

        public App()
        {
            ServiceCollection services = new ServiceCollection();

            services.AddSingleton<Main>(s => new Main()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            }
            );
            services.AddSingleton<MainViewModel>();

            serviceProvider = services.BuildServiceProvider();
        }
    }
}