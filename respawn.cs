using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Utils;

namespace RespawnPlugin;

public class RespawnPlugin : BasePlugin
{
    public override string ModuleName => "Respawn Command Plugin";
    public override string ModuleVersion => "0.0.1";
    public override string ModuleAuthor => "godzilla";

  
  public override void Load(bool hotReload)
  
       {
            
            CommandHandler.RegisterCommand("!respawn", RespawnCommandHandler);
        }

        private void RespawnCommandHandler(string[] args)
        {
           
            CounterStrikeAPI.Player.Respawn(); 
            
        }
    }

