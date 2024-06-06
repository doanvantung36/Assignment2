using AssAPI.AppDbContext;
using AssAPI.IRepositories.IRepository;
using AssAPI.Model;

namespace AssAPI.IRepositories.Repository
{
    public class NhanVienRepository : INhanVienRepository
    {
        private readonly AppDbContexts _context;

        public NhanVienRepository()
        {
            _context = new AppDbContexts();
        }
        public NhanVien AddNhanVien(NhanVien NhanVien)
        {
            try
            {
                _context.NhanVien.Add(NhanVien);
                _context.SaveChanges();
                return NhanVien;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteNhanVien(int id)
        {
            var findIdDelete = _context.NhanVien.FirstOrDefault(l => l.MaNhanVien == id);
            try
            {
                _context.NhanVien.Remove(findIdDelete);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<NhanVien> GetAllNhanViens()
        {
            try
            {
                return _context.NhanVien.ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public NhanVien GetByID(int id)
        {
            var findId = _context.NhanVien.FirstOrDefault(s => s.MaNhanVien == id);
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

        public NhanVien UpdateNhanVien(NhanVien NhanVien)
        {
            var findIdUpdate = _context.NhanVien.FirstOrDefault(l => l.MaNhanVien == NhanVien.MaNhanVien);
            try
            {
                if (findIdUpdate == null)
                {
                    return null;
                }
                else
                {
                    _context.NhanVien.Update(NhanVien);
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
