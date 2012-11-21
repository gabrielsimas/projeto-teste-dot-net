using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL06.Entity
{
    public class Fornecedor
    {
        #region Propriedades

        public int IdFornecedor { get; set; }
        public String Nome { get; set; }
      
        #endregion

        #region Construtores

        public Fornecedor()
        {

        }

        public Fornecedor(int IdFornecedor, String Nome, List<Produto> Produto)
        {
            this.IdFornecedor = IdFornecedor;
            this.Nome = Nome;
            this.Produto = Produto;
        }

        #endregion

        #region Propriedades de Navegação

        public List<Produto> Produto { get; set; }

        #endregion

        #region Sobrescritas
        public override string ToString()
        {
            return IdFornecedor + ", " + Nome + ", " + Produto;
        }
        #endregion
    }
}
