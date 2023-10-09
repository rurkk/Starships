using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

public class Omega : JumpingEngineBase
{
    private const double MaxDistanceBeta = 200;
    private const double SpeedBeta = 300;

    public Omega()
        : base(MaxDistanceBeta)
    {
    }

    public override void Overcome(EnvironmentBase sectionOfPath)
    {
        if (sectionOfPath is null) throw new ArgumentNullException(nameof(sectionOfPath));
        Fuel.FuelConsumed += sectionOfPath.DistanceInParsecs * sectionOfPath.DistanceInParsecs *
                             Math.Log(sectionOfPath.DistanceInParsecs * sectionOfPath.DistanceInParsecs);
        TimeConsumed += sectionOfPath.DistanceInParsecs * sectionOfPath.DistanceInParsecs / SpeedBeta;
    }
}