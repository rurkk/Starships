using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Fuels;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

public abstract class JumpingEngineBase
{
    private readonly double _maxDistance;
    protected JumpingEngineBase(double maxDistance)
    {
        _maxDistance = maxDistance;
        Fuel = new GravitonMatter();
        TimeConsumed = 0;
    }

    public GravitonMatter Fuel { get; }
    public double TimeConsumed { get; protected set; }

    public abstract void Overcome(EnvironmentBase sectionOfPath);

    public bool CheckIfPossibleToOvercome(EnvironmentBase sectionOfPath)
    {
        if (sectionOfPath is null) throw new ArgumentNullException(nameof(sectionOfPath));
        return sectionOfPath.DistanceInParsecs <= _maxDistance;
    }
}