using AssAPI.AppDbContext;
using AssAPI.IRepositories.IRepository;
using AssAPI.Model;

namespace AssAPI.IRepositories.Repository
{
    public class KhachHangRepository : IKhachHangRepository
    {
        private readonly AppDbContexts _context;

        public KhachHangRepository()
        {
            _context = new AppDbContexts();
        }
        public KhachHang AddKhachHang(KhachHang KhachHang)
        {
            try
            {
                _context.KhachHang.Add(KhachHang);
                _context.SaveChanges();
                return KhachHang;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteKhachHang(int id)
        {
            var findIdDelete = _context.KhachHang.FirstOrDefault(l => l.IdKhachHang == id);
            try
            {
                _context.KhachHang.Remove(findIdDelete);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<KhachHang> GetAllKhachHangs()
        {
            try
            {
                return _context.KhachHang.ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public KhachHang GetByID(int id)
        {
            var findId = _context.KhachHang.FirstOrDefault(s => s.IdKhachHang == id);
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

        public KhachHang UpdateKhachHang(KhachHang KhachHang)
        {
            var findIdUpdate = _context.KhachHang.FirstOrDefault(l => l.IdKhachHang == KhachHang.IdKhachHang);
            try
            {
                if (findIdUpdate == null)
                {
                    return null;
                }
                else
                {
                    _context.KhachHang.Update(KhachHang);
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
