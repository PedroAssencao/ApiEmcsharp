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
        [Key]
        [Column("req_id")]
        public int ReqId { get; set; }
        [Column("req_data")]
        [StringLength(255)]
        [Unicode(false)]
        public string ReqData { get; set; } = null!;
        [Column("req_observacao")]
        [StringLength(255)]
        [Unicode(false)]
        public string? ReqObservacao { get; set; }
    }
}
