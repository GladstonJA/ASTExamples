
namespace CodeSmelss.Couplers
{
    internal class InternalServerRequestInitializerFilter : HttpRequestFilter
    {
        internal InternalServerRequestInitializerFilter() : base()
        {
        }

        protected override async Task HandleFilter(CancellationToken cancellationToken, Func<CancellationToken, Task> next)
        {
            // Processa as informações necessárias para o processamento da requisição

            await next(cancellationToken);
        }
    }
}
