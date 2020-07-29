using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidade
{
    public  class Pedido : Entidade
    {
        public int id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string  CEP { get; set; }
        public String Cidade { get; set; }
        public string EndCompleto { get; set; }
        public int NumeroEnd { get; set; }

        public int FormapagmentoID { get; set; }
        public FormaPagmento FormaPAgmento { get; set; }


        /// <summary>
        /// deve ter  pelo menos 1 item de pedido
        /// ou muitos itenas de pedidos   
        /// </summary>
        ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparmensagemDeValidaçao();


            if (!ItensPedido.Any())
            AdicionarCritica("Campo iten nao pode ficar vazio!. escolha um produto.");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Campo CEP esta vazio!.");


        }
    }
}
