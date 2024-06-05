using AssAPI.AppDbContext;
using AssAPI.IRepositories.IRepository;
using AssAPI.Model;

namespace AssAPI.IRepositories.Repository
{
    public class HoaDonChiTietRepository : IHoaDonChiTietRepository
    {
        private readonly AppDbContexts _context;
        public HoaDonChiTietRepository(AppDbContexts appDbContext)
        {
            this._context = appDbContext;
        }
        public HoaDonChiTiet AddHoaDonChiTiet(HoaDonChiTiet HoaDonChiTiet)
        {
            try
            {
                _context.HoaDonChiTiets.Add(HoaDonChiTiet);
                _context.SaveChanges();
                return HoaDonChiTiet;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteHoaDonChiTiet(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<HoaDonChiTiet> GetAllHoaDonChiTiets()
        {
            return _context.HoaDonChiTiets.ToList();
        }

        public HoaDonChiTiet GetByID(int id)
        {
            var findId = _context.HoaDonChiTiets.FirstOrDefault(s=>s.MaHoaDon ==  id);
            if(findId != null)
            {
                return null;
            }
            return findId;
        }

        public HoaDonChiTiet UpdateHoaDonChiTiet(HoaDonChiTiet HoaDonChiTiet)
        {
            throw new NotImplementedException();
        }
    }
}
