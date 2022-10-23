using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
	class Transport
	{
		public float speed;
	}

	class Auto:Transport
	{
		private string model;

		public Auto(float speed, string model)
		{
			this.speed = speed;
			this.model = model;
			Console.Write("Speed is " + speed + ", model is " + model);
		}
	}

	class Program
	{

		public static void Main(String[] args)
		{
			Auto bmw = new Auto(250.5f, "X3");
			Auto mercedes = new Auto(270f, "C63 AMG");
		}
	}
}
