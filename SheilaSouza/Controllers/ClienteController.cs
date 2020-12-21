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
			var domainCliente = new DomainCliente();

			return View(domainCliente.RetornarClientes());
		}

		public ActionResult Create() {
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create( Cliente cliente) {
			var domainCliente = new DomainCliente();
			if (ModelState.IsValid)
			{
        domainCliente.AddCliente(cliente);
        ViewBag.Message = "success";
			}
			else
			{
        ViewBag.Message = "failure";
      }
     
			return View(cliente);
		}
		
    }
}
