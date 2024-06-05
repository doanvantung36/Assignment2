using AssAPI.Model;

namespace AssAPI.IRepositories.IRepository
{
    public interface IHoaDonChiTietRepository
    {
        IEnumerable<HoaDonChiTiet> GetAllHoaDonChiTiets();
        HoaDonChiTiet GetByID(int id);
        HoaDonChiTiet AddHoaDonChiTiet(HoaDonChiTiet HoaDonChiTiet);
        HoaDonChiTiet UpdateHoaDonChiTiet(HoaDonChiTiet HoaDonChiTiet);
        void DeleteHoaDonChiTiet(int id);
    }
}
