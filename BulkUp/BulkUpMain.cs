using Vintagestory.API.Client;
using Vintagestory.API.Server;
using Vintagestory.API.Config;
using Vintagestory.API.Common;

namespace BulkUp;

public class BulkUpMain : ModSystem
{
    /*
        TODO:

        create player attributes class for holding stats
            ensure ability to save/load along with player data (might need to harmony it idk)
            
    
        create debugging tools
            command library 
                increasing/decreasing stats
                reset stats
                get stats for player
    
    */
    public override void Start(ICoreAPI api)
    {
        api.Logger.Notification("Hello from template mod: " + api.Side);
    }

    public override void StartServerSide(ICoreServerAPI api)
    {
        api.Logger.Notification("Hello from template mod server side: " + Lang.Get("bulkup:hello"));
    }

    public override void StartClientSide(ICoreClientAPI api)
    {
        api.Logger.Notification("Hello from template mod client side: " + Lang.Get("bulkup:hello"));
    }
}
