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
            throw new NotImplementedException();
        }

        public void DeleteSanPham(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SanPham> GetAllSanPhams()
        {
            throw new NotImplementedException();
        }

        public SanPham GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public SanPham UpdateSanPham(SanPham SanPham)
        {
            throw new NotImplementedException();
        }
    }
}
