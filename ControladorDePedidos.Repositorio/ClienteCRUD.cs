using ControladorDePedidos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorDePedidos.Repositorio
{
    public class ClienteCRUD
    {
    RepositorioCliente repositorio;
    public ClienteCRUD()
        {
            repositorio = new RepositorioCliente();
            
        }
         public List<Cliente> ElemtosDoBancoDeDadosCliente()
         {
             List<Cliente> cliente = repositorio.Liste();
             return cliente;
         }
    }
}
