using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entity
{
    public class Cliente
    {

        #region Atributos

        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        #endregion
        #region Construtores

        public Cliente()
        {

        }

        public Cliente(int IdCliente, string Nome, string Email)
        {
            this.IdCliente = IdCliente;
            this.Nome = Nome;
            this.Email = Email;
        }

        #endregion

        #region Sobrescritas

        public override string ToString()
        {
            return this.IdCliente + ", " + this.Nome + ", " + this.Email;
        }

        #endregion




    }
}
