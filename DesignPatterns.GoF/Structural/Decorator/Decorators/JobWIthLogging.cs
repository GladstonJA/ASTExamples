using static Quartz.Logging.OperationName;

namespace DesignPatterns.GoF.Structural.Decorator.Decorators
{
    public class JobWIthLogging : JobDecorator
    {
        public JobWIthLogging(Job job) : base(job) { }

        public override void Execute()
        {
            // Registra log de inicio

            Job.Execute();

            // Loga log de termino
        }
    }
}
