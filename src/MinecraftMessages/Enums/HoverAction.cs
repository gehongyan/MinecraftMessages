namespace Minecraft.Messages;

/// <summary>
///     Represents a hover action.
/// </summary>
public enum HoverAction
{
    /// <summary> The show text action. </summary>
    /// <remarks>
    ///     Shows a raw JSON text component.
    /// </remarks>
    ShowText,
    /// <summary> The show item action. </summary>
    /// <remarks>
    ///     Shows the tooltip of an item as if it was being hovering over it in an inventory.
    /// </remarks>
    ShowItem,
    /// <summary> The show entity action. </summary>
    /// <remarks>
    ///     Shows an entity's name, type, and UUID. Used by selector.
    /// </remarks>
    ShowEntity,
}
