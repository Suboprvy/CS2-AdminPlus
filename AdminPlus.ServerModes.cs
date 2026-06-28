using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;

public class ServerModeConfig
{
    public int RestartDelay { get; set; } = 1;

    public List<ServerMode> Modes { get; set; } = new();
}

public class ServerMode
{
    public string Name { get; set; } = "";

    public List<string> Commands { get; set; } = new();
}
