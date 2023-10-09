namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Armor;

public class SecondClassArmor : ArmorBase
{
    private const double HitPointsOfSecondClassArmor = 200;

    public SecondClassArmor()
        : base(HitPointsOfSecondClassArmor)
    {
    }
}