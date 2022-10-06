using System;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using R5T.F0036.F001;


namespace R5T.F0037.Construction
{
    public class ServicesConfigurer02 : IAsynchronousServicesConfigurer
    {
        public Task ConfigureServices(IServiceCollection services)
        {
            // Do nothing.

            return Task.CompletedTask;
        }
    }
}