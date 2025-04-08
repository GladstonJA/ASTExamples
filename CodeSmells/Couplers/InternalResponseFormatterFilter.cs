namespace CodeSmelss.Couplers
{
    public class InternalResponseFormatterFilter : HttpRequestFilter
    {
        public InternalResponseFormatterFilter() : base()
        {
        }

        public virtual string? Response { get; private set; }

        public override async Task ProcessRequest(CancellationToken cancellationToken)
        {
            // Formata a resposta do processamento funcional
            Response = "Response formatada do processamento da requisição";

            await Task.CompletedTask;
        }

        protected async override Task HandleFilter(CancellationToken cancellationToken,
            Func<CancellationToken, Task> next)
        {
            await Task.CompletedTask;
        }
    }
}
