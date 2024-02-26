using ApiAlmoxarifao.Api.DAL;
using ApiAlmoxarifao.Api.Models;

namespace ApiAlmoxarifao.Api.Repository
{
    public class ProdutoRepositroy : BaseRepository<Produto>
    {
        public ProdutoRepositroy(AlmoxarifadoContext context) : base(context)
        {
        }

        public async Task<Produto> AdicionarImagem(ProdutoView model)
        {
            var caminho = Path.Combine("Storage", model.ProImg.FileName);
            using Stream filestream = new FileStream(caminho, FileMode.Create);
            model.ProImg.CopyTo(filestream);
            var produto = new Produto();
            produto.ProNome = model.ProNome;
            produto.ProImg = caminho;
            produto.ProEstoque = model.ProEstoque;
            produto.CatId = model.CatId;
            return await Adicionar(produto);

        }
    }
}
