using System;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Fuels;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.FuelExchange;

public abstract class FuelExchangeBase
{
    private readonly double _priceOfActivePlasma;
    private readonly double _priceOfGravitonMatter;

    protected FuelExchangeBase(double priceOfActivePlasma, double priceOfGravitonMatter)
    {
        _priceOfActivePlasma = priceOfActivePlasma;
        _priceOfGravitonMatter = priceOfGravitonMatter;
    }

    public double CountFuelCost(ActivePlasma fuel)
    {
        if (fuel is null) throw new ArgumentNullException(nameof(fuel));
        return fuel.FuelConsumed * _priceOfActivePlasma;
    }

    public double CountFuelCost(GravitonMatter fuel)
    {
        if (fuel is null) throw new ArgumentNullException(nameof(fuel));
        return fuel.FuelConsumed * _priceOfGravitonMatter;
    }
}