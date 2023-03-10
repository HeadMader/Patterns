namespace Patterns.Strategy
{
    class EasyWork : IWork
    {
		/// <summary>
		/// Do some work
		/// </summary>
		public void Work()
        {
            Console.WriteLine("Easy work");
        }
    }
}
