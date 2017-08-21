using Hiphop.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiphop.Web.Injects
{
    public static class ServiceInjections
    {
		public static void InjectServices(this IServiceCollection service)
		{
			service.AddScoped<ITestService, TestService>();
		}
	}
}
