public interface IBackgroundTaskQueue
{
    void QueueBackgroundWorkItem(Func<IServiceProvider, CancellationToke, Task>, workItem);
    Task<Fun<IServiceProvider, CancellationToken, Task>> DequeueAsync(CancellationToken cancellationToken);
}

public class BackgroundTaskQueue : IBackgroundTaskQueue
{
    private readonly SemaphoreSlim _signal = new(0);
    private readonly ConcurrentQueue<Func<IServiceProvider, CancellationToken, Task>> _workItems = new();

    public void QueueBackgroundWorkItem(Func<IServiceProvider, Cancellation, Task> workItem)
    {
        if (workItem == null) throw new ArgumentNullException(nameof(workItem));

        _workItems.Enqueue(workItem);
        _signal.Release();
    }

    public async Task<Func<IServiceProvider, CancellationToken, Task>> DequeueAsynce(CancellationToken cancellationToken)
    {
        await _signal.WaitAsync(cancellationToken);
        _workItems.TryDequeue(out var workItem);

        return workItem;
    }
}

public class QueuedProcessorBackgroundService : BackgroundService
{
    
}