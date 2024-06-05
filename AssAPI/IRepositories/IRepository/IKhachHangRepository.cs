using AssAPI.Model;

namespace AssAPI.IRepositories.IRepository
{
    public interface IKhachHangRepository
    {
        IEnumerable<KhachHang> GetAllKhachHangs();
        KhachHang GetByID(int id);
        KhachHang AddKhachHang(KhachHang KhachHang);
        KhachHang UpdateKhachHang(KhachHang KhachHang);
        void DeleteKhachHang(int id);
    }
}
