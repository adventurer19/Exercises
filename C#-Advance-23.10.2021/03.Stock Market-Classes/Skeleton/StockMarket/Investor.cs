using System.Collections.Generic;
using System.Linq;

namespace StockMarket
{
    public class Investor
    {
        private readonly List<Stock> Portfolio;
        public int Count { get => Portfolio.Count; }
        public string FullName { get; private set; }
        public string EmailAddress { get; private set; }
        public decimal MoneyToInvest { get; private set; }

        public string BrokerName { get; private set; }

        public Investor(string FullName,string EmailAddress,decimal MoneyToInvest,string BrokerName)
        {
            Portfolio = new List<Stock>();
            this.FullName = FullName;
            this.EmailAddress = EmailAddress;
            this.MoneyToInvest = MoneyToInvest;
            this.BrokerName = BrokerName;
        }
         
        public void BuyStock(Stock stock)
        {
            if(stock.MarketCapitalization>10000 && MoneyToInvest>=stock.PricePerShare)
            {
                MoneyToInvest -= stock.PricePerShare;
                Portfolio.Add(stock);
            }

            
        }
        public string SellStock(string companyName, decimal sellPrice)
        {
            var company = Portfolio.Find(x => x.CompanyName == companyName);
            if (company == null)
            {
                return $"{companyName} does not exist.";
            }
            else
            {
                if(sellPrice<company.PricePerShare)
                {
                    return $"Cannot sell {companyName}.";
                }
                else
                {
                    Portfolio.Remove(company);
                    this.MoneyToInvest += company.PricePerShare;
                    return $"{companyName} was sold.";
                }
            }

        }
        public Stock FindStock(string companyName)
        {

            return Portfolio.Find(x => x.CompanyName == companyName);
        }
        public Stock FindBiggestCompany()
        {
            return Portfolio.OrderByDescending(x => x.MarketCapitalization).FirstOrDefault();

        }
        public string InvestorInformation()
        {

            return $"The investor {FullName} with a broker {BrokerName} has stocks: \n{string.Join("\n", Portfolio)}";

        }
    }
}
