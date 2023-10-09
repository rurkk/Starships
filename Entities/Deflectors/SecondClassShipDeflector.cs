namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;

public class SecondClassShipDeflector : ShipDeflectorBase
{
    private const double HitPointsOfSecondClassShipDeflector = 300;

    public SecondClassShipDeflector(PhotonDeflectorBase? photonDeflector)
        : base(HitPointsOfSecondClassShipDeflector, photonDeflector)
    {
    }
}