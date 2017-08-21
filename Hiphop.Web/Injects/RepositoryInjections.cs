using Hiphop.Repository;
using Hiphop.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hiphop.Web.Injects
{
    public static class RepositoryInjections
    {
		public static void InjectRepositories(this IServiceCollection service)
		{
			service.AddScoped<ITestRepository, TestRepository>();
		}
    }
}
