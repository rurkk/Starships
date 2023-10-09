using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

public class Asteroid : ObstacleBase
{
    private const double AsteroidHitPower = 25;

    public Asteroid()
        : base(AsteroidHitPower)
    { }

    public override void MakeDamage(ShipBase ship)
    {
        if (ship is null) throw new ArgumentNullException(nameof(ship));
        ship.TakeDamage(this);
    }
}