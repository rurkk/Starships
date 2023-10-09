using Itmo.ObjectOrientedProgramming.Lab1.Entities.Armor;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Avgur : ShipBase
{
    public Avgur()
        : base(new ImpulseE(), new Alpha(), new ThirdClassShipDeflector(null), new ThirdClassArmor(), false)
    {
    }
}