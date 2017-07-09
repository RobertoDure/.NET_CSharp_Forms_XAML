using ControladorDePedidos.Model;
using ControladorDePedidos.Repositorio;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace ControladorDePedidos.WPF
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var repoUsuario = new RepositorioUsuario();
            var listaUsuarios = repoUsuario.Liste();
            if (listaUsuarios.Count == 0)
            {
                var usuario = new Usuario
                {
                    Administrador = true
                };

                this.Hide();
                var formPrincipal = new MainWindow(usuario);
                formPrincipal.ShowDialog();
                this.Close();
            }

            cmbUsuario.DataContext = listaUsuarios;
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            if (cmbUsuario.SelectedItem == null)
            {
                MessageBox.Show("Selecione o usuário");
                return;
            }

            var senha = txtSenha.Password;
            var usuario = (Usuario)cmbUsuario.SelectedItem;

            var repoUsuario = new RepositorioUsuario();

            if (repoUsuario.ValideAcesso(usuario.Codigo, senha))
            {
                var listaUsuarios = (List<Usuario>)cmbUsuario.DataContext;
                var quantidade = listaUsuarios.Where(x => x.Administrador).Count();
                if (quantidade == 0)
                {
                    MessageBox.Show("Não existe administrador cadastrado no sistema, logo o operador que está se logando terá acesso de administrador");
                    usuario.Administrador = true;
                }

                this.Hide();
                var formPrincipal = new MainWindow(usuario);
                formPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Dados incorretos!");
            }
        }
    }
}
