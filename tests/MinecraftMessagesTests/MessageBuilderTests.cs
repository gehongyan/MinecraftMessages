using Minecraft.Messages;

namespace MinecraftMessagesTests;

public class MessageBuilderTests
{
    [Fact]
    public void CreateMessageTests()
    {
        MessageComponent component = MessageComponent.Create()
            .WithText("Hello")
            .WithBold()
            .WithItalic()
            .WithUnderlined()
            .WithStrikethrough()
            .WithObfuscated()
            .WithFont("minecraft:default")
            .WithClickEvent(ClickAction.OpenUrl, "https://github.com/gehongyan/MinecraftMessages")
            .WithHoverEvent(HoverAction.ShowText, "Click to open the project page");
        JsonMessageBuilder builder = new();
        builder.AddComponent(component);
        string raw = builder.ToString();
        string json = builder.ToJson();
        string markdown = builder.ToMarkdown();
    }
}
