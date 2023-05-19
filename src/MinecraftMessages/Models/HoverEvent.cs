namespace Minecraft.Messages;

/// <summary>
///     Represents a hover event.
/// </summary>
public class HoverEvent
{
    /// <summary>
    ///     Creates a new instance of <see cref="HoverEvent" />.
    /// </summary>
    /// <param name="action"> The action of the hover event. </param>
    /// <param name="contents"> The contents of the hover event. </param>
    public HoverEvent(HoverAction action, string contents)
    {
        Action = action.ToString().ToSnakeCase();
        Contents = contents;
    }

    /// <summary>
    ///     Gets or sets the action of the hover event.
    /// </summary>
    public string Action { get; set; }
    /// <summary>
    ///     Gets or sets the contents of the hover event.
    /// </summary>
    public string Contents { get; set; }
}
