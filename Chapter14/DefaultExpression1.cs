using System.Threading;
using System.Threading.Tasks;

namespace Chapter14
{
    class DefaultExpression1
    {
        public async Task<string> FetchValueAsync(string key, CancellationToken cancellationToken = default)
        {
            await Task.Delay(1000, cancellationToken);
            return "irrelevant";
        }
    }
}
