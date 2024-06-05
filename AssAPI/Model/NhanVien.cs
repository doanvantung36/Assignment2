using System.ComponentModel.DataAnnotations;

namespace AssAPI.Model
{
    public class NhanVien
    {
        [Key]
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Address { get; set; }
        public string SoDienThoai { get; set; }
        public string Email {  get; set; }

        public ICollection<HoaDon> HoaDon { get; set; }

    }
}
