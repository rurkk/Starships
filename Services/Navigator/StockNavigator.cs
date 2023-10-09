using Itmo.ObjectOrientedProgramming.Lab1.Services.FuelExchange;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Navigator;

public class StockNavigator : NavigatorBase
{
    public StockNavigator()
        : base(new StockFuelMarket())
    {
    }
}