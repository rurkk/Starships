using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Models.OvercomeResult;
using Itmo.ObjectOrientedProgramming.Lab1.Services.Navigator;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class TheoryTests
{
    [Theory]
    [InlineData(ShipsForTests.Shuttle)]
    [InlineData(ShipsForTests.Avgur)]
    public void FlightResultFlightShouldReturnFalse(ShipsForTests testShip)
    {
        NavigatorBase navigator = new StockNavigator();
        ShipBase ship = TestConstants.GetShip(testShip);
        var route = new Collection<EnvironmentBase>();
        var nebulae = new NebulaeOfNitrineParticles(400);
        route.Add(nebulae);
        OvercomeResult overcomeResult = navigator.Overcome(route, ship);
        Assert.False(overcomeResult.IsFinished());
    }

    [Theory]
    [InlineData(ShipsForTests.Vaklas, false)]
    [InlineData(ShipsForTests.Vaklas, true)]
    public void SimulationWithPhotonDeflectorsFlightShouldReturnFlag(ShipsForTests testShip, bool hasPhotonDeflectors)
    {
        NavigatorBase navigator = new StockNavigator();
        ShipBase ship = TestConstants.GetShip(testShip);
        if (hasPhotonDeflectors)
        {
            if (ship.Deflector != null) ship.Deflector.PhotonDeflector = new PhotonDeflector();
        }

        NebulaeOfNitrineParticles nebulae = new NebulaeOfNitrineParticles(50).AddObstacle(new PhotonFlash());
        var route = new Collection<EnvironmentBase> { nebulae };
        OvercomeResult overcomeResult = navigator.Overcome(route, ship);
        if (hasPhotonDeflectors)
        {
            Assert.True(overcomeResult.IsCrewAlive);
        }
        else
        {
            Assert.False(overcomeResult.IsCrewAlive);
        }
    }

    [Theory]
    [InlineData(ShipsForTests.Vaklas)]
    [InlineData(ShipsForTests.Avgur)]
    [InlineData(ShipsForTests.Meridian)]
    public void SimulationWithCosmoWhaleFlightShouldReturnFlag(ShipsForTests testShip)
    {
        NavigatorBase navigator = new StockNavigator();
        ShipBase ship = TestConstants.GetShip(testShip);
        NebulaeOfHighDensity nebulae = new NebulaeOfHighDensity(50).AddObstacle(new CosmoWhale(1));
        var route = new Collection<EnvironmentBase> { nebulae };

        // Act
        OvercomeResult overcomeResult = navigator.Overcome(route, ship);
        switch (testShip)
        {
            case ShipsForTests.Vaklas:
                Assert.True(!overcomeResult.IsShipAlive);
                break;
            case ShipsForTests.Avgur:
                Debug.Assert(ship.Deflector != null, "ship.Deflector != null");
                Assert.True(ship.Deflector.HitPoints < 1 && overcomeResult.IsFinished());
                break;
            case ShipsForTests.Meridian:
                Debug.Assert(ship.Deflector != null, "ship.Deflector != null");
                Assert.True(ship.Deflector.HitPoints > 99 && overcomeResult.IsFinished());
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(testShip), testShip, null);
        }
    }
}