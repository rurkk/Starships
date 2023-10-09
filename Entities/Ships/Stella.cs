using Itmo.ObjectOrientedProgramming.Lab1.Entities.Armor;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Stella : ShipBase
{
    public Stella()
        : base(new ImpulseC(), new Omega(), new FirstClassShipDeflector(null), new FirstClassArmor(), false)
    {
    }
}