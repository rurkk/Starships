using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public static class TestConstants
{
    public static ShipBase GetShip(ShipsForTests ship)
    {
        switch (ship)
        {
            case ShipsForTests.Avgur: return new Avgur();
            case ShipsForTests.Meridian: return new Meridian();
            case ShipsForTests.Shuttle: return new Shuttle();
            case ShipsForTests.Stella: return new Stella();
            case ShipsForTests.Vaklas: return new Vaklas();
        }

        throw new InvalidOperationException();
    }
}