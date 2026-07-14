using Xunit;

public class TaskManagerTests
{
    [Fact]
    public void PendingTasks_ShouldBeCorrect()
    {
        var manager = new TaskManager();
        Assert.Equal(2, manager.GetPendingTaskCount());
    }

    [Fact]
    public void CompletedTasks_ShouldBeCorrect()
    {
        var manager = new TaskManager();
        Assert.Equal(1, manager.GetCompletedTaskCount());
    }
}