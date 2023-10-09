using Itmo.ObjectOrientedProgramming.Lab1.Entities.Armor;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Vaklas : ShipBase
{
    public Vaklas()
        : base(new ImpulseE(), new Gamma(), new FirstClassShipDeflector(null), new SecondClassArmor(), false)
    {
    }
}