using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;

public abstract class PhotonDeflectorBase
{
    private double _hitPoints;
    protected PhotonDeflectorBase(double hitPoints)
    {
        _hitPoints = hitPoints;
    }

    public void TakeDamage(PhotonFlash obstacle)
    {
        if (obstacle is null) throw new ArgumentNullException(nameof(obstacle));
        if (_hitPoints < obstacle.HitPower)
        {
            obstacle.TakeDamage(_hitPoints);
            _hitPoints = 0;
        }
        else
        {
            obstacle.TakeDamage(obstacle.HitPower);
            _hitPoints -= obstacle.HitPower;
        }
    }
}