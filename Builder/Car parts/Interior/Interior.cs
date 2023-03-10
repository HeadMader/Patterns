namespace Patterns.Builder
{
	public class Interior : IInterior
	{
		public string Name { get; set; }

		internal Interior(string name)
		{
			Name = name;
		}	
	}
}
