using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    public class RealEstate
    {
        private string type;
        private double area;
        private double price;
        private string address;

        public string Type { get { return type; } set { type = value; }  }
        public double Area { get { return area; } set { area = value; } }
        public double Price { get { return price; } set { price = value; } }
        public string Address { get { return address; } set { address = value; } }

        public RealEstate(string type, double area, double price, string address)
        {
            Type = type;
            Area = area;
            Price = price;
            Address = address;
        }

        public virtual void CheckBool(bool theIf)
        {
            if (theIf == true)
            {
                Console.Write("Has ");
            }
            else
            {
                Console.Write("Doesn't have ");
            }
        }

        public void Show()
        {
            Console.Write(Type + " | " + Area + " | " + Price + " | " + Address + " | ");
        }
    }

    public class Flat : RealEstate
    {

        protected bool _hasFurniture;
        public bool Hasfurniture
        {
            get { return _hasFurniture; }
            set { _hasFurniture = value; }
        }

        public Flat(string type, double area, double price, string address, bool hasFurniture) : base(type, area, price, address)
        {
            _hasFurniture = hasFurniture;
        }

        public override void CheckBool(bool theIf)
        {
            base.CheckBool(_hasFurniture);
            Console.WriteLine("Furniture");
        }
    }

    public class House : RealEstate
    {
        protected bool _hasYard;
        public bool HasYard
        {
            get { return _hasYard; }
            set { _hasYard = value; }
        }
        public House(string type, double area, double price, string address, bool hasYard) : base(type, area, price, address)
        {
            _hasYard = hasYard;
        }
        public override void CheckBool(bool theIf)
        {
            base.CheckBool(_hasYard);
            Console.WriteLine("Yard");
        }
    }

    public class Plot : RealEstate
    {   
        public Plot(string type, double area, double price, string address) : base(type, area, price, address)
        {

        }
    }

    public class Shop : RealEstate
    {
        protected bool _hasStorage;
        public bool HasStorage
        {
            get { return _hasStorage; }
            set { _hasStorage = value; }
        }
        public Shop(string type, double area, double price, string address, bool hasStorage) : base(type, area, price, address)
        {
            _hasStorage = hasStorage;
        }
        public override void CheckBool(bool theIf)
        {
            base.CheckBool(this._hasStorage);
            Console.WriteLine("Storage");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Flat vasil = new Flat("Flat", 100, 5, "Nebesata", true);
            House houseMD = new House("House", 200, 7, "New Jersey", false);
            Plot thickens = new Plot("Plot", 1000, 2, "Kyrdjali");
            Shop muziker = new Shop("Shop", 50, 10, "Plovdiv", true);

            vasil.Show();
            vasil.CheckBool(vasil.Hasfurniture);
            houseMD.Show();
            houseMD.CheckBool(houseMD.HasYard);
            thickens.Show();
            Console.WriteLine();
            muziker.Show();
            muziker.CheckBool(muziker.HasStorage);

            Console.ReadLine();
        }
    }
}
