using System;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Models.OvercomeResult;
using Itmo.ObjectOrientedProgramming.Lab1.Services.FuelExchange;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services.Navigator;

public abstract class NavigatorBase
{
    private readonly FuelExchangeBase _fuelExchange;

    protected NavigatorBase(FuelExchangeBase fuelExchange)
    {
        _fuelExchange = fuelExchange;
    }

    public OvercomeResult Overcome(Collection<EnvironmentBase> sectionsOfPath, ShipBase ship)
    {
        if (ship is null) throw new ArgumentNullException(nameof(ship));
        if (sectionsOfPath is null) throw new ArgumentNullException(nameof(sectionsOfPath));
        foreach (EnvironmentBase section in sectionsOfPath)
        {
            section.Overcome(ship);
            if (!ship.IsAlive || ship.IsLost || !ship.IsCrewAlive) break;
        }

        double timeConsumed = 0;
        timeConsumed += ship.ImpulseEngine.TimeConsumed;
        if (ship.JumpingEngine is not null)
        {
            timeConsumed += ship.JumpingEngine.TimeConsumed;
        }

        double moneyConsumed = 0;
        moneyConsumed += _fuelExchange.CountFuelCost(ship.ImpulseEngine.Fuel);
        if (ship.JumpingEngine is not null)
        {
            timeConsumed += _fuelExchange.CountFuelCost(ship.JumpingEngine.Fuel);
        }

        return new OvercomeResult(ship.IsAlive, ship.IsCrewAlive, ship.IsLost, timeConsumed, moneyConsumed);
    }

    public CompareResult WhichIsBetter(Collection<EnvironmentBase> sectionsOfPath, ShipBase firstShip, ShipBase secondShip)
    {
        OvercomeResult firstResult = Overcome(sectionsOfPath, firstShip);
        OvercomeResult secondResult = Overcome(sectionsOfPath, secondShip);

        if (!firstResult.IsFinished() && !secondResult.IsFinished())
        {
            return CompareResult.BothNotFinished;
        }

        if (!firstResult.IsFinished() && secondResult.IsFinished())
        {
            return CompareResult.Second;
        }

        if (firstResult.IsFinished() && !secondResult.IsFinished())
        {
            return CompareResult.First;
        }

        double firstScore = (100 * firstResult.MoneyConsumed) + firstResult.TimeConsumed;
        double secondScore = (100 * secondResult.MoneyConsumed) + secondResult.TimeConsumed;

        return firstScore < secondScore ? CompareResult.First : CompareResult.Second;
    }
}