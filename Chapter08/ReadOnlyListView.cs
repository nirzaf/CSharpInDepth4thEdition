using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Chapter08
{
    [Description("Listing 8.17")]
    public sealed class ReadOnlyListView<T> : IReadOnlyList<T>
    {
        private readonly IList<T> list;

        public ReadOnlyListView(IList<T> list)
        {
            this.list = list;
        }

        public T this[int index] => list[index];
        public int Count => list.Count;
        public IEnumerator<T> GetEnumerator() => list.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
