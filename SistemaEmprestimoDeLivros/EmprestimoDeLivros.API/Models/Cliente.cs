using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoDeLivros.API.Models
{
    [Table("Cliente")]
    public partial class Cliente
    {
        public Cliente()
        {
            LivroClienteEmprestimos = new HashSet<LivroClienteEmprestimo>();
        }

        [Key]
        [Column("cli_id")]
        public int CliId { get; set; }
        [Column("cli_CPF")]
        [StringLength(14)]
        [Unicode(false)]
        public string? CliCpf { get; set; }
        [Column("cli_Nome")]
        [StringLength(200)]
        [Unicode(false)]
        public string? CliNome { get; set; }
        [Column("cli_endereco")]
        [StringLength(200)]
        [Unicode(false)]
        public string? CliEndereco { get; set; }
        [Column("cli_cidade")]
        [StringLength(100)]
        [Unicode(false)]
        public string? CliCidade { get; set; }
        [Column("cli_bairro")]
        [StringLength(100)]
        [Unicode(false)]
        public string? CliBairro { get; set; }
        [Column("cli_Numero")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CliNumero { get; set; }
        [Column("cli_TelefoneCelular")]
        [StringLength(14)]
        [Unicode(false)]
        public string? CliTelefoneCelular { get; set; }
        [Column("cli_TelefoneFixo")]
        [StringLength(13)]
        [Unicode(false)]
        public string? CliTelefoneFixo { get; set; }

        [InverseProperty(nameof(LivroClienteEmprestimo.LceIdClienteNavigation))]
        public virtual ICollection<LivroClienteEmprestimo> LivroClienteEmprestimos { get; set; }
    }
}
