using ControladorDePedidos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorDePedidos.Repositorio
{
    public class RepositorioFornecedor : RepositorioGenerico<Fornecedor>
    {
        public List<Fornecedor> Buscar(string termoDaBusca)
        {
            contexto = new Contexto();
            return contexto.Set<Fornecedor>().Where(x => x.Nome.Contains(termoDaBusca)).ToList();
        }
    }
}
