using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_izpit
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var obj1 = new NedvijimImot(30, 700, "centur");
			var obj2 = new Apartment(24, 500, "trakiq", true);
			var obj3 = new House(40, 200, "kurshaka", false);
			var obj4 = new NezastroeniPloshti( 10, 430, "kichuka");
			var obj5 = new Shop( 75, 1500, "centur", true);

			obj1.ShowInfo();
			obj2.ShowInfo();
			obj3.ShowInfo();
			obj4.ShowInfo();
			obj5.ShowInfo();

		}
	}
	class NedvijimImot {																	// 1

		private string _type;																// 2
		private double _area;																// 2										
		protected double ppsm;  // price per square meter									// 2
		protected string location;															// 2

		public NedvijimImot(double area, double ppsm, string location)						// 1
		{
			this._type = "none";
			this._area = area;
			this.ppsm = ppsm;
			this.location = location;
		}
		public string type																	// 2
		{
			get { return this._type; }
			set { this._type = value; }
		}
		public double area																	// 2
		{
			get { return this._area; }
			set { this._area = value; }
		}
		public virtual void ShowSpecificInfo()												// 3
		{
			Console.WriteLine("Nothing special for me");
		}
		public virtual void ShowInfo()														// 4
		{
			Console.WriteLine($"{this.type}, plosht: {this.area}, {this.ppsm}lv. za kv.m, {this.location}");
			this.ShowSpecificInfo();
		}
	}
	class Apartment : NedvijimImot
	{
		private bool obzaveden;

		public Apartment(double area, double ppsm, string location, bool obzaveden) : base(area, ppsm, location)
		{
			this.type = "apartment";
			this.obzaveden = obzaveden;
		}

		public string type
		{
			get { return base.type; }
			set { base.type = value; }
		}
		public double area
		{
			get { return base.area; }
			set { base.area = value; }
		}
		public double ppsm
		{
			get { return base.ppsm; }
			set { base.ppsm = value; }
		}
		public string location
		{
			get { return base.location; }
			set { base.location = value; }
		}


		public override void ShowSpecificInfo()
		{
			string msg = obzaveden ? "Obzaveden e" : "Ne e obzaveden";
			Console.WriteLine(msg);
		}

	}
	class House : NedvijimImot
	{
		private bool dvornoMqsto;
		
		public House(double area, double ppsm, string location, bool dvornoMqsto) : base(area, ppsm, location)
		{
			this.type = "house";
			this.dvornoMqsto = dvornoMqsto;
		}
		
		public string type
		{
			get { return base.type; }
			set { base.type = value; }
		}
		public double area
		{
			get { return base.area; }
			set { base.area = value; }
		}
		public double ppsm
		{
			get { return base.ppsm; }
			set { base.ppsm = value; }
		}
		public string location
		{
			get { return base.location; }
			set { base.location = value; }
		}
		public override void ShowSpecificInfo()
		{
			string msg = dvornoMqsto ? "Ima dvorno mqsto" : "Nqma dvorno mqsto";
			Console.WriteLine(msg);
		}
	}
	class NezastroeniPloshti : NedvijimImot
	{

		public NezastroeniPloshti(double area, double ppsm, string location) : base(area, ppsm, location){
			this.type = "nezastroena plosht";
		}

		public string type
		{
			get { return base.type; }
			set { base.type = value; }
		}
		public double area
		{
			get { return base.area; }
			set { base.area = value; }
		}
		public double ppsm
		{
			get { return base.ppsm; }
			set { base.ppsm = value; }
		}
		public string location
		{
			get { return base.location; }
			set { base.location = value; }
		}
		public override void ShowSpecificInfo()
		{
			Console.WriteLine("Not build yet");
		}
	}
	class Shop : NedvijimImot
	{
		private bool sklad;

		public Shop(double area, double ppsm, string location, bool sklad) : base(area, ppsm, location)
		{
			this.type = "Shop";
			this.sklad = sklad;
		}

		public string type
		{
			get { return base.type; }
			set { base.type = value; }
		}
		public double area
		{
			get { return base.area; }
			set { base.area = value; }
		}
		public double ppsm
		{
			get { return base.ppsm; }
			set { base.ppsm = value; }
		}
		public string location
		{
			get { return base.location; }
			set { base.location = value; }
		}
		public override void ShowSpecificInfo()
		{
			string msg = sklad ? "Ima skladovo pomeshtenie" : "Nqma skladovo pomeshtenie";		// moje da se zamesti sus komentara otdolu
			/*
			 * string msg
			 * if (sklad == true)
			 *		msg = "Ima skladovo pomeshtenie"
			 * else
			 *      msg = "Nqma skladovo pomeshtenie"
			 */
			Console.WriteLine(msg);
		}
	}
}
