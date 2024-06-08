using AssAPI.Model;

namespace AssAPI.IRepositories.IRepository
{
    public interface IRoleRepository
    {
        public IEnumerable<Role> GetAllRoles();
        Role GetByID(int id);
        public Role AddRole(Role Role);
        Role UpdateRole(Role Role);
        void DeleteRole(int id);
    }
}
