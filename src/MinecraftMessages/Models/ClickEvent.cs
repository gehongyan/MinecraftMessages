namespace Minecraft.Messages;

/// <summary>
///     Represents a click event.
/// </summary>
public class ClickEvent
{
    /// <summary>
    ///     Creates a new instance of <see cref="ClickEvent" />.
    /// </summary>
    /// <param name="action"> The action of the click event. </param>
    /// <param name="value"> The value of the click event. </param>
    public ClickEvent(ClickAction action, string value)
    {
        Action = action.ToString().ToSnakeCase();
        Value = value;
    }

    /// <summary>
    ///     Gets or sets the action of the click event.
    /// </summary>
    public string Action { get; set; }
    /// <summary>
    ///     Gets or sets the value of the click event.
    /// </summary>
    public string Value { get; set; }
}
