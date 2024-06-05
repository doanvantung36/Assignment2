using AssAPI.Model;

namespace AssAPI.IRepositories.IRepository
{
    public interface IHoaDonRepository
    {
        IEnumerable<HoaDon> GetAllHoaDons();
        HoaDon GetByID(int id);
        HoaDon AddHoaDon(HoaDon HoaDon);
        HoaDon UpdateHoaDon(HoaDon HoaDon);
        void DeleteHoaDon(int id);
    }
}
