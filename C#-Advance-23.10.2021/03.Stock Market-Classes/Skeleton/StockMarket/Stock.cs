using System.Text;

namespace StockMarket
{
    public class Stock
    {
        public string CompanyName { get;private set; } 
        public string Director { get; private set; } 
        public decimal PricePerShare { get; private set; } 
        public int TotalNumberOfShares { get; private set; } 
        public decimal MarketCapitalization { get; private set; }
        public Stock(string CompanyName,string Director, decimal PricePerShare,int TotalNumberOfShares)
        {
            this.CompanyName = CompanyName;
            this.Director = Director;
            this.PricePerShare = PricePerShare;
            this.TotalNumberOfShares = TotalNumberOfShares;
            this.MarketCapitalization = PricePerShare * TotalNumberOfShares;
        }

        public override string ToString()
        {

            return $"Company: {CompanyName}\nDirector: {Director}\nPrice per share: ${PricePerShare}\nMarket capitalization: ${MarketCapitalization}";
        }
    }
}
