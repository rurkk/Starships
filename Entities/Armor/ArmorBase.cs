using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Armor;

public abstract class ArmorBase
{
    private double _hitPoints;
    protected ArmorBase(double hitPoints)
    {
        _hitPoints = hitPoints;
    }

    public void TakeDamage(Asteroid obstacle)
    {
        if (obstacle is null) throw new ArgumentNullException(nameof(obstacle));
        if (_hitPoints < obstacle.HitPower)
        {
            obstacle.TakeDamage(_hitPoints);
            _hitPoints = 0;
        }
        else
        {
            _hitPoints -= obstacle.HitPower;
            obstacle.TakeDamage(obstacle.HitPower);
        }
    }

    public void TakeDamage(Meteorite obstacle)
    {
        if (obstacle is null) throw new ArgumentNullException(nameof(obstacle));
        if (_hitPoints < obstacle.HitPower)
        {
            obstacle.TakeDamage(_hitPoints);
            _hitPoints = 0;
        }
        else
        {
            _hitPoints -= obstacle.HitPower;
            obstacle.TakeDamage(obstacle.HitPower);
        }
    }

    public void TakeDamage(CosmoWhale obstacle)
    {
        if (obstacle is null) throw new ArgumentNullException(nameof(obstacle));
        if (_hitPoints < obstacle.HitPower)
        {
            obstacle.TakeDamage(_hitPoints);
            _hitPoints = 0;
        }
        else
        {
            _hitPoints -= obstacle.HitPower;
            obstacle.TakeDamage(obstacle.HitPower);
        }
    }
}