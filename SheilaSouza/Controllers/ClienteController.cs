using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Entity;
using Entity.Models;
using Entity.Domain;

namespace SheilaSouza.Controllers
{
    public class ClienteController : Controller
    {
		// GET: Cliente
		public ActionResult Index() {
			var controllerApi = new ClientesController();

			return View(controllerApi.GetClientes());
		}

		// GET: Cliente/Create
		public ActionResult Create() {
			return View();
		}

		// POST: Cliente/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "Id,Nome,CPF,Email,Telefone,Sexo,DataNascimento")] Cliente cliente) {
			var controllerApi = new ClientesController();
			if (ModelState.IsValid)
			{
				controllerApi.PostCliente(cliente);
				return RedirectToAction("Index");
			}

			return View(cliente);
		}

		// GET: Cliente/Edit/5
		public ActionResult Edit(int? id) {
			var domainCliente = new DomainCliente();
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Cliente cliente = domainCliente.RetornarCliente(id.Value);
			if (cliente == null)
			{
				return HttpNotFound();
			}
			return View(cliente);
		}

		// POST: Cliente/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "Id,Nome,CPF,Email,Telefone,Sexo,DataNascimento")] Cliente cliente) {
			var controllerApi = new ClientesController();
			if (ModelState.IsValid)
			{
				controllerApi.PutCliente(cliente.Id, cliente);
				return RedirectToAction("Index");
			}
			return View(cliente);
		}

		// GET: Cliente/Delete/5
		public ActionResult Delete(int? id) {
			var domainCliente = new DomainCliente();
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Cliente cliente = domainCliente.RetornarCliente(id.Value);
			if (cliente == null)
			{
				return HttpNotFound();
			}
			return View(cliente);
		}

		// POST: Cliente/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id) {
			var controllerApi = new ClientesController();
			controllerApi.DeleteCliente(id);
			return RedirectToAction("Index");
		}

		// GET: Cliente/Details/5
		public ActionResult Details(int? id) {
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			var controllerApi = new ClientesController();
			Cliente cliente = controllerApi.GetCliente(id.Value);
			if (cliente == null)
			{
				return HttpNotFound();
			}
			return View(cliente);
		}
		
    }
}
