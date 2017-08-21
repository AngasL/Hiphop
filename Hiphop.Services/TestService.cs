using System;
using Hiphop.Repository;
using Hiphop.Repository.Model;

namespace Hiphop.Services
{
	public class TestService : ITestService
	{
		private readonly ITestRepository _repository;
		public TestService(ITestRepository repository)
		{
			_repository = repository;
		}

		public User GetUserById(int userId)
		{
			return _repository.GetUserById(userId);
		}
	}
}
