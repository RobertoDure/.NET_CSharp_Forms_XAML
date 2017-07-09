using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControladorDePedidos.Repositorio;
using System.Threading.Tasks;
using ControladorDePedidos.Model;

namespace ControladorDePedidos.Repositorio
{
    public class VendasCRUD
    {
        RepositorioVenda repositorio;
         public VendasCRUD()
        {
            repositorio = new RepositorioVenda();
            
        }
         public List<Venda> ElemtosDoBancoDeDadosVenda()
         {
             List<Venda> vendas = repositorio.Liste();
             return vendas;
         }
    }
}
