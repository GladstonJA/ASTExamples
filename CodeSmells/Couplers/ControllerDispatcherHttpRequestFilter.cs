namespace CodeSmelss.Couplers
{
    public class ControllerDispatcherHttpRequestFilter : HttpRequestFilter
    {
        public ControllerDispatcherHttpRequestFilter(HttpRequestFilter nextFiler) : base(nextFiler)
        {
        }

        protected async override Task HandleFilter(CancellationToken cancellationToken,
            Func<CancellationToken, Task> next)
        {
            // Aciona a regra de negócio

            await next(cancellationToken);
        }
    }
}
