using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

public abstract class ObstacleBase
{
    protected ObstacleBase(double hitPower)
    {
        HitPower = hitPower;
    }

    public double HitPower { get; private set; }

    public abstract void MakeDamage(ShipBase ship);

    public void TakeDamage(double damage)
    {
        if (damage < 0 || damage > HitPower)
        {
            throw new ArgumentOutOfRangeException(nameof(damage), " out of range.");
        }

        HitPower -= damage;
    }
}