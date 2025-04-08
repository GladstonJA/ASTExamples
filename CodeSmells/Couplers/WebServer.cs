namespace CodeSmelss.Couplers
{
    public class WebServer
    {
        private static readonly InternalServerRequestInitializerFilter _firstFilter = new();
        private static readonly InternalResponseFormatterFilter _lastFilter = new();
        public async virtual Task<string?> ProcessHttpRequest()
        {
            CancellationToken cancellationToken = new CancellationTokenSource().Token;
            LinkedList<HttpRequestFilter> pipeLine = BuildFilterList();
            LinkedListNode<HttpRequestFilter>? httpRequestFilter = pipeLine.First;
            while (httpRequestFilter != null)
            {
                await httpRequestFilter.Value.ProcessRequest(cancellationToken);
            }
            return _lastFilter.Response;
        }

        private static LinkedList<HttpRequestFilter> BuildFilterList()
        {
            LinkedList<HttpRequestFilter> result = [];
            HttpRequestFilter lastFilter = _firstFilter;
            result.AddFirst(lastFilter);

            lastFilter = new LogHttpRequestFilter(lastFilter);
            result.AddLast(lastFilter);

            lastFilter = new UnitOfWorkHttpRequestFilter(lastFilter);
            result.AddLast(lastFilter);

            lastFilter = new ControllerDispatcherHttpRequestFilter(lastFilter);
            result.AddLast(lastFilter);

            lastFilter = _lastFilter;
            result.AddLast(lastFilter);
            return result;
        }
    }
}
