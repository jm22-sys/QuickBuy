using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidade;
using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Repositorios.Contexto
{
    public class QuickBuyContexto : DbContext
    {
        

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Pedido> pedidos  { get; set; }
        public DbSet<ItemPedido> itemPedidos { get; set; }
        public DbSet<FormaPagmento> FormaPagmentos { get; set; }

        public QuickBuyContexto(DbContextOptions options) : base(options)
        {

        }


    }
}
