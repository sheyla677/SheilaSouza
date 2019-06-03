using Entity.Models;
using Entity.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Domain {

	public class DomainCliente {

		public List<Cliente> RetornarClientes() {
			var repositoryCliente = new RepositoryCliente();
			return repositoryCliente.RetornarClientes();
		}

		public List<Cliente> BuscarCliente(string busca) {
			var repositoryCliente = new RepositoryCliente();
			return repositoryCliente.BuscarCliente(busca);
		}

		public Cliente RetornarCliente(int id) {
			var repositoryCliente = new RepositoryCliente();
			return repositoryCliente.RetornarCliente(id);
		}

		public void AddCliente(Cliente cliente) {
			var repositoryCliente = new RepositoryCliente();
			repositoryCliente.SalvarCliente(cliente);
		}

		public void AlterarCliente(Cliente cliente) {
			var repositoryCliente = new RepositoryCliente();
			repositoryCliente.AlterarCliente(cliente);
		}

		public Cliente DeletarCliente(int id) {
			var repositoryCliente = new RepositoryCliente();
			return repositoryCliente.DeletarCliente(id);
		}

	}
}
