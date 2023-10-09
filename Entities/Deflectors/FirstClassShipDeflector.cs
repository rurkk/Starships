namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;

public class FirstClassShipDeflector : ShipDeflectorBase
{
    private const double HitPointsOfFirstClassShipDeflector = 100;

    public FirstClassShipDeflector(PhotonDeflectorBase? photonDeflector)
        : base(HitPointsOfFirstClassShipDeflector, photonDeflector)
    {
    }
}