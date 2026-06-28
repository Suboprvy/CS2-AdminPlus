using System.Collections.Generic;
using CounterStrikeSharp.API.Core;

namespace AdminPlus;

public partial class AdminPlus
{
    private class ServerModeConfig
    {
        public List<ServerMode> Modes { get; set; } = new();
    }

    private class ServerMode
    {
        public string Name { get; set; } = "";
        public List<string> Commands { get; set; } = new();
    }

    private ServerModeConfig _serverModes = new();
}
