using Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repository {
	public class RepositoryCliente {
		public void SalvarCliente(Cliente cliente) {
			var contexto = new Contexto();
			contexto.Cliente.Add(cliente);
			contexto.SaveChanges();
		}

		public void AlterarCliente(Cliente cliente) {
			var contexto = new Contexto();
			var clienteBd = contexto.Cliente.FirstOrDefault(x => x.Id == cliente.Id);
			clienteBd.Nome = cliente.Nome;
			clienteBd.Email = cliente.Email;
			clienteBd.Sexo = cliente.Sexo;
			clienteBd.Telefone = cliente.Telefone;
			clienteBd.CPF = cliente.CPF;
			clienteBd.DataNascimento = cliente.DataNascimento;

			contexto.SaveChanges();

		}

		public Cliente DeletarCliente(int id) {
			
			using (var contexto = new Contexto())
			{
				var cliente = contexto.Cliente.Where(x => x.Id == id).FirstOrDefault();
				contexto.Cliente.Remove(cliente);
				contexto.SaveChanges();
				return cliente;
			}
			
		}

		public Cliente RetornarCliente(int id) {
			var contexto = new Contexto();
			return contexto.Cliente.FirstOrDefault(x => x.Id == id);
		}

		public List<Cliente> BuscarCliente(string busca) {
			var contexto = new Contexto();
			return contexto.Cliente.Where(x => x.Nome.Contains(busca) || x.Email.Contains(busca)).ToList();
		}

		public List<Cliente> RetornarClientes() {
			var contexto = new Contexto();
			return contexto.Cliente.ToList();
		}
	}
}
