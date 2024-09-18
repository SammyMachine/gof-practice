namespace GOF.strategy.study
{
    internal class Navigator
    {
        private RouteStrategy routeStrategy;

        public Navigator(RouteStrategy routeStrategy)
        {
            this.routeStrategy = routeStrategy;
        }

        public void SetStrategy(RouteStrategy routeStrategy)
        {
            this.routeStrategy = routeStrategy;
        }

        public void BuildRoute(string start, string end)
        {
            routeStrategy.BuildRoute(start, end);
        }
    }
}