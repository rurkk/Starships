using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

public class Gamma : JumpingEngineBase
{
    private const double MaxDistanceGamma = 300;
    private const double SpeedGamma = 300;

    public Gamma()
        : base(MaxDistanceGamma)
    {
    }

    public override void Overcome(EnvironmentBase sectionOfPath)
    {
        if (sectionOfPath is null) throw new ArgumentNullException(nameof(sectionOfPath));
        Fuel.FuelConsumed += sectionOfPath.DistanceInParsecs * sectionOfPath.DistanceInParsecs *
                             sectionOfPath.DistanceInParsecs * sectionOfPath.DistanceInParsecs;
        TimeConsumed += sectionOfPath.DistanceInParsecs * sectionOfPath.DistanceInParsecs / SpeedGamma;
    }
}