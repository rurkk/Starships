using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;
using Itmo.ObjectOrientedProgramming.Lab1.Services.Navigator;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class FactTests
{
    [Fact]
    public void WalkingShuttleVaklasInNormalSpaceCompareShouldReturnWalkingShuttle()
    {
        ShipBase testShuttle = new Shuttle();
        ShipBase testVaklas = new Vaklas();
        var route = new Collection<EnvironmentBase>();
        var space = new OrdinarySpace(400);
        route.Add(space);

        NavigatorBase navigator = new StockNavigator();
        Assert.Equal(CompareResult.First, navigator.WhichIsBetter(route, testShuttle, testVaklas));
    }

    [Fact]
    public void AvgurStellaCompareInNebulaeOfNitrineParticlesObstacle()
    {
        ShipBase testAvgur = new Avgur();
        ShipBase testStella = new Stella();
        var route = new Collection<EnvironmentBase>();
        var space = new NebulaeOfNitrineParticles(200);
        route.Add(space);

        NavigatorBase navigator = new StockNavigator();
        Assert.Equal(CompareResult.First, navigator.WhichIsBetter(route, testStella, testAvgur));
    }

    [Fact]
    public void ShuttleVaklasInNebulaeOfHighDensityShouldReturnVaklas()
    {
        ShipBase testVaklas = new Vaklas();
        ShipBase testShuttle = new Shuttle();
        var route = new Collection<EnvironmentBase>();
        var space = new NebulaeOfHighDensity(200);
        route.Add(space);

        NavigatorBase navigator = new StockNavigator();
        Assert.Equal(CompareResult.First, navigator.WhichIsBetter(route, testVaklas, testShuttle));
    }

    [Fact]
    public void ShuttleAvgurInAllEnvironmentsShouldReturnAvgur()
    {
        ShipBase testAvgur = new Avgur();
        ShipBase testShuttle = new Shuttle();
        var route = new Collection<EnvironmentBase>();
        OrdinarySpace ordinarySpace = new OrdinarySpace(200).AddObstacle(new Asteroid()).AddObstacle(new Meteorite());
        NebulaeOfHighDensity nebulaeOfHighDensity = new NebulaeOfHighDensity(200).AddObstacle(new CosmoWhale(1));
        var nebulaeOfNitrineParticles = new NebulaeOfNitrineParticles(50);
        route.Add(ordinarySpace);
        route.Add(nebulaeOfHighDensity);
        route.Add(nebulaeOfNitrineParticles);

        NavigatorBase navigator = new StockNavigator();
        Assert.Equal(CompareResult.First, navigator.WhichIsBetter(route, testAvgur, testShuttle));
    }
}