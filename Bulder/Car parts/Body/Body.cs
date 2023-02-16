﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bulder.Car_parts
{
	public class SteelBody : IBody
	{ 
		public string Name { get; } = "SteelBody";
	}

	public class AluminiumBody : IBody
	{
		public string Name { get; } = "AluminiumBody";
	}
}
