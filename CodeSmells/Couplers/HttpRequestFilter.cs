namespace CodeSmelss.Couplers
{
    public abstract class HttpRequestFilter
    {
        private protected HttpRequestFilter()
        {

        }

        protected HttpRequestFilter(HttpRequestFilter nextFiler)
        {
            NextFiler = nextFiler;
        }

        protected HttpRequestFilter? NextFiler { get; private set; }

        public virtual async Task ProcessRequest(CancellationToken cancellationToken)
        {
            await HandleFilter(cancellationToken, NextFiler!.ProcessRequest);
        }

        protected abstract Task HandleFilter(CancellationToken cancellationToken,
            Func<CancellationToken, Task> next);
    }
}
