using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Armor;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public abstract class ShipBase
{
    private readonly bool _hasAntineutronEmitter;

    protected ShipBase(
        ImpulseEngineBase impulseEngine,
        JumpingEngineBase? jumpingEngine,
        ShipDeflectorBase? deflector,
        ArmorBase armor,
        bool hasAntineutronEmitter)
    {
        IsAlive = true;
        IsCrewAlive = true;
        IsLost = false;
        ImpulseEngine = impulseEngine ?? throw new ArgumentNullException(nameof(impulseEngine));
        JumpingEngine = jumpingEngine;
        Deflector = deflector;
        Armor = armor ?? throw new ArgumentNullException(nameof(armor));
        _hasAntineutronEmitter = hasAntineutronEmitter;
    }

    public bool IsAlive { get; private set; }
    public bool IsCrewAlive { get; private set; }
    public bool IsLost { get; private set; }
    public ImpulseEngineBase ImpulseEngine { get; }
    public JumpingEngineBase? JumpingEngine { get; }
    public ShipDeflectorBase? Deflector { get; }
    private ArmorBase Armor { get; }

    public void Overcome(OrdinarySpace environment)
    {
        if (environment is null) throw new ArgumentNullException(nameof(environment));
        ImpulseEngine.Overcome(environment);
    }

    public void Overcome(NebulaeOfHighDensity environment)
    {
        if (environment is null) throw new ArgumentNullException(nameof(environment));
        ImpulseEngine.Overcome(environment);
    }

    public void Overcome(NebulaeOfNitrineParticles environment)
    {
        if (JumpingEngine is null || !JumpingEngine.CheckIfPossibleToOvercome(environment))
        {
            IsLost = true;
            return;
        }

        JumpingEngine.Overcome(environment);
    }

    public void TakeDamage(Asteroid obstacle)
    {
        if (obstacle is null) throw new ArgumentNullException(nameof(obstacle));
        Deflector?.TakeDamage(obstacle);
        Armor.TakeDamage(obstacle);

        if (obstacle.HitPower > 0)
        {
            IsAlive = false;
            IsCrewAlive = false;
        }
    }

    public void TakeDamage(Meteorite obstacle)
    {
        if (obstacle is null) throw new ArgumentNullException(nameof(obstacle));
        Deflector?.TakeDamage(obstacle);
        Armor.TakeDamage(obstacle);

        if (obstacle.HitPower > 0)
        {
            IsAlive = false;
            IsCrewAlive = false;
        }
    }

    public void TakeDamage(CosmoWhale obstacle)
    {
        if (obstacle is null) throw new ArgumentNullException(nameof(obstacle));
        if (_hasAntineutronEmitter) return;
        Deflector?.TakeDamage(obstacle);
        Armor.TakeDamage(obstacle);

        if (obstacle.HitPower > 0)
        {
            IsAlive = false;
            IsCrewAlive = false;
        }
    }

    public void TakeDamage(PhotonFlash obstacle)
    {
        if (obstacle is null) throw new ArgumentNullException(nameof(obstacle));
        Deflector?.TakeDamage(obstacle);

        if (obstacle.HitPower > 0)
        {
            IsCrewAlive = false;
        }
    }
}