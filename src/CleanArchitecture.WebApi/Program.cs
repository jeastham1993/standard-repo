// ------------------------------------------------------------
// Copyright (c) James Eastham.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CleanArchitecture.WebApi
{
    /// <summary>
    /// Main program entrypoint.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Main program entrypoint.
        /// </summary>
        /// <param name="args">Application startup arguments.</param>
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Create a new web host.
        /// </summary>
        /// <param name="args">Application startup arguments.</param>
        /// <returns>A <see cref="IHostBuilder"/>.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        }
    }
}
