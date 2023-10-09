namespace Itmo.ObjectOrientedProgramming.Lab1.Models.OvercomeResult;

public class OvercomeResult
{
    public OvercomeResult(bool isShipAlive, bool isCrewAlive, bool isShipLost, double timeConsumed, double moneyConsumed)
    {
        IsShipAlive = isShipAlive;
        IsCrewAlive = isCrewAlive;
        IsShipLost = isShipLost;
        TimeConsumed = timeConsumed;
        MoneyConsumed = moneyConsumed;
    }

    public bool IsShipAlive { get; }
    public bool IsCrewAlive { get; }
    public bool IsShipLost { get; }
    public double TimeConsumed { get; }
    public double MoneyConsumed { get; }

    public bool IsFinished()
    {
        return this is { IsCrewAlive: true, IsShipAlive: true, IsShipLost: false };
    }
}