using Quartz;
using Quartz.Impl;
using QuartzNetDST;

Console.WriteLine("App started!");

ISchedulerFactory schedulerFactory = new StdSchedulerFactory();

IScheduler scheduler = await schedulerFactory.GetScheduler();
await scheduler.Start();

IJobDetail job = JobBuilder.Create<SimpleJob>()
        .WithIdentity("job1", "group1")
        .Build();

var timeProvider = new TestTimeProvider(DateTimeOffset.UtcNow);

ITrigger trigger = TriggerBuilder.Create(timeProvider)
    .WithIdentity("trigger1", "group1")
    .WithCronSchedule("0 0/1 2 ? * * *", x => x.InTimeZone(TimeZoneInfo.Local))
    .StartNow()
    .Build();

await scheduler.ScheduleJob(job, trigger);

Console.WriteLine("Press any key followed by enter to quit.");
Console.ReadLine();