
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.ResourceManager;
using Microsoft.Azure.Management.ResourceManager.Models;
using Microsoft.Azure.Management.Sql;
using Microsoft.Azure.Management.Sql.Models;
using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.Rest.Azure;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Sql.Tests
{
    public class SqlAgentScenarioTests
    {
        [Fact]
        public void TestCreateUpdateDropAgent()
        {
            using (SqlManagementTestContext context = new SqlManagementTestContext(this))
            {
                ResourceGroup resourceGroup = context.CreateResourceGroup();
                Server server = context.CreateServer(resourceGroup);
                SqlManagementClient sqlClient = context.GetClient<SqlManagementClient>();

                // Create database only required parameters
                string dbName = SqlManagementTestUtilities.GenerateName();
                var db1 = sqlClient.Databases.CreateOrUpdate(resourceGroup.Name, server.Name, dbName, new Database()
                {
                    Location = server.Location,
                    RequestedServiceObjectiveName = "S1"
                });
                Assert.NotNull(db1);

                // Create agent
                string agentName = "agent1";
                var agent1 = sqlClient.JobAgents.CreateOrUpdate(resourceGroup.Name, server.Name, agentName, new JobAgent
                {
                    Location = server.Location,
                    DatabaseId = db1.Id
                });

                // Update agent tags
                agent1 = sqlClient.JobAgents.CreateOrUpdate(resourceGroup.Name, server.Name, agentName, new JobAgent
                {
                    Location = server.Location,
                    DatabaseId = db1.Id,
                    Tags = new Dictionary<string, string>()
                    {
                        { "tagKey1", "TagValue1" }
                    }
                });

                // Get agent
                agent1 = sqlClient.JobAgents.Get(resourceGroup.Name, server.Name, agentName);

                // List agents
                var agents = sqlClient.JobAgents.ListByServer(resourceGroup.Name, server.Name);

                // Delete agent
                sqlClient.JobAgents.Delete(resourceGroup.Name, server.Name, agentName);
            }
        }
    }
}
