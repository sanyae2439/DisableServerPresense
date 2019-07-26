using Smod2;
using Smod2.Attributes;
using UnityEngine;

namespace DisableServerPresense
{
    [PluginDetails(
    author = "sanyae2439",
    name = "DisableServerPresense",
    description = "Disable Discord presense from server",
    id = "sanyae2439.disableServerPresense",
    version = "1.0",
    SmodMajor = 3,
    SmodMinor = 5,
    SmodRevision = 0
    )]
    public class DisableServerPresense : Plugin
    {
        public DisableServerPresense()
        {

        }

        public override void OnDisable()
        {
            this.Info("DisableServerPresense Disabled...");
        }

        public override void OnEnable()
        {
            this.Info("DisableServerPresense Enabled!");

            this.Info("Disabled DiscordManager...");
            UnityEngine.Object.DestroyImmediate(GameObject.FindObjectOfType<DiscordManager>());

            this.Info("Disabled DiscordController...");
            UnityEngine.Object.DestroyImmediate(GameObject.FindObjectOfType<DiscordController>());

            this.Info("Disable Completed.");
        }

        public override void Register()
        {

        }
    }
}