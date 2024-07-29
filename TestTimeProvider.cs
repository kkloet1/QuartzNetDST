namespace QuartzNetDST;

public class TestTimeProvider : TimeProvider
{
    private readonly DateTimeOffset utcNow;

    public TestTimeProvider(DateTimeOffset utcNow)
    {
        this.utcNow = utcNow;
    }

    public override DateTimeOffset GetUtcNow() => utcNow;
}