using System;
using System.Collections.Generic;
using System.Text;
using Hiphop.Repository.Model;
using System.Linq;

namespace Hiphop.Repository
{
	public class TestRepository : ITestRepository
	{
		private HiphopContext _context;

		public TestRepository(HiphopContext context)
		{
			_context = context;
		}
		public User GetUserById(int userId)
		{
			return _context.Users.FirstOrDefault(u => u.UserId == userId);
		}
	}
}
