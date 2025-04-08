using static Quartz.Logging.OperationName;

namespace DesignPatterns.GoF.Structural.Decorator.Decorators
{
    public class JobWithEmailAlert : JobDecorator
    {
        public JobWithEmailAlert(Job job) : base(job) { }

        public override void Execute()
        {
            Job.Execute();

            // Envia email
        }
    }
}
