namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;

public class ThirdClassShipDeflector : ShipDeflectorBase
{
    private const double HitPointsOfThirdClassShipDeflector = 1000;

    public ThirdClassShipDeflector(PhotonDeflectorBase? photonDeflector)
        : base(HitPointsOfThirdClassShipDeflector, photonDeflector)
    {
    }
}