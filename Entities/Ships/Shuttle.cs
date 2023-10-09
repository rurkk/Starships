using Itmo.ObjectOrientedProgramming.Lab1.Entities.Armor;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Shuttle : ShipBase
{
    public Shuttle()
        : base(new ImpulseC(), null, null, new FirstClassArmor(), false)
    {
    }
}