using CounterStrikeSharp.API.Core;

namespace HelloWorldPlugin;

public class HelloWorldPlugin : BasePlugin
{
    public override string ModuleName => "Hello World Plugin";

    public override string ModuleVersion => "0.0.1";

    public override void Load(bool hotReload)
    {
        Logger.LogInformation("Plugin loaded successfully!");
    }

    [GameEventHandler]
    public HookResult OnPlayerConnect(EventPlayerConnect @event, GameEventInfo info)
    {
        // Userid will give you a reference to a CCSPlayerController class
        Logger.LogInformation("Player {Name} has connected!", @event.Userid.PlayerName);

        return HookResult.Continue;
    }

    [ConsoleCommand("issue_warning", "Issue warning to player")]
    public void OnCommand(CCSPlayerController? player, CommandInfo command)
    {
        Logger.LogWarning("Player shouldn't be doing that");
    }
}
