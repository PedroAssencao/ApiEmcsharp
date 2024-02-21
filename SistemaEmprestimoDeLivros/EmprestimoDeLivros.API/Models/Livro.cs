using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoDeLivros.API.Models
{
    public partial class Livro
    {
        public Livro()
        {
            LivroClienteEmprestimos = new HashSet<LivroClienteEmprestimo>();
        }

        [Key]
        [Column("liv_id")]
        public int LivId { get; set; }
        [Column("liv_Nome")]
        [StringLength(50)]
        [Unicode(false)]
        public string? LivNome { get; set; }
        [Column("liv_Autor")]
        [StringLength(200)]
        [Unicode(false)]
        public string? LivAutor { get; set; }
        [Column("liv_editora")]
        [StringLength(100)]
        [Unicode(false)]
        public string? LivEditora { get; set; }
        [Column("liv_AnoDePublicacao", TypeName = "datetime")]
        public DateTime? LivAnoDePublicacao { get; set; }
        [Column("liv_Edicao")]
        [StringLength(50)]
        [Unicode(false)]
        public string? LivEdicao { get; set; }

        [InverseProperty(nameof(LivroClienteEmprestimo.LceIdLivroNavigation))]
        public virtual ICollection<LivroClienteEmprestimo> LivroClienteEmprestimos { get; set; }
    }
}
