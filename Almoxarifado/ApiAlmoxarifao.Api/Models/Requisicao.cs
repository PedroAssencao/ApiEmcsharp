using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ApiAlmoxarifao.Api.Models
{
    [Table("requisicao")]
    public partial class Requisicao
    {
        public int ReqId { get; set; }
        public Departamento? req_departamento { get; set; }
        public Funcionario? req_funcionario { get; set; }
        public DateTime? req_date { get; set; }
        public List<ItensRequisiscao>? requisicao { get; set;}
    }
}
