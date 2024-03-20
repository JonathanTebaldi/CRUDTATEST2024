using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDTATEST2024.Models
{
    public class Item
    {
        [Display(Name = "ID: ")]
        [Key]
        public int id { get; set; }

        [Display(Name = "Venda: ")]
        public int vendaId { get; set; }
        [ForeignKey("vendaId")]
        public Venda venda { get; set; }

        [Display(Name = "Produto: ")]
        public int produtoId { get; set; }
        [ForeignKey("produtoId")]
        public Produto produto { get; set; }

        [Display(Name = "Quantidadde: ")]
        public float quantidade { get; set; }

        [Display(Name = "Valor: ")]
        public float valor { get; set; }
    }
}
