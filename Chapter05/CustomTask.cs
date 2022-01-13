using System;
using System.Runtime.CompilerServices;

// Listing 5.10

[AsyncMethodBuilder(typeof(CustomTaskBuilder<>))]
public class CustomTask<T>
{
    public CustomTaskAwaiter<T> GetAwaiter() { throw new NotImplementedException(); }
}

public class CustomTaskAwaiter<T> : INotifyCompletion
{
    public bool IsCompleted { get; }
    public T GetResult() { throw new NotImplementedException(); }
    public void OnCompleted(Action continuation) { throw new NotImplementedException(); }
}

public class CustomTaskBuilder<T>
{
    public static CustomTaskBuilder<T> Create() { throw new NotImplementedException(); }

    public void Start<TStateMachine>(ref TStateMachine stateMachine)
        where TStateMachine : IAsyncStateMachine
    {
        throw new NotImplementedException();
    }

    public void SetStateMachine(IAsyncStateMachine stateMachine) { throw new NotImplementedException(); }
    public void SetException(Exception exception) { throw new NotImplementedException(); }
    public void SetResult(T result) { throw new NotImplementedException(); }

    public void AwaitOnCompleted<TAwaiter, TStateMachine>
        (ref TAwaiter awaiter, ref TStateMachine stateMachine)
        where TAwaiter : INotifyCompletion
        where TStateMachine : IAsyncStateMachine
    {
        throw new NotImplementedException();
    }

    public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>
        (ref TAwaiter awaiter, ref TStateMachine stateMachine)
        where TAwaiter : INotifyCompletion
        where TStateMachine : IAsyncStateMachine
    {
        throw new NotImplementedException();
    }

    public CustomTask<T> Task { get; }
}
