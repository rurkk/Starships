using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Fuels;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

public abstract class ImpulseEngineBase
{
    private readonly double _fuelConsumptionPerSec;
    private readonly double _fuelConsumptionForStart;
    protected ImpulseEngineBase(double fuelConsumptionPerSec, double fuelConsumptionForStart)
    {
        _fuelConsumptionPerSec = fuelConsumptionPerSec;
        _fuelConsumptionForStart = fuelConsumptionForStart;
        Fuel = new ActivePlasma();
        TimeConsumed = 0;
    }

    public ActivePlasma Fuel { get; }
    public double TimeConsumed { get; private set; }
    public void Overcome(EnvironmentBase sectionOfPath)
    {
        if (sectionOfPath is null) throw new ArgumentNullException(nameof(sectionOfPath));
        Fuel.FuelConsumed += _fuelConsumptionForStart;
        Fuel.FuelConsumed += _fuelConsumptionPerSec * TimeToOvercome(sectionOfPath) * sectionOfPath.DragCoefficient;
        TimeConsumed += TimeToOvercome(sectionOfPath);
    }

    protected abstract double TimeToOvercome(EnvironmentBase sectionOfPath);
}
