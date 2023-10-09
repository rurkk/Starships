using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

public class Alpha : JumpingEngineBase
{
    private const double MaxDistanceAlpha = 100;
    private const double SpeedAlpha = 300;

    public Alpha()
        : base(MaxDistanceAlpha)
    {
    }

    public override void Overcome(EnvironmentBase sectionOfPath)
    {
        if (sectionOfPath is null) throw new ArgumentNullException(nameof(sectionOfPath));
        Fuel.FuelConsumed += sectionOfPath.DistanceInParsecs * sectionOfPath.DistanceInParsecs;
        TimeConsumed += sectionOfPath.DistanceInParsecs * sectionOfPath.DistanceInParsecs / SpeedAlpha;
    }
}