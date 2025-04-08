using DesignPatterns.GoF.Structural.Decorator.Decorators;
using DesignPatterns.GoF.Structural.Decorator.Jobs;

namespace DesignPatterns.GoF.Structural.Decorator
{
    public class JobDispatcher
    {
        public void RunOnSchedule()
        {
            var jobs = GetJobsToRun();
            foreach (var job in jobs)
                job.Execute();
        }

        protected virtual List<Job> GetJobsToRun()
        {
            var result = new List<Job>();

            // Comportamentos vindo de um XML de configuracao ou banco de dados por exemplo.
            GerarRelatorioDeVendasJob jobGerarRelatorioDeVendas = new();
            JobWithEmailAlert decoratorGerarRelatorioDeVendas = new(jobGerarRelatorioDeVendas);
            result.Add(decoratorGerarRelatorioDeVendas);

            ExecutarConciliacaoDeBoletosJob jobConciliacao = new();
            JobWithEmailAlert decoratorTransacaoDaConciliacao = new(jobConciliacao);
            JobWIthLogging decoratorLogging = new(decoratorTransacaoDaConciliacao);
            result.Add(decoratorLogging);

            return result;
        }

    }
}
