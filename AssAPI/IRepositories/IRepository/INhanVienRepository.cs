using AssAPI.Model;

namespace AssAPI.IRepositories.IRepository
{
    public interface INhanVienRepository
    {
        IEnumerable<NhanVien> GetAllNhanViens();
        NhanVien GetByID(int id);
        NhanVien AddNhanVien(NhanVien NhanVien);
        NhanVien UpdateNhanVien(NhanVien NhanVien);
        void DeleteNhanVien(int id);
    }
}
