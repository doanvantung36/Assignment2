using AssAPI.Model;

namespace AssAPI.IRepositories.IRepository
{
    public interface INhanVienRepository
    {
        public IEnumerable<NhanVien> GetAllNhanViens();
        public NhanVien GetByID(int id);
        NhanVien AddNhanVien(NhanVien NhanVien);
        NhanVien UpdateNhanVien(NhanVien NhanVien);
        void DeleteNhanVien(int id);
    }
}
