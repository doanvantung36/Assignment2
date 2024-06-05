using System.ComponentModel.DataAnnotations;

namespace AssAPI.Model
{
    public class SanPham
    {
        [Key]
        public int MaSanPham {  get; set; }
        public string TenSanPham {  set; get; }
        public double Gia {  get; set; }
        public string NhaSanXuat { get; set; }
        public ICollection<HoaDonChiTiet> HoaDonChiTiet { get; set; }
    }
}
