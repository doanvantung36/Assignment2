using AssAPI.Model;

namespace AssAPI.IRepositories.IRepository
{
    public interface IRoleRepository
    {
        IEnumerable<Role> GetAllRoles();
        Role GetByID(int id);
        Role AddRole(Role Role);
        Role UpdateRole(Role Role);
        void DeleteRole(int id);
    }
}
