using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models {
	public class Cliente {
		public int Id { get; set; }
		public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string CPF { get; set; }
    public DateTime DataNascimento { get; set; }
    public string CEP { get; set; }
    public string Logradouro { get; set; }
    public int Numero { get; set; }
    public string Complemento { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }

  }
}
