using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssAPI.Model
{
    public class HoaDon
    {
        [Key]
        public int MaHoaDon {  get; set; }
        public DateTime NgayXuat { get; set; }
        [ForeignKey("IdKhachHang")]
        public string IdKhachHang { get; set; }
        [ForeignKey("MaNhanVien")]
        public string MaNhanVien {  get; set; }
        public string TrangThai {  get; set; }
        public double TongThanhToan {  get; set; }

        public KhachHang KhachHang { get; set; }
        public NhanVien NhanVien { get; set; }
        public ICollection<HoaDonChiTiet> HoaDonChiTiet { get; set; }
    }
}
