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
