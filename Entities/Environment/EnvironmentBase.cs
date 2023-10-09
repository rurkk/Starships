using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

public abstract class EnvironmentBase
{
    protected EnvironmentBase(double dragCoefficient, double distanceInParsecs)
    {
        DragCoefficient = dragCoefficient;
        DistanceInParsecs = distanceInParsecs;
    }

    public double DragCoefficient { get; }
    public double DistanceInParsecs { get; }
    public abstract void Overcome(ShipBase ship);
}