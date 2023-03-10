namespace Patterns.Strategy
{
    class SecondWorker
    {
        private IWork work;

        public SecondWorker(IWork work)
        {
            this.work = work;
        }

        public void DoWork()
        {
            if (work != null)
            {
                work.Work();
            }
        }
    }
}
