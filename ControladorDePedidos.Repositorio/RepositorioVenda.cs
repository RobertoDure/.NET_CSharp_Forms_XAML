using ControladorDePedidos.Model;
using System.Data.Entity.Infrastructure;
using System.Windows;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControladorDePedidos.Repositorio
{
    public class RepositorioVenda : RepositorioGenerico<Venda>
    {

        public List<Venda> Buscar(string termoDaBusca)
        {
            contexto = new Contexto();
            return contexto.Set<Venda>().Where(x => x.Cliente.Nome.Contains(termoDaBusca)).ToList();
        }
        public override void Adicione(Venda item)
        {
            if (item.Cliente != null)
            {
                item.Cliente = contexto.Set<Cliente>().Find(item.Cliente.Codigo);
            }

            base.Adicione(item);
        }

        public override void Atualize(Venda item)
        {
            var original = contexto.Set<Venda>().Find(item.Codigo);
            contexto.Entry(original).CurrentValues.SetValues(item);

            if (item.Cliente != null)
            {
                original.Cliente = contexto.Set<Cliente>().Find(item.Cliente.Codigo);
                contexto.Cliente.Attach(original.Cliente);
            }

            contexto.SaveChanges();
        }

        public override void Excluir(Venda item)
        {
            try
            {
                contexto.Set<ItemDaVenda>().RemoveRange(item.ItensDaVenda);
                var original = contexto.Set<Venda>().Find(item.Codigo);
                contexto.Set<Venda>().Remove(original);
                contexto.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Não é possível ecluir esse elemento, pois ele possui itens associados.");
            }
        }
   
    }
}
