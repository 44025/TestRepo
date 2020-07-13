using System;

namespace GitTest
{
	public class Unit
	{
		private string _name; public string name { get { return _name; } }

		public Unit(string name)
		{
			_name = name;
		}
	}
}
