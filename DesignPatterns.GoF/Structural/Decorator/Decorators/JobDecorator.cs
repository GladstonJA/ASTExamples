namespace DesignPatterns.GoF.Structural.Decorator.Decorators
{
    public abstract class JobDecorator : Job
    {
        protected Job Job { get; set; }

        public JobDecorator(Job job)
        {
            Job = job;
        }
    }
}
