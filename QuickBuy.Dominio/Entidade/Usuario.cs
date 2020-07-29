using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidade
{
    public abstract class Usuario : Entidade
    {
        public int id { get; set; }
        public int Email { get; set; }
        public int Senha { get; set; }
        public string nome { get; set; }
        public string Sobrenome { get; set; }

        /// <summary>
        /// um usuario pode ter um ou mais pedidos
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

    }
}
