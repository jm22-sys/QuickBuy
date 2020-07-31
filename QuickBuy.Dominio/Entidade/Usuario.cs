using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidade
{
    public  class Usuario : Entidade
    {
        public int id { get; set; }
        public string Email { get; set; }
        public int Senha { get; set; }
        public string nome { get; set; }
        public string Sobrenome { get; set; }

        /// <summary>
        /// um usuario pode ter um ou mais pedidos
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Insirir Email valido!.");
            if (string.IsNullOrEmpty(Convert.ToString(Senha)))
                AdicionarCritica("Insirir uma senha valida!.");

        }
    }
}
