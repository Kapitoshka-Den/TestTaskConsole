using System.Configuration;

namespace myApp.Services;

public class ConnectChange
{
    public void ChangeConnection(string connectionString)
    {
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
        connectionStringsSection.ConnectionStrings["connection"].ConnectionString = connectionString;
        config.Save();
        ConfigurationManager.RefreshSection("connectionStrings");
    }
}