using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;

public abstract class ShipDeflectorBase
{
    protected ShipDeflectorBase(double hitPoints, PhotonDeflectorBase? photonDeflector)
    {
        HitPoints = hitPoints;
        PhotonDeflector = photonDeflector;
    }

    public double HitPoints { get; private set; }
    public PhotonDeflectorBase? PhotonDeflector { get; set; }

    public void TakeDamage(Asteroid obstacle)
    {
        if (obstacle is null) throw new ArgumentNullException(nameof(obstacle));
        if (HitPoints < obstacle.HitPower)
        {
            obstacle.TakeDamage(HitPoints);
            HitPoints = 0;
        }
        else
        {
            HitPoints -= obstacle.HitPower;
            obstacle.TakeDamage(obstacle.HitPower);
        }
    }

    public void TakeDamage(Meteorite obstacle)
    {
        if (obstacle is null) throw new ArgumentNullException(nameof(obstacle));
        if (HitPoints < obstacle.HitPower)
        {
            obstacle.TakeDamage(HitPoints);
            HitPoints = 0;
        }
        else
        {
            HitPoints -= obstacle.HitPower;
            obstacle.TakeDamage(obstacle.HitPower);
        }
    }

    public void TakeDamage(CosmoWhale obstacle)
    {
        if (obstacle is null) throw new ArgumentNullException(nameof(obstacle));
        if (HitPoints < obstacle.HitPower)
        {
            obstacle.TakeDamage(HitPoints);
            HitPoints = 0;
        }
        else
        {
            HitPoints -= obstacle.HitPower;
            obstacle.TakeDamage(obstacle.HitPower);
        }
    }

    public void TakeDamage(PhotonFlash obstacle)
    {
        if (obstacle is null) throw new ArgumentNullException(nameof(obstacle));
        PhotonDeflector?.TakeDamage(obstacle);
    }
}