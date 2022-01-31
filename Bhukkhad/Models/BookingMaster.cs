using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bhukkhad.Models
{
    public class BookingMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        [Required]
        [Column(TypeName ="varchar(50)")]
        public string Ename { get; set; }   

        [Column(TypeName ="varchar(50)")]
        public string EAddress { get; set; }

        [Column(TypeName ="varchar(50)")]
        public string EDate { get; set; }

        [Column(TypeName ="varchar(50)")]
        public string ECalltime { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string CName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string CPhone { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Password { get; set; }


    }
}
