using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prova1406.Models
{
    public class FornecedorModel
    {
        [Key]
        public long FornecedorId { get; set; }

        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "E-mail Inválido")]
        public String Email { get; set; }

        public String Logradouro { get; set; }

        public string Numero { get; set; }

        public String Complemento { get; set; }

        public String Bairro { get; set; }

        public String Cidade { get; set; }

        public ICollection<ProdutoModel> Produto { set; get; }
    }
}