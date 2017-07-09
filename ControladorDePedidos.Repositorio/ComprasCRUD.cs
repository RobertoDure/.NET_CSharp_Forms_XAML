using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControladorDePedidos.Model;

namespace ControladorDePedidos.Repositorio
{
   public  class ComprasCRUD
    {
       RepositorioCompra repositorio;
       RepositorioItemDaCompra repositorio2;
       public ComprasCRUD()
        {
            repositorio = new RepositorioCompra();
            repositorio2 = new RepositorioItemDaCompra();
            
        }
         public List<Compra> ElemtosDoBancoDeDadosCliente()
         {
             List<Compra> compras = repositorio.Liste();
             return compras;
         }
         public List<ItemDaCompra> ElemtosDoBancoDeDadosCompraItem()
         {
             List<ItemDaCompra> compras = repositorio2.Liste();
             return compras;
         }
    }
}