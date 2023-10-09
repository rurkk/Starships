using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

public class ImpulseE : ImpulseEngineBase
{
    private const double FuelConsumptionPerSecImpulseE = 1000;
    private const double FuelConsumptionForStartImpulseE = 1000;

    public ImpulseE()
        : base(FuelConsumptionPerSecImpulseE, FuelConsumptionForStartImpulseE)
    {
    }

    protected override double TimeToOvercome(EnvironmentBase sectionOfPath)
    {
        if (sectionOfPath is null) throw new ArgumentNullException(nameof(sectionOfPath));
        return Math.Log(sectionOfPath.DistanceInParsecs * sectionOfPath.DragCoefficient);
    }
}