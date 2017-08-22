using Hiphop.Repository;
using Microsoft.Extensions.DependencyInjection;

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
