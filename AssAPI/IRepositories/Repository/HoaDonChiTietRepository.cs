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
            var findIdDelete = _context.HoaDonChiTiets.FirstOrDefault(l => l.MaHoaDon == id);
            try
            {
                _context.HoaDonChiTiets.Remove(findIdDelete);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<HoaDonChiTiet> GetAllHoaDonChiTiets()
        {
            try
            {
                return _context.HoaDonChiTiets.ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public HoaDonChiTiet GetByID(int id)
        {
            var findId = _context.HoaDonChiTiets.FirstOrDefault(s=>s.MaHoaDon ==  id);
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

        public HoaDonChiTiet UpdateHoaDonChiTiet(HoaDonChiTiet HoaDonChiTiet)
        {
            var findIdUpdate = _context.HoaDonChiTiets.FirstOrDefault(l => l.MaHoaDon == HoaDonChiTiet.MaHoaDon);
            try
            {
                if (findIdUpdate == null)
                {
                    return null;
                }
                else
                {
                    _context.HoaDonChiTiets.Update(HoaDonChiTiet);
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
