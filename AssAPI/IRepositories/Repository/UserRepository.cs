using AssAPI.AppDbContext;
using AssAPI.IRepositories.IRepository;
using AssAPI.Model;

namespace AssAPI.IRepositories.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContexts _context;

        public UserRepository()
        {
            _context = new AppDbContexts();
        }
        public User AddUser(User User)
        {
            try
            {
                _context.Users.Add(User);
                _context.SaveChanges();
                return User;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteUser(int id)
        {
            var findIdDelete = _context.Users.FirstOrDefault(l => l.Id == id);
            try
            {
                _context.Users.Remove(findIdDelete);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            try
            {
                return _context.Users.ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public User GetByID(int id)
        {
            var findId = _context.Users.FirstOrDefault(s => s.Id == id);
            try
            {
                if (findId == null)
                {
                    return null;
                }
                else
                {
                    return findId;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public User UpdateUser(User User)
        {
            var findIdUpdate = _context.Users.FirstOrDefault(l => l.Id == User.Id);
            try
            {
                if (findIdUpdate == null)
                {
                    return null;
                }
                else
                {
                    _context.Users.Update(User);
                    _context.SaveChanges();
                    return User;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
