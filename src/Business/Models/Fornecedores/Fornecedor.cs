using Business.Core.Models;
using Business.Models.Produtos;
using System.Collections.Generic;

namespace Business.Models.Fornecedores
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */
        public Endereco Endereco { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}