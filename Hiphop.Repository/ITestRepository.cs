using Hiphop.Repository.Model;
using System;

namespace Hiphop.Repository
{
    public interface ITestRepository
    {
		User GetUserById(int userId);
    }
}
