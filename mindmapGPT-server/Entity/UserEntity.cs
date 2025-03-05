using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mindmapGPT_server.Entity
{
    public class UserEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")] // Định nghĩa kiểu dữ liệu PostgreSQL
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "text")] // PostgreSQL sử dụng `text` thay vì nvarchar(max)
        public string PasswordHash { get; set; }

        [Required]
        public int Role { get; set; }
    }
}
