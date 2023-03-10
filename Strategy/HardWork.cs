namespace Patterns.Strategy
{
    class HardWork : IWork
    {
        /// <summary>
        /// Do some work
        /// </summary>
        public void Work()
        {
            Console.WriteLine("Hard work");
        }
    }
}
