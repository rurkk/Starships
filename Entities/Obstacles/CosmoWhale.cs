using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

public class CosmoWhale : ObstacleBase
{
    private const double CosmoWhaleHitPower = 1000;

    public CosmoWhale(uint amount)
        : base(CosmoWhaleHitPower * amount)
    { }

    public override void MakeDamage(ShipBase ship)
    {
        if (ship is null) throw new ArgumentNullException(nameof(ship));
        ship.TakeDamage(this);
    }
}