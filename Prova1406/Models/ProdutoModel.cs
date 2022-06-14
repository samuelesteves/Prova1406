using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prova1406.Models
{
    public class ProdutoModel
    {
        [Key]
        public long ProdutoId { get; set; }

        public String Nome { get; set; }

        public String Descricao { get; set; }

        public FornecedorModel Fornecedor { get; set; }

        public int? FornecedorId { get; set; }

    }
}