using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

public class ImpulseC : ImpulseEngineBase
{
    private const double FuelConsumptionPerSecImpulseC = 1;
    private const double FuelConsumptionForStartImpulseC = 1;
    private const double SpeedImpulseC = 1;

    public ImpulseC()
        : base(FuelConsumptionPerSecImpulseC, FuelConsumptionForStartImpulseC)
    {
    }

    protected override double TimeToOvercome(EnvironmentBase sectionOfPath)
    {
        if (sectionOfPath is null) throw new ArgumentNullException(nameof(sectionOfPath));
        return sectionOfPath.DistanceInParsecs * sectionOfPath.DragCoefficient / SpeedImpulseC;
    }
}