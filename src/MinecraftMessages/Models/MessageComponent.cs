using System.Drawing;

namespace Minecraft.Messages;

/// <summary>
///     Represents a message component.
/// </summary>
public class MessageComponent
{
    /// <summary>
    ///     Gets or sets the text of the component.
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    ///     Gets or sets the color of the component.
    /// </summary>
    public string? Color { get; set; }

    /// <summary>
    ///     Gets or sets the font of the component.
    /// </summary>
    public string? Font { get; set; }

    /// <summary>
    ///     Gets or sets whether the component is bold.
    /// </summary>
    public bool? Bold { get; set; }

    /// <summary>
    ///     Gets or sets whether the component is italic.
    /// </summary>
    public bool? Italic { get; set; }

    /// <summary>
    ///     Gets or sets whether the component is underlined.
    /// </summary>
    public bool? Underlined { get; set; }

    /// <summary>
    ///     Gets or sets whether the component is strikethrough.
    /// </summary>
    public bool? Strikethrough { get; set; }

    /// <summary>
    ///     Gets or sets whether the component is obfuscated.
    /// </summary>
    public bool? Obfuscated { get; set; }

    /// <summary>
    ///     Gets or sets the click event of the component.
    /// </summary>
    public ClickEvent? ClickEvent { get; set; }

    /// <summary>
    ///     Gets or sets the hover event of the component.
    /// </summary>
    public HoverEvent? HoverEvent { get; set; }

    /// <summary>
    ///     Creates a new instance of <see cref="MessageComponent" />.
    /// </summary>
    public MessageComponent()
    {
        Text = string.Empty;
    }

    /// <summary>
    ///     Creates a new instance of <see cref="MessageComponent" />.
    /// </summary>
    /// <param name="text"> Sets the text of the component. </param>
    public MessageComponent(string text)
    {
        Text = text ?? string.Empty;
    }

    /// <summary>
    ///     Creates a new instance of <see cref="MessageComponent" />.
    /// </summary>
    /// <param name="text"> Sets the text of the component. </param>
    /// <returns> The new instance of <see cref="MessageComponent" />. </returns>
    public static MessageComponent Create(string text = "") => new(text);

    /// <summary>
    ///     Sets the text of the component.
    /// </summary>
    /// <param name="text"> The text of the component. </param>
    /// <returns> The current instance of <see cref="MessageComponent" />. </returns>
    public MessageComponent WithText(string text)
    {
        Text = text ?? string.Empty;
        return this;
    }

    /// <summary>
    ///     Sets the color of the component.
    /// </summary>
    /// <param name="color"> The color of the component. </param>
    /// <returns> The current instance of <see cref="MessageComponent" />. </returns>
    public MessageComponent WithColor(MinecraftColor color)
    {
        Color = color.ToString().ToSnakeCase();
        return this;
    }

    /// <summary>
    ///     Sets the font of the component.
    /// </summary>
    /// <param name="font"> The font of the component. </param>
    /// <returns> The current instance of <see cref="MessageComponent" />. </returns>
    public MessageComponent WithFont(string font)
    {
        Font = font;
        return this;
    }

    /// <summary>
    ///     Sets the color of the component.
    /// </summary>
    /// <param name="color"> The color of the component. </param>
    /// <returns> The current instance of <see cref="MessageComponent" />. </returns>
    public MessageComponent WithColor(Color color)
    {
        Color = $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        return this;
    }

    /// <summary>
    ///     Sets whether the component is bold.
    /// </summary>
    /// <param name="isBold"> Whether the component is bold. </param>
    /// <returns> The current instance of <see cref="MessageComponent" />. </returns>
    public MessageComponent WithBold(bool isBold = true)
    {
        Bold = isBold;
        return this;
    }

    /// <summary>
    ///     Sets whether the component is italic.
    /// </summary>
    /// <param name="isItalic"> Whether the component is italic. </param>
    /// <returns> The current instance of <see cref="MessageComponent" />. </returns>
    public MessageComponent WithItalic(bool isItalic = true)
    {
        Italic = isItalic;
        return this;
    }

    /// <summary>
    ///     Sets whether the component is underlined.
    /// </summary>
    /// <param name="isUnderlined"> Whether the component is underlined. </param>
    /// <returns> The current instance of <see cref="MessageComponent" />. </returns>
    public MessageComponent WithUnderlined(bool isUnderlined = true)
    {
        Underlined = isUnderlined;
        return this;
    }

    /// <summary>
    ///     Sets whether the component is strikethrough.
    /// </summary>
    /// <param name="isStrikethrough"> Whether the component is strike through. </param>
    /// <returns> The current instance of <see cref="MessageComponent" />. </returns>
    public MessageComponent WithStrikethrough(bool isStrikethrough = true)
    {
        Strikethrough = isStrikethrough;
        return this;
    }

    /// <summary>
    ///     Sets whether the component is obfuscated.
    /// </summary>
    /// <param name="isObfuscated"> Whether the component is obfuscated. </param>
    /// <returns> The current instance of <see cref="MessageComponent" />. </returns>
    public MessageComponent WithObfuscated(bool isObfuscated = true)
    {
        Obfuscated = isObfuscated;
        return this;
    }

    /// <summary>
    ///     Sets the click event of the component.
    /// </summary>
    /// <param name="action"> The action of the click event. </param>
    /// <param name="value"> The value of the click event. </param>
    /// <returns> The current instance of <see cref="MessageComponent" />. </returns>
    public MessageComponent WithClickEvent(ClickAction action, string value)
    {
        ClickEvent = new ClickEvent(action, value);
        return this;
    }

    /// <summary>
    ///     Sets the hover event of the component.
    /// </summary>
    /// <param name="action"> The action of the hover event. </param>
    /// <param name="contents"> The contents of the hover event. </param>
    /// <returns> The current instance of <see cref="MessageComponent" />. </returns>
    public MessageComponent WithHoverEvent(HoverAction action, string contents)
    {
        HoverEvent = new HoverEvent(action, contents);
        return this;
    }
}
