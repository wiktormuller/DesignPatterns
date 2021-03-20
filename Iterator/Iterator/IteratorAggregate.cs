using System.Collections;

namespace Iterator
{
    public abstract class IteratorAggregate : IEnumerable
    {
        //Returns an Iterator or other IteratorAggregate for the implementing object.
        public abstract IEnumerator GetEnumerator();
    }
}