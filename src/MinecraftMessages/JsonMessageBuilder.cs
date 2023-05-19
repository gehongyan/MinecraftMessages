using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace Minecraft.Messages;

/// <summary>
///     Represents a message component.
/// </summary>
public sealed class JsonMessageBuilder
{
    private readonly List<MessageComponent> _components = new();

    /// <summary>
    ///     Creates a new instance of <see cref="JsonMessageBuilder" />.
    /// </summary>
    /// <returns> The new instance of <see cref="JsonMessageBuilder" />. </returns>
    public static JsonMessageBuilder Create() => new();

    /// <summary>
    ///     Adds a component to the message.
    /// </summary>
    /// <param name="component"> The component to add. </param>
    /// <returns> The current instance of <see cref="JsonMessageBuilder" />. </returns>
    public JsonMessageBuilder AddComponent(MessageComponent component)
    {
        _components.Add(component);
        return this;
    }

    /// <summary>
    ///     Adds multiple components to the message.
    /// </summary>
    /// <param name="components"> The components to add. </param>
    /// <returns> The current instance of <see cref="JsonMessageBuilder" />. </returns>
    public JsonMessageBuilder AddComponents(IEnumerable<MessageComponent> components)
    {
        _components.AddRange(components);
        return this;
    }

    /// <summary>
    ///     Returns the raw text of the message.
    /// </summary>
    /// <returns> The raw text of the message. </returns>
    public override string ToString() =>
        _components.Any()
            ? _components.Select(c => c.Text).Aggregate((a, b) => $"{a}{b}")
            : string.Empty;

    /// <summary>
    ///     Converts the message to JSON format.
    /// </summary>
    /// <returns> The message in JSON format. </returns>
    public string ToJson()
    {
        JsonSerializerOptions options = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
        };
        return JsonSerializer.Serialize(_components, options);
    }

    /// <summary>
    ///     Converts the message to Markdown format.
    /// </summary>
    /// <returns> The message in Markdown format. </returns>
    public string ToMarkdown() =>
        _components.Any()
            ? _components.Select(x =>
                    x.Text?.Split('\n', '\r')
                        .Select(y =>
                        {
                            if (string.IsNullOrWhiteSpace(y)) return y;
                            string text = y;
                            text = x.Bold is true ? $"**{text}**" : text;
                            text = x.Italic is true ? $"_{text}_" : text;
                            text = x.Underlined is true ? $"__{text}__" : text;
                            return text;
                        }).Aggregate((a, b) => $"{a}\n{b}"))
                .Aggregate((a, b) => $"{a}{b}")
            ?? string.Empty
            : string.Empty;
}
