using System.ComponentModel.DataAnnotations;

namespace AssAPI.Model
{
    public class Role
    {
        [Key]
        public int IdRole { get; set; }
        public string RoleName { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
