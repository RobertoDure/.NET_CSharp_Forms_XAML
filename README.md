# ControladorDePedidos

## Project Description

ControladorDePedidos is a .NET Framework 4.5 project that provides a system for managing orders, clients, products, sales, and purchases. The project is divided into three main components:

- **ControladorDePedidos.Model**: Contains the data models and business logic.
- **ControladorDePedidos.Repositorio**: Handles data access using Entity Framework.
- **ControladorDePedidos.WPF**: Provides a WPF-based user interface for interacting with the system.

## Main Features

- Manage clients, products, sales, and purchases.
- Track inventory levels and update stock quantities.
- Generate reports for sales, purchases, and inventory.
- User authentication and authorization.

## Setup Instructions

1. Clone the repository:
   ```sh
   git clone https://github.com/RobertoDure/.NET_CSharp_Forms_XAML.git
   cd .NET_CSharp_Forms_XAML
   ```

2. Open the solution file `Order_tracking.sln` in Visual Studio.

3. Restore NuGet packages:
   ```sh
   nuget restore
   ```

4. Build the solution in Visual Studio.

5. Update the database:
   - Open the Package Manager Console in Visual Studio.
   - Run the following command to apply migrations and update the database:
     ```sh
     Update-Database
     ```

6. Run the project:
   - Set `ControladorDePedidos.WPF` as the startup project.
   - Press `F5` to start debugging.

## Project Structure

- **ControladorDePedidos.Model**
  - `ClasseBase.cs`: Base class for all data models.
  - `Cliente.cs`: Represents a client.
  - `Compra.cs`: Represents a purchase.
  - `eStatusDaCompra.cs`: Enum for purchase status.
  - `eStatusDaVenda.cs`: Enum for sale status.
  - `Fornecedor.cs`: Represents a supplier.
  - `ItemDaCompra.cs`: Represents an item in a purchase.
  - `ItemDaVenda.cs`: Represents an item in a sale.
  - `Marca.cs`: Represents a brand.
  - `Produto.cs`: Represents a product.
  - `Usuario.cs`: Represents a user.
  - `Venda.cs`: Represents a sale.

- **ControladorDePedidos.Repositorio**
  - `App.config`: Configuration file for Entity Framework.
  - `ClienteCRUD.cs`: CRUD operations for clients.
  - `ComprasCRUD.cs`: CRUD operations for purchases.
  - `Contexto.cs`: Entity Framework DbContext.
  - `Migrations`: Folder containing Entity Framework migrations.
  - `ProdutosCRUD.cs`: CRUD operations for products.
  - `RepositorioCliente.cs`: Repository for clients.
  - `RepositorioCompra.cs`: Repository for purchases.
  - `RepositorioFornecedor.cs`: Repository for suppliers.
  - `RepositorioGenerico.cs`: Generic repository.
  - `RepositorioItemDaCompra.cs`: Repository for purchase items.
  - `RepositorioItemDaVenda.cs`: Repository for sale items.
  - `RepositorioMarca.cs`: Repository for brands.
  - `RepositorioProduto.cs`: Repository for products.
  - `RepositorioUsuario.cs`: Repository for users.
  - `RepositorioVenda.cs`: Repository for sales.
  - `VendasCRUD.cs`: CRUD operations for sales.

- **ControladorDePedidos.WPF**
  - `App.config`: Configuration file for Entity Framework.
  - `App.xaml`: Application definition.
  - `App.xaml.cs`: Application logic.
  - `FormBuscaCliente.xaml`: XAML file for client search form.
  - `FormBuscaCliente.xaml.cs`: Code-behind for client search form.
  - `FormBuscaDeCliente.xaml`: XAML file for client search form.
  - `FormBuscaDeCliente.xaml.cs`: Code-behind for client search form.
  - `FormBuscaDeFornecedor.xaml`: XAML file for supplier search form.
  - `FormBuscaDeFornecedor.xaml.cs`: Code-behind for supplier search form.
  - `FormBuscaDeProduto.xaml`: XAML file for product search form.
  - `FormBuscaDeProduto.xaml.cs`: Code-behind for product search form.
  - `FormBuscaDeVendas.xaml`: XAML file for sales search form.
  - `FormBuscaDeVendas.xaml.cs`: Code-behind for sales search form.
  - `FormCadastroDeCliente.xaml`: XAML file for client registration form.
  - `FormCadastroDeCliente.xaml.cs`: Code-behind for client registration form.
  - `FormCadastroDeCompra.xaml`: XAML file for purchase registration form.
  - `FormCadastroDeCompra.xaml.cs`: Code-behind for purchase registration form.
  - `FormCadastroDeFornecedor.xaml`: XAML file for supplier registration form.
  - `FormCadastroDeFornecedor.xaml.cs`: Code-behind for supplier registration form.
  - `FormCadastroDeMarca.xaml`: XAML file for brand registration form.
  - `FormCadastroDeMarca.xaml.cs`: Code-behind for brand registration form.
  - `FormCadastroDeProduto.xaml`: XAML file for product registration form.
  - `FormCadastroDeProduto.xaml.cs`: Code-behind for product registration form.
  - `FormCadastroDeUsuario.xaml`: XAML file for user registration form.
  - `FormCadastroDeUsuario.xaml.cs`: Code-behind for user registration form.
  - `FormCadastroDeVenda.xaml`: XAML file for sales registration form.
  - `FormCadastroDeVenda.xaml.cs`: Code-behind for sales registration form.
  - `FormClientes.xaml`: XAML file for client management form.
  - `FormClientes.xaml.cs`: Code-behind for client management form.
  - `FormCompras.xaml`: XAML file for purchase management form.
  - `FormCompras.xaml.cs`: Code-behind for purchase management form.
  - `FormFornecedores.xaml`: XAML file for supplier management form.
  - `FormFornecedores.xaml.cs`: Code-behind for supplier management form.
  - `FormMarcas.xaml`: XAML file for brand management form.
  - `FormMarcas.xaml.cs`: Code-behind for brand management form.
  - `FormProdutos.xaml`: XAML file for product management form.
  - `FormProdutos.xaml.cs`: Code-behind for product management form.
  - `FormUsuarios.xaml`: XAML file for user management form.
  - `FormUsuarios.xaml.cs`: Code-behind for user management form.
  - `FormVendas.xaml`: XAML file for sales management form.
  - `FormVendas.xaml.cs`: Code-behind for sales management form.
  - `Login.xaml`: XAML file for login form.
  - `Login.xaml.cs`: Code-behind for login form.
  - `MenuPrincipal.xaml`: XAML file for main menu.
  - `MenuPrincipal.xaml.cs`: Code-behind for main menu.
  - `RelatorioVendas.xaml`: XAML file for sales report form.
  - `RelatorioVendas.xaml.cs`: Code-behind for sales report form.
  - `Utilitarios.cs`: Utility functions.
