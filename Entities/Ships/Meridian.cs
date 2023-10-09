using Itmo.ObjectOrientedProgramming.Lab1.Entities.Armor;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Meridian : ShipBase
{
    public Meridian()
        : base(new ImpulseE(), new Gamma(), new SecondClassShipDeflector(null), new SecondClassArmor(), true)
    {
    }
}