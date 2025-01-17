using Robust.Shared.Prototypes;
using Content.Server.Explosion.Components;
using Robust.Shared.Containers;

namespace Content.Server.Imperial.ClusterArrayGrenade;

/// <summary>
/// Implementation of <see cref="ClusterGrenadeSystem" /> with <see cref="FillPrototype" /> replaced by an array
/// </summary>
[RegisterComponent, Access(typeof(ClusterArrayGrenadeSystem))]
public sealed partial class ClusterArrayGrenadeComponent : Component
{
    public Container GrenadesContainer = default!;

    /// <summary>
    ///     What we fill our prototype with if we want to pre-spawn with grenades.
    /// </summary>
    [DataField("fillPrototype")]
    public List<EntProtoId> FillPrototype = new();

    /// <summary>
    ///     If we have a pre-fill how many more can we spawn.
    /// </summary>
    public int UnspawnedCount;

    /// <summary>
    ///     Maximum delay in seconds between individual grenade triggers
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("grenadeTriggerIntervalMax")]
    public float GrenadeTriggerIntervalMax = 0f;

    /// <summary>
    ///     Minimum delay in seconds between individual grenade triggers
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("grenadeTriggerIntervalMin")]
    public float GrenadeTriggerIntervalMin = 0f;

    /// <summary>
    ///     Minimum delay in seconds before any grenades start to be triggered.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("baseTriggerDelay")]
    public float BaseTriggerDelay = 1.0f;

    /// <summary>
    ///     Decides if grenades trigger after getting launched
    /// </summary>
    [DataField("triggerGrenades")]
    public bool TriggerGrenades = true;

    /// <summary>
    ///     Does the cluster grenade shoot or throw
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("grenadeType")]
    public GrenadeType GrenadeType = GrenadeType.Throw;

    /// <summary>
    ///     The speed at which grenades get thrown
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("velocity")]
    public float Velocity = 5;

    /// <summary>
    ///     Should the spread be random
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("randomSpread")]
    public bool RandomSpread = false;

    /// <summary>
    ///     Should the angle be random
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("randomAngle")]
    public bool RandomAngle = false;

    /// <summary>
    ///     Static distance grenades will be thrown to.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("distance")]
    public float Distance = 1f;

    /// <summary>
    ///     Max distance grenades should randomly be thrown to.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("maxSpreadDistance")]
    public float MaxSpreadDistance = 2.5f;

    /// <summary>
    ///     Minimal distance grenades should randomly be thrown to.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("minSpreadDistance")]
    public float MinSpreadDistance = 0f;

    /// <summary>
    ///     This is the end.
    /// </summary>
    public bool CountDown;
}
