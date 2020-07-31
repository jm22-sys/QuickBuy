using QuickBuy.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Repositorios
{
    public class Cliente
    {
        public Cliente()
        {
            var UsuarioRepositorio = new UsuarioRepositorio();
            var produto = new Produto();
            var Usuario = new Usuario();
            UsuarioRepositorio.Adicionar(Usuario);
        }

        
        
    }
}
