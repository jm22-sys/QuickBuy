﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidade
{
    public class ItemPedido
    {
        public int id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

    }
}
