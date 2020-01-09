// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure
{
    /// <summary>
    /// Setup of DI Container.
    /// </summary>
    public static class ContainerSetup
    {
        /// <summary>
        /// Add DI services.
        /// </summary>
        /// <param name="services">A <see cref="IServiceCollection"/>.</param>
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<ICreditScoreService, CreditScoreService>();
            services.AddTransient<ICustomerDatabase, CustomerDatabaseInMemoryImpl>();
        }
    }
}
