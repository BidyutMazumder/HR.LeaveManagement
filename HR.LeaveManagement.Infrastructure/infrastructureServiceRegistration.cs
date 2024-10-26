using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Infrastructure
{
    public static class infrastructureServiceRegistration
    {
        public static IServiceCollection ConfigureInfrastructureServices (this IServiceCollection service, IConfiguration configuration)
        {
            return service;
        }
    }
}
