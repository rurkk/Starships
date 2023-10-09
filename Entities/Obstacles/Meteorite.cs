using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

public class Meteorite : ObstacleBase
{
    private const double MeteoriteHitPower = 100;

    public Meteorite()
        : base(MeteoriteHitPower)
    {
    }

    public override void MakeDamage(ShipBase ship)
    {
        if (ship is null) throw new ArgumentNullException(nameof(ship));
        ship.TakeDamage(this);
    }
}