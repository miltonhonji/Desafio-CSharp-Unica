using System;
using System.Collections.Generic;
using System.Text;
using treinamento_poo.Model;

namespace treinamento_poo.Service
{
    public interface IContaInvestimentoService : IBaseService<ContaInvestimento>
    {
        void Investir(int id);
        void Resgatar(int id);
    }
}
