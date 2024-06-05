using AssAPI.IRepositories.IRepository;
using AssAPI.Model;

namespace AssAPI.IRepositories.Repository
{
    public class UserRepository : IUserRepository
    {
        public User AddUser(User User)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User User)
        {
            throw new NotImplementedException();
        }
    }
}
