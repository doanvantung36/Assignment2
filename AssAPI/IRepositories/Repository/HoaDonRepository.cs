using AssAPI.AppDbContext;
using AssAPI.IRepositories.IRepository;
using AssAPI.Model;

namespace AssAPI.IRepositories.Repository
{
    public class HoaDonRepository : IHoaDonRepository
    {
        private readonly AppDbContexts _context;

        public HoaDonRepository()
        {
            _context = new AppDbContexts();
        }
        public HoaDon AddHoaDon(HoaDon HoaDon)
        {
            try
            {
                _context.HoaDons.Add(HoaDon);
                _context.SaveChanges();
                return HoaDon;

            }
            catch (Exception)
            {

                throw;
            }

        }
            
        

        public void DeleteHoaDon(int id)
        {
            var findIdDelete = _context.HoaDons.FirstOrDefault(l => l.MaHoaDon == id);
            try
            {
                _context.HoaDons.Remove(findIdDelete);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<HoaDon> GetAllHoaDons()
        {
            try
            {
                return _context.HoaDons.ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public HoaDon GetByID(int id)
        {
            var findId = _context.HoaDons.FirstOrDefault(s => s.MaHoaDon == id);
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

        public HoaDon UpdateHoaDon(HoaDon HoaDon)
        {
            var findIdUpdate = _context.HoaDons.FirstOrDefault(l => l.MaHoaDon == HoaDon.MaHoaDon);
            try
            {
                if (findIdUpdate == null)
                {
                    return null;
                }
                else
                {
                    _context.HoaDons.Update(HoaDon);
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
