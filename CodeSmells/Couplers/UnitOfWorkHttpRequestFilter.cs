namespace CodeSmelss.Couplers
{
    public class UnitOfWorkHttpRequestFilter : HttpRequestFilter
    {
        public UnitOfWorkHttpRequestFilter(HttpRequestFilter nextFiler) : base(nextFiler)
        {
        }

        protected async override Task HandleFilter(CancellationToken cancellationToken,
            Func<CancellationToken, Task> next)
        {
            // Inicializa a unit of work

            try
            {
                await next(cancellationToken);

                // Commit da unit of work
            }
            catch
            {
                // Rollback da unit of work
            }
        }
    }
}
