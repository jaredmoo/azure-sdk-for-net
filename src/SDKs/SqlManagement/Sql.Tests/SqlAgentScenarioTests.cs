
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.ResourceManager;
using Microsoft.Azure.Management.ResourceManager.Models;
using Microsoft.Azure.Management.Sql;
using Microsoft.Azure.Management.Sql.Models;
using System.Collections.Generic;
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

                // Create database
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

        [Fact]
        public void TestExecuteJob()
        {
            using (SqlManagementTestContext context = new SqlManagementTestContext(this))
            {
                ResourceGroup resourceGroup = context.CreateResourceGroup();
                Server server = context.CreateServer(resourceGroup);
                SqlManagementClient sqlClient = context.GetClient<SqlManagementClient>();

                // Create firewall rule to allow azure service access
                sqlClient.FirewallRules.CreateOrUpdate(resourceGroup.Name, server.Name, "AllowAzure", new FirewallRule
                {
                    StartIpAddress = "0.0.0.0",
                    EndIpAddress = "0.0.0.0"
                });

                // Create database
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

                // Create job credential
                string credentialName = "cred1";
                var credential = sqlClient.JobCredentials.CreateOrUpdate(resourceGroup.Name, server.Name, agentName, credentialName, new JobCredential
                {
                    Username = SqlManagementTestUtilities.DefaultLogin,
                    Password = SqlManagementTestUtilities.DefaultPassword
                });

                // Create target group
                string targetGroupName = "targetGroup1";
                var targetGroup = sqlClient.JobTargetGroups.CreateOrUpdate(resourceGroup.Name, server.Name, agentName, targetGroupName, new JobTargetGroup
                {
                    Members = new[]
                    {
                        new JobTarget
                        {
                            Type = JobTargetType.SqlDatabase,
                            ServerName = server.Name,
                            DatabaseName = db1.Name
                        }
                    }
                });

                // Create job
                string jobName = "job1";
                var job = sqlClient.Jobs.CreateOrUpdate(resourceGroup.Name, server.Name, agentName, jobName, new Job());

                // Create job step
                string stepName = "step1";
                var jobStep = sqlClient.JobSteps.CreateOrUpdate(resourceGroup.Name, server.Name, agentName, jobName, stepName, new JobStep
                {
                    TargetGroup = targetGroup.Id,
                    Credential = credential.Id,
                    Action = new JobStepAction
                    {
                        Value = "select 1"
                    }
                });

                // Execute job
                var execution = sqlClient.JobExecutions.Create(resourceGroup.Name, server.Name, agentName, jobName);

                // Verify execution succeeded
                Assert.Equal(JobExecutionLifecycle.Succeeded, execution.Lifecycle);
            }
        }
    }
}
