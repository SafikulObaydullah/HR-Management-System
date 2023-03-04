using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiCoreLecture.Model
{
   public class TblDesignation
   {

      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public int Id { get; set; }
      [StringLength(250)]
      public string Designation { get; set; }
   }
}
