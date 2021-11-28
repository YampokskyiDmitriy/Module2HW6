using Microsoft.Extensions.DependencyInjection;
using Module2HW6.Provider;
using Module2HW6.Provider.Abstractions;
using Module2HW6.Services;
using Module2HW6.Services.Abstractions;

namespace Module2HW6
{
    public class Starter
    {
        public void Run()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IApplianceProvider, ApplianceProvider>()
                .AddTransient<IApplianceService, ApplianceService>()
                .AddTransient<App>()
                .BuildServiceProvider();
            var app = serviceProvider.GetService<App>();
            app?.Run();
        }
    }
}
