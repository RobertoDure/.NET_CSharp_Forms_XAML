using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControladorDePedidos.Model;
namespace ControladorDePedidos.Repositorio
{
   public  class ProdutosCRUD
    {

        RepositorioProduto repositorio;
         public ProdutosCRUD()
        {
            repositorio = new RepositorioProduto();
            
        }
         public List<Produto> ElemtosDoBancoDeDadosProduto()
         {
             List<Produto> produto = repositorio.Liste();
             return produto;
         }
    }
}
