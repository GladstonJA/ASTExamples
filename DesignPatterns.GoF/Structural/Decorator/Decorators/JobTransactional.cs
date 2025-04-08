using static Quartz.Logging.OperationName;

namespace DesignPatterns.GoF.Structural.Decorator.Decorators
{
    public class JobTransactional : JobDecorator
    {
        public JobTransactional(Job job) : base(job) { }

        public override void Execute()
        {
            // Cria transacao

            Job.Execute();
        }
    }
}
