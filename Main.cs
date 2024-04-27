using System.Reflection;
using MelonLoader;

namespace OnlineMode
{
        public class Main : MelonPlugin
        {
            public override void OnApplicationEarlyStart()
            {
                // Use reflection to access the internal ManagedAnalyticsBlocker's allowlist
                try
                {
                    Type blockerType = Type.GetType("MelonLoader.Utils.ManagedAnalyticsBlocker, MelonLoader");
                    if (blockerType != null)
                    {
                        var allowListField = blockerType.GetField("_explicitAllowList", BindingFlags.Static | BindingFlags.NonPublic);
                        if (allowListField != null)
                        {
                            var allowList = (HashSet<string>)allowListField.GetValue(null);
                            allowList.Add("nex-starri-functions-prod.azurewebsites.net");  // Add domain to whitelist
                            LoggerInstance.Msg("Domain 'nex-starri-functions-prod.azurewebsites.net' has been added to the whitelist.");

                            allowList.Add("nex-starri-pubsub-prod.webpubsub.azure.com");  // Add domain to whitelist
                            LoggerInstance.Msg("Domain 'nex-starri-pubsub-prod.webpubsub.azure.com' has been added to the whitelist.");

                    }
                        else
                        {
                            LoggerInstance.Error("Unable to find the '_explicitAllowList' field.");
                        }
                    }
                    else
                    {
                        LoggerInstance.Error("Unable to find the 'ManagedAnalyticsBlocker' type.");
                    }
                }
                catch (Exception ex)
                {
                    LoggerInstance.Error("An error occurred while trying to modify the allowlist: " + ex.Message);
                }
            }
        }
}
