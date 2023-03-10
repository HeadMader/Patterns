namespace Patterns.Strategy
{
    class Worker
    {
        public void DoWork(IWork work)
        {
            if (work != null)
            {
                work.Work();
            }
        }
    }
}
