using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameWork.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string nome { get; set; }
    }
}
