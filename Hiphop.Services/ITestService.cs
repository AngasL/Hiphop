using Hiphop.Repository.Model;

namespace Hiphop.Services
{
	public interface ITestService
	{
		User GetUserById(int userId);
	}
}
