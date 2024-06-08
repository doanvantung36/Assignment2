using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssAPI.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        [ForeignKey("IdRole")]
        public int IdRole { get; set; }
        public Role Role { get; set; }
    }
}
