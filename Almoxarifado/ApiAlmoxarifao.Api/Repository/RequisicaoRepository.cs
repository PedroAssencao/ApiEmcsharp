using ApiAlmoxarifao.Api.DAL;
using ApiAlmoxarifao.Api.Models;

namespace ApiAlmoxarifao.Api.Repository
{
    public class RequisicaoRepository : BaseRepository<Requisicao>
    {
        public RequisicaoRepository(AlmoxarifadoContext context) : base(context)
        {
        }
    }
}
