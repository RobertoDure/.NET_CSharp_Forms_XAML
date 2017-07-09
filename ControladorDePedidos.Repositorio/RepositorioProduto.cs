using ControladorDePedidos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorDePedidos.Repositorio
{
    public class RepositorioProduto : RepositorioGenerico<Produto>
    {
        public override void Adicione(Produto produto)
        {
            var marcaOriginal = contexto.Set<Marca>().Find(produto.Marca.Codigo);
            var fornecedorOriginal = contexto.Set<Fornecedor>().Find(produto.Fornecedor.Codigo);

            produto.Marca = marcaOriginal;
            produto.Fornecedor = fornecedorOriginal;

            base.Adicione(produto);
        }

        public override void Atualize(Produto produto)
        {
            var produtoOriginal = contexto.Set<Produto>().Find(produto.Codigo);
            var marcaOriginal = contexto.Set<Marca>().Find(produto.Marca.Codigo);
            var fornecedorOriginal = contexto.Set<Fornecedor>().Find(produto.Fornecedor.Codigo);

            contexto.Entry(produtoOriginal).CurrentValues.SetValues(produto);

            produtoOriginal.Marca = marcaOriginal;
            produtoOriginal.Fornecedor = fornecedorOriginal;

            contexto.SaveChanges();
        }

        public List<Produto> Buscar(string termoDaBusca)
        {
            contexto = new Contexto();
            var lista = contexto.Set<Produto>().Where(x => x.Nome.Contains(termoDaBusca)).ToList();
            return lista;
        }

        public Produto Buscar(int codigo)
        {
            contexto = new Contexto();
            return contexto.Set<Produto>().FirstOrDefault(x => x.Codigo == codigo);
        }

        public List<Produto> ObtenhaProdutosComEstoqueBaixo()
        {
            contexto = new Contexto();
            var lista = contexto.Set<Produto>().Where(x => x.QuantidadeEmEstoque < x.QuantidadeDesejavelEmEstoque).ToList();
            return lista;
        }
    }
}
