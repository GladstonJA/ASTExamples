using Quartz;
using Quartz.Impl;

namespace DesignPatterns.GoF.Behavioral.Command
{
    public class JobConfig
    {
        public async Task ConfigJobs()
        {
            StdSchedulerFactory factory = new();
            IScheduler scheduler = await factory.GetScheduler();

            // define the job and tie it to our HelloJob class
            IJobDetail job = JobBuilder.Create<OpenFileJob>()
                .WithIdentity("job1", "group1")
                .Build();

            // Trigger the job to run now, and then repeat every 10 seconds
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("trigger1", "group1")
                .StartNow()
                .WithSimpleSchedule(x => x
                    .WithIntervalInSeconds(10)
                    .RepeatForever())
                .Build();

            // Tell quartz to schedule the job using our trigger
            await scheduler.ScheduleJob(job, trigger);
        }
    }
}
