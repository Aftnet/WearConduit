using System;
using Xunit;

namespace WearConduit.Shared.Test
{
    public abstract class TestBase<T>
    {
        protected internal abstract T InstantiateTarget();

        private readonly Lazy<T> target;
        protected T Target => target.Value;

        protected TestBase()
        {
            target = new Lazy<T>(InstantiateTarget, System.Threading.LazyThreadSafetyMode.PublicationOnly);
        }
    }
}
