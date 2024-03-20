using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDTATEST2024.Models
{
    [Table("Venda")]
    public class Venda
    {
        [Key]
        [Display(Name = "ID: ")]
        public int id { get; set; }

        [Display(Name = "Cliente: ")]
        public int clientId { get; set; }

        [ForeignKey("clientId")]
        public Cliente cliente { get; set; }

        [Display(Name = "Data: ")]
        public DateTime data { get; set; }
    }
}
