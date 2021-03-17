using System.Globalization;

namespace ConsoleApp.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFree { get; set; }
        

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFree) 
            :base(name, price)
        {
            CustomsFree = customsFree;
        }
        public double TotalPrice()
        {

            return Price + CustomsFree;
        }

        public override string PriceTag()
        {
            return Name
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " $"
                + CustomsFree.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
