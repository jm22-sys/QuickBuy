using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidade
{
    public abstract class Entidade
    {
        public List<string>  _mensagemValidaçao { get;set }
        public List<string> MensagemValidacao
        {
            get { return _mensagemValidaçao ?? (_mensagemValidaçao = new List<string>());  }
        }
        public abstract void Validate()
            protected bool EhValido
        {
            get { return (MensagemValidacao.Any(); }
        }
    }
}
