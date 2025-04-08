using Quartz;

namespace DesignPatterns.GoF.Behavioral.Command
{
    public class OpenFileJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            await Task.CompletedTask;
        }
    }
}
