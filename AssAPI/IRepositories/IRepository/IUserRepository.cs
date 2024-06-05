using AssAPI.Model;

namespace AssAPI.IRepositories.IRepository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetByID(int id);
        User AddUser(User User);
        User UpdateUser(User User);
        void DeleteUser(int id);
    }
}
