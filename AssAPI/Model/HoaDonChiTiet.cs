using System.ComponentModel.DataAnnotations.Schema;

namespace AssAPI.Model
{
    public class HoaDonChiTiet
    {
        [ForeignKey("MaHoaDon")]
        public int MaHoaDon {  get; set; }

        [ForeignKey("MaSanPham")]
        public int MaSanPham {  get; set; }
        public int SoLuong { get; set; }

        public HoaDon HoaDon { get; set; }
        public SanPham SanPham { get; set; }
    }
}
