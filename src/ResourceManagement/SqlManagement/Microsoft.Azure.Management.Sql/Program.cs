using System;
using Microsoft.Azure.Management.Sql;
using Microsoft.Azure.Management.Sql.Models;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        
    }

    public static async Task MainAsync()
    {
        var sqlClient = new SqlManagementClient(null, new System.Net.Http.DelegatingHandler[0]);
        string resourceGroup = "resgrp";

        var server = await sqlClient.Servers.CreateOrUpdateAsync(
            new Server
            {
                AdministratorLogin = "hello",
                AdministratorLoginPassword = "password"
            },
            resourceGroup,
            "myserver");

        server.AdministratorLoginPassword = "hello";

        await sqlClient.Servers.CreateOrUpdateAsync(
            server,
            "resgrp",
            "myserver");

        var db = await sqlClient.Databases.CreateOrUpdateAsync(
            "mydb",
            new Database
            {
                Edition = "Basic"
            },
            resourceGroup,
            server.Name);

        await sqlClient.Databases.CreateOrUpdateAsync(
            "mydb",
            new Database
            {
                RequestedServiceObjectiveId = Guid.Empty.ToString()
            },
            resourceGroup,
            server.Name);
    }
}
