using System.ComponentModel.DataAnnotations;

namespace AssAPI.Model
{
    public class KhachHang
    {
        [Key]
        public int IdKhachHang { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime NgayDangKi { get; set; }

        public ICollection<HoaDon> HoaDons { get; set; }
    }
}
