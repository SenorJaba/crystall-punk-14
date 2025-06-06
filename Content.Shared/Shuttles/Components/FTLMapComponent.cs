using Robust.Shared.GameStates;

namespace Content.Shared.Shuttles.Components;

/// <summary>
/// Marker that specifies a map as being for FTLing entities.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class FTLMapComponent : Component
{
    /// <summary>
    /// Offset for FTLing shuttles so they don't overlap each other.
    /// </summary>
    [DataField]
    public int Index;

    /// <summary>
    /// What parallax to use for the background, immediately gets deffered to ParallaxComponent.
    /// </summary>
    [DataField]
    public string Parallax = "CP14Ocean"; //CP14 parallax replacement

    /// <summary>
    /// CP14 FTL map ambient color
    /// </summary>
    [DataField]
    public Color AmbientColor = new(34, 90, 122);

    /// <summary>
    /// Can FTL on this map only be done to beacons.
    /// </summary>
    [DataField, AutoNetworkedField]
    public bool Beacons;
}
