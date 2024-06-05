using AssAPI.Model;

namespace AssAPI.IRepositories.IRepository
{
    public interface ISanPhamRepository
    {
        IEnumerable<SanPham> GetAllSanPhams();
        SanPham GetByID(int id);
        SanPham AddSanPham(SanPham SanPham);
        SanPham UpdateSanPham(SanPham SanPham);
        void DeleteSanPham(int id);
    }
}
