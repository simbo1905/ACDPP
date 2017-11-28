﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dashboard;
using System.Configuration;
using Extensions;
using System.Reflection;

namespace Dashboard.Classes
{
    public class AppSettings
    {
        public static string VaultUrl = ConfigurationManager.AppSettings["VaultUrl"];
        public static string VaultClientId = ConfigurationManager.AppSettings["VaultClientId"];
        public static string VaultClientSecret = ConfigurationManager.AppSettings["VaultClientSecret"];

        public static string AzureTenantId = ConfigurationManager.AppSettings["AzureTenantId"];
        public static string AzureResourceGroup = ConfigurationManager.AppSettings["AzureResourceGroup"];
        public static string AppStartIP = ConfigurationManager.AppSettings["AppStartIP"];
        public static string AppEndIP = ConfigurationManager.AppSettings["AppEndIP"];

        public static string SourceAccountName = ConfigurationManager.AppSettings["SourceAccountName"];
        public static string SourceProjectName = ConfigurationManager.AppSettings["SourceProjectName"];
        public static string SourceRepoName = ConfigurationManager.AppSettings["SourceRepoName"];
        public static string SourceBuildName = ConfigurationManager.AppSettings["SourceBuildName"];
        public static string ConfigBuildName = ConfigurationManager.AppSettings["ConfigBuildName"];

        public static string VSTSAccountEmail = ConfigurationManager.AppSettings["VSTSAccountEmail"];
        public static string VSTSPersonalAccessToken = ConfigurationManager.AppSettings["VSTSPersonalAccessToken"];

        public static string SourceInstanceUrl = $"https://{SourceAccountName}.visualstudio.com/";
        public static string SourceProjectUrl = $"{SourceInstanceUrl}{SourceProjectName}";
        public static string SourceCollectionUrl = $"{SourceInstanceUrl}DefaultCollection";
        public static string SourceRepoUrl = $"{SourceProjectUrl}/_git/{SourceRepoName}";

        public static string TargetProjectTemplateId = ConfigurationManager.AppSettings["TargetProjectTemplateId"];

        public static string ProjectCreatedBy = ConfigurationManager.AppSettings["ProjectCreatedBy"].ToStringOr(Assembly.GetExecutingAssembly().GetName().Name);

        public static string GovNotifyClientRef = ConfigurationManager.AppSettings["GovNotifyClientRef"];
        public static string GovNotifyApiKey = ConfigurationManager.AppSettings["GovNotifyApiKey"];
        public static string GovNotifyApiTestKey = ConfigurationManager.AppSettings["GovNotifyApiTestKey"];
        public static string WelcomeTemplateId = ConfigurationManager.AppSettings["WelcomeTemplateId"];
        public static string ErrorTemplateId = ConfigurationManager.AppSettings["ErrorTemplateId"];

        public static string AzureStorageConnectionString = ConfigurationManager.AppSettings["AzureStorageConnectionString"];

    }
}
