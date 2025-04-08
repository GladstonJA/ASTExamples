namespace CodeSmelss.Couplers
{
    public class LogHttpRequestFilter : HttpRequestFilter
    {
        public LogHttpRequestFilter(HttpRequestFilter nextFiler) : base(nextFiler)
        {
        }

        protected async override Task HandleFilter(CancellationToken cancellationToken,
            Func<CancellationToken, Task> next)
        {
            //Implementa o log

            await next(cancellationToken);
        }
    }
}
