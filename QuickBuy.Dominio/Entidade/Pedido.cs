using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidade
{
    public abstract class Pedido : Entidade
    {
        public int id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string  CEP { get; set; }
        public String Cidade { get; set; }
        public string Cidade { get; set; }
        public string EndCompleto { get; set; }
        public int NumeroEnd { get; set; }

        public int FormapagmentoID { get;set }
        public FormaPagmento FormaPAgmento { get; set}


        /// <summary>
        /// deve ter  pelo menos 1 item de pedido
        /// ou muitos itenas de pedidos   
        /// </summary>
        ICollection<ItemPedido> ItensPedido { get; set}
    }
}
