using Hiphop.Repository.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiphop.Services
{
	public interface ITestService
	{
		User GetUserById(int userId);
	}
}
