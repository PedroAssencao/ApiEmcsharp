using ApiAlmoxarifao.Api.Models;

namespace ApiAlmoxarifao.Api.ViewModel
{
    public class ViewModelListaDeRequisicao
    {
        public int CodigoDoDepartamento {  get; set; }
        public int funcionario { get; set; }
        public List<ItensRequisiscao> item { get; set; }
    }
}
