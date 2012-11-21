using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL06.Entity
{
    public class Produto
    {

        #region Propriedades

        public int IdProduto { get; set; }
        public String Nome { get; set; }
        public double Preco { get; set; }
        public DateTime DataHoraCad { get; set; }
        public int IdFornecedor { get; set; }

        #endregion

        #region Construtores

        public Produto()
        {

        }

        public Produto(int IdProduto, String Nome, DateTime DataHpraCad, int IdFornecedor, Fornecedor Fornecedor)
        {
            this.IdProduto = IdProduto;
            this.Nome = Nome;
            this.DataHoraCad = DataHoraCad;
            this.IdFornecedor = IdFornecedor;
            this.Fornecedor = Fornecedor;
        }

        #endregion

        #region Propriedades de Navegação

        public Fornecedor Fornecedor { get; set; }

        #endregion

        #region Sobrescrita
        public override string ToString()
        {
            return IdProduto + ", " + Nome + ", " + DataHoraCad + ", " + IdFornecedor + ", " + Fornecedor;
        }
        #endregion

    }
}
