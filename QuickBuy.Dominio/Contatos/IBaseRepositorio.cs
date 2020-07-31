using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Contatos
{
    public interface IBaseRepositorio<TEntity>: IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        TEntity oberterPorId(int id);
        IEnumerable<TEntity> OBterTdos();
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);
    }
}
