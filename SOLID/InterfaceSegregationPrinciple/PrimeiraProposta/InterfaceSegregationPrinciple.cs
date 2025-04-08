using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID.InterfaceSegregationPrinciple.PrimeiraProposta
{
    public interface ICliente
    {
        void atualizarCadastro();

        void fecharFatura();
    }

    public class OnboardingWorkflow
    {
        public void DoSomething(ICliente cliente) {
            cliente.atualizarCadastro();
            cliente.fecharFatura();
        }
    }

    public class AtendimentoACliente
    {
        public void DoSomething(ICliente cliente)
        {
            cliente.fecharFatura();
        }
    }
}
