using AssAPI.AppDbContext;
using AssAPI.IRepositories.IRepository;
using AssAPI.Model;

namespace AssAPI.IRepositories.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly AppDbContexts _context;

        public RoleRepository()
        {
            _context = new AppDbContexts();
        }


        public Role AddRole(Role Role)
        {
            try
            {
                _context.Role.Add(Role);
                _context.SaveChanges();
                return Role;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteRole(int id)
        {
            var findIdDelete = _context.Role.FirstOrDefault(l => l.IdRole == id);
            try
            {
                _context.Role.Remove(findIdDelete);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Role> GetAllRoles()
        {
            try
            {
                return _context.Role.ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Role GetByID(int id)
        {
            var findId = _context.Role.FirstOrDefault(s => s.IdRole == id);
            try
            {
                if (findId != null)
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

        public Role UpdateRole(Role Role)
        {
            var findIdUpdate = _context.Role.FirstOrDefault(l => l.IdRole == Role.IdRole);
            try
            {
                if (findIdUpdate == null)
                {
                    return null;
                }
                else
                {
                   _context.Role.Update(Role);
                    _context.SaveChanges();
                    return findIdUpdate;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
