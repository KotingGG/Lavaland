using Robust.Shared.GameStates;
using Content.Shared.Whitelist;

namespace Content.Shared.Stunnable.Components;

[RegisterComponent, NetworkedComponent, Access(typeof(SharedStunSystem))]
public sealed partial class StunOnContactComponent : Component
{
    /// <summary>
    /// The fixture the entity must collide with to be stunned
    /// </summary>
    [DataField]
    public string FixtureId = "fix";
    /// <summary>
    /// The duration of the stun.
    /// </summary>
    [DataField]
    public TimeSpan StunTime = TimeSpan.FromSeconds(3f);

    [DataField("ignoreWhitelist")]
    public EntityWhitelist? IgnoreWhitelist;
}
