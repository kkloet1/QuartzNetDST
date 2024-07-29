using Quartz;

namespace QuartzNetDST;

[DisallowConcurrentExecution]
internal class SimpleJob : IJob
{
    public ValueTask Execute(IJobExecutionContext context)
    {
        Console.WriteLine("---------");
        Console.WriteLine($"Recovering {context.Recovering}; FireInstanceId {context.FireInstanceId}; FireTimeUtc {context.FireTimeUtc}; NextFireTimeUtc {context.NextFireTimeUtc}; PreviousFireTimeUtc {context.PreviousFireTimeUtc}; RefireCount {context.RefireCount}; ScheduledFireTimeUtc {context.ScheduledFireTimeUtc};");
        return ValueTask.CompletedTask;
    }
}