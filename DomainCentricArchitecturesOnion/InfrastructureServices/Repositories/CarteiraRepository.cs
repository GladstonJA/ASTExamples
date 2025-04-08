﻿using DomainCentricArchitecturesOnion.DomainModels;
using DomainCentricArchitecturesOnion.DomainServices;

namespace DomainCentricArchitecturesOnion.InfrastructureServices.Repositories
{
    public class CarteiraRepository : ICarteiraRepository
    {
        private readonly IAcaoRepository _acaoRepository;

        public CarteiraRepository(IAcaoRepository acaoRepository)
        {
            _acaoRepository = acaoRepository;
        }

        public virtual Carteira ConsultarCarteira(Conta conta)
        {
            // Acessaria o banco de dados ou outra fonte de persistência

            List<Custodia> custodiaDeAcoes = [];
            for (int i = 0; i < 5; i++)
            {
                custodiaDeAcoes.Add(new()
                {
                    Id = i,
                    PrecoUnitarioDeCompra = 10.5m,
                    Quantidade = 100,
                    Acao = _acaoRepository.ConsultarAcaoById(i)
                });
            }

            return new Carteira()
            {
                Id = 1,
                Conta = conta,
                Custodia = custodiaDeAcoes.ToArray(),
            };
        }
    }
}
