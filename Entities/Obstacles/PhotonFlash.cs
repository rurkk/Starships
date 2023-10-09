using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

public class PhotonFlash : ObstacleBase
{
    private const double PhotonFlashHitPower = 1;

    public PhotonFlash()
        : base(PhotonFlashHitPower)
    {
    }

    public override void MakeDamage(ShipBase ship)
    {
        if (ship is null) throw new ArgumentNullException(nameof(ship));
        ship.TakeDamage(this);
    }
}