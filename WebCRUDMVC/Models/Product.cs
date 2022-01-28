using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCRUDMVC.Models
{
    [Table("product")]
    public class Product
    {
        [Column("Id")]
        [Display(Name = "Code")]
        public int Id { get; set; }

        [Column("Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
