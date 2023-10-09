namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;

public class PhotonDeflector : PhotonDeflectorBase
{
    private const double HitPointsOfRegularPhotonDeflector = 3;

    public PhotonDeflector()
        : base(HitPointsOfRegularPhotonDeflector)
    {
    }
}