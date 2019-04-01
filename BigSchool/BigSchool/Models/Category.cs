using System.ComponentModel.DataAnnotations;

namespace BigSchool.Models
{
    public class Category
    {
       public byte Id { get; set; }
       [Required]
       [StringLength(225)]
       public string Name { get; set; }
    }
}