using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bhukkhad.Models
{
    public class AdminMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdminId { get; set; }

        [Column(TypeName = "varchar(50)")]

        public string Email { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Password { get; set; }



    }
}
