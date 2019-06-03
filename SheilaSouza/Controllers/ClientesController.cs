using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Entity;
using Entity.Models;
using Entity.Domain;

namespace SheilaSouza.Controllers
{
	[RoutePrefix("Clientes")]
    public class ClientesController : ApiController
    {

		// GET: api/Clientes
		public List<Cliente> GetClientes() {
			var domainCliente = new DomainCliente();
			return domainCliente.RetornarClientes();
		}

		////GET: api/Clientes/id
		public Cliente GetCliente(int id) {
			var domainCliente = new DomainCliente();
			return domainCliente.RetornarCliente(id);
		}

		// PUT: api/Clientes/5
		[ResponseType(typeof(void))]
        public IHttpActionResult PutCliente(int id, Cliente cliente)
        {
			var domainCliente = new DomainCliente();
			domainCliente.AlterarCliente(cliente);

			return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Clientes
        [ResponseType(typeof(Cliente))]
        public IHttpActionResult PostCliente(Cliente cliente)
        {
			var domainCliente = new DomainCliente();
			domainCliente.AddCliente(cliente);

			return CreatedAtRoute("DefaultApi", new { id = cliente.Id }, cliente);
        }

        // DELETE: api/Clientes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult DeleteCliente(int id)
        {
			var domainCliente = new DomainCliente();
			var cliente = domainCliente.DeletarCliente(id);

			return Ok(cliente);
        }
  
    }
}