using AssAPI.AppDbContext;
using AssAPI.IRepositories.IRepository;
using AssAPI.Model;

namespace AssAPI.IRepositories.Repository
{
    public class SanPhamRepository : ISanPhamRepository
    {
        private readonly AppDbContexts _context;

        public SanPhamRepository()
        {
             _context = new AppDbContexts();
        }
        public SanPham AddSanPham(SanPham SanPham)
        {
            try
            {
                _context.SanPham.Add(SanPham);
                _context.SaveChanges();
                return SanPham;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteSanPham(int id)
        {
            var findIdDelete = _context.SanPham.FirstOrDefault(l => l.MaSanPham == id);
            try
            {
                _context.SanPham.Remove(findIdDelete);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public IEnumerable<SanPham> GetAllSanPhams()
        {
            try
            {
                return _context.SanPham.ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public SanPham GetByID(int id)
        {
            var findId = _context.SanPham.FirstOrDefault(s => s.MaSanPham == id);
            try
            {
                
                if (findId != null)
                {
                    return null;
                }
                return findId;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public SanPham UpdateSanPham(SanPham SanPham)
        {

            var findIdUpdate = _context.SanPham.FirstOrDefault(l => l.MaSanPham  == SanPham.MaSanPham);
            try
            {
                if (findIdUpdate == null)
                {
                    return null;
                }
                else
                {
                    _context.SanPham.Update(SanPham);
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
