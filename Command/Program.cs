using Command.Entities;

namespace Command
{
    class Program
    {
        static void Main()
        {
            Stock abcStock = new Stock();
            BuyStock buyStockOrder = new BuyStock(abcStock);
            SellStock sellStockOrder = new SellStock(abcStock);

            Broker broker = new Broker();
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);
            broker.PlaceOrders();
        }
    }
}