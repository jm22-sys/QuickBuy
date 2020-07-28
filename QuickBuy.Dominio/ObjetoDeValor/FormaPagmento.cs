using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagmento
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string  Descricao { get; set; }

        public bool Ehboleto
        {
            get { return id == (int)TipoFormaPagmentoEnum.Boleto; }

        }

        public bool EhCartaoDeCredito
        {
            get { return id == (int)TipoFormaPagmentoEnum.CartaoCredito; }

        }

        public bool EhDeposito
        {
            get { return id == (int)TipoFormaPagmentoEnum.Deposito; }
        }
        public bool naodefinido
        {
            get { return id == (int)TipoFormaPagmentoEnum.NaoDefinido; }

        }




    }
}
