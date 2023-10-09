namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Armor;

public class FirstClassArmor : ArmorBase
{
    private const double HitPointsOfFirstClassArmor = 25;

    public FirstClassArmor()
        : base(HitPointsOfFirstClassArmor)
    {
    }
}