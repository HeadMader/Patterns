using Patterns.Builder;
using Patterns.Strategy;

namespace Patterns
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ClientBuilder.TestBuilder();
			TestStrategy.Test();
		}
	}
}