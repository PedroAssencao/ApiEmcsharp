using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoDeLivros.API.Models
{
    [Table("LivroClienteEmprestimo")]
    public partial class LivroClienteEmprestimo
    {
        [Key]
        [Column("lce_id")]
        public int LceId { get; set; }
        [Column("lce_idCliente")]
        public int? LceIdCliente { get; set; }
        [Column("lce_idLivro")]
        public int? LceIdLivro { get; set; }
        [Column("lce_dataEmprestimo", TypeName = "datetime")]
        public DateTime? LceDataEmprestimo { get; set; }
        [Column("lce_dataEntrega", TypeName = "datetime")]
        public DateTime? LceDataEntrega { get; set; }
        [Column("lce_entregue")]
        public bool? LceEntregue { get; set; }

        [ForeignKey(nameof(LceIdCliente))]
        [InverseProperty(nameof(Cliente.LivroClienteEmprestimos))]
        public virtual Cliente? LceIdClienteNavigation { get; set; }
        [ForeignKey(nameof(LceIdLivro))]
        [InverseProperty(nameof(Livro.LivroClienteEmprestimos))]
        public virtual Livro? LceIdLivroNavigation { get; set; }
    }
}
