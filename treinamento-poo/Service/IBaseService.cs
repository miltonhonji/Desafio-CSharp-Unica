using System;
using System.Collections.Generic;
using System.Text;

namespace treinamento_poo.Service
{
    public interface IBaseService <TEntity>
    {
        void Depositar(TEntity entity);
        void Sacar(int id);
        void Transferir(int id);
        List<TEntity> Extrato();
    }
}
