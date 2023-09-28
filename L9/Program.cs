using System.Reflection.Metadata;

namespace L9
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobile car = new Automobile { Brand = "Hundai" , Model = "i20" , NumDoors = 4 };
            car.setPrice(750000);

            Console.WriteLine("car Brand {0} and Model {1} with {2} Doors and costs {3}",car.Brand,car.Model,car.NumDoors,car.Price.ToString("C"));

            Console.Read();
        }
    }
    class Automobile
    {
        
        public string Brand { get; set;}
        public string Model { get; set;}
        //public double Price { get; set;}
        public int NumDoors { get; set;}
        
 
        //private string strBrand;
        //private string strModel;
        private double dblPrice;
        //private int intNumDoors;

        //public string Brand {  get { return strBrand; } set {  strBrand = value; } }
        //public string Model { get { return strModel; } set { strModel = value; } }
        public double Price { get { return dblPrice; }  }
        //public int NumDoors { get {  return intNumDoors; } set {  intNumDoors = value; } }
        
        public void setPrice (double dblPrice)
        {
            const double UP_CHRAGE = 0.10;
            this.dblPrice = dblPrice * ( 1 + UP_CHRAGE);

        }
        ~Automobile()
        {
            Console.WriteLine("{0} and {1} are destroyed ",Brand,Model);

        }  
    }
}
