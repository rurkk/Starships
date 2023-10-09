using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

public class NebulaeOfHighDensity : EnvironmentBase
{
    private const double DragCoefficientNebulaeOfHighDensity = 50;
    private readonly List<ObstacleBase> _obstacles = new List<ObstacleBase>();

    public NebulaeOfHighDensity(double distanceInParsecs)
        : base(DragCoefficientNebulaeOfHighDensity, distanceInParsecs) { }

    public override void Overcome(ShipBase ship)
    {
        if (ship is null) throw new ArgumentNullException(nameof(ship));
        foreach (ObstacleBase obstacle in _obstacles)
        {
            obstacle.MakeDamage(ship);
        }

        ship.Overcome(this);
    }

    public NebulaeOfHighDensity AddObstacle(CosmoWhale obstacle)
    {
        _obstacles.Add(obstacle);
        return this;
    }
}