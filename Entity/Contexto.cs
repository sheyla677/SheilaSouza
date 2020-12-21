using Entity.Migrations;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity {
  public class Contexto : DbContext {

    public DbSet<Cliente> Cliente { get; set; }
    public Contexto() {
			Database.SetInitializer(new MigrateDatabaseToLatestVersion<Contexto, Configuration>());
		}
	}
}
