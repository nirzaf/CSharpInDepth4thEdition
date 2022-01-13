The code in this solution has been updated to work with
Visual Studio 2019 preview 2. Note that the members of
`IAsyncEnumerator<T>` have changed since chapter 15 was written; it
now looks like this:

```csharp
public interface IAsyncEnumerator<out T> : IAsyncDisposable
{
    T Current { get; }
    ValueTask<bool> MoveNextAsync();
}
```

Likewise `IAsyncDisposable.DisposeAsync` now returns `ValueTask`
rather than `Task`.

I won't update this code with *all* C# 8 features - only those
described in C# in Depth. For a more comprehensive set of demos -
but ones which are geared towards live presentation as part of a
conference talk - see https://github.com/jskeet/democode
