using System;
using System.Collections.Generic;
using System.Text;
using treinamento_poo.Model;

namespace treinamento_poo.Service
{
    public interface IContaCorrenteService : IBaseService<ContaCorrente>
    {
        void FazerEmprestimo(int id);
    }
}
