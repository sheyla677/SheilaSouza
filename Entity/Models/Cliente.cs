using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models {
	public class Cliente {
		public int Id { get; set; }
		public string Nome { get; set; }
		public string CPF { get; set; }
		public string Email { get; set; }
		public int Telefone { get; set; }
		public string Sexo { get; set; }
		public DateTime DataNascimento { get; set; }

	}
}
