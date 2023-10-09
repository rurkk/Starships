namespace Itmo.ObjectOrientedProgramming.Lab1.Services.FuelExchange;

public class StockFuelMarket : FuelExchangeBase
{
    private const double PriceOfActivePlasmaInStockFuelMarket = 10;
    private const double PriceOfGravitonMatterInStockFuelMarket = 10;

    public StockFuelMarket()
        : base(PriceOfActivePlasmaInStockFuelMarket, PriceOfGravitonMatterInStockFuelMarket)
    {
    }
}