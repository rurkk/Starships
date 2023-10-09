using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

public class OrdinarySpace : EnvironmentBase
{
    private const double DragCoefficientOrdinarySpace = 1;
    private readonly List<ObstacleBase> _obstacles = new List<ObstacleBase>();

    public OrdinarySpace(double distanceInParsecs)
        : base(DragCoefficientOrdinarySpace, distanceInParsecs)
    {
    }

    public override void Overcome(ShipBase ship)
    {
        if (ship is null) throw new ArgumentNullException(nameof(ship));
        foreach (ObstacleBase obstacle in _obstacles)
        {
            obstacle.MakeDamage(ship);
        }

        ship.Overcome(this);
    }

    public OrdinarySpace AddObstacle(Asteroid obstacle)
    {
        _obstacles.Add(obstacle);
        return this;
    }

    public OrdinarySpace AddObstacle(Meteorite obstacle)
    {
        _obstacles.Add(obstacle);
        return this;
    }
}