using System.Configuration;

namespace Lighthouse.Configuration
{
    public class LighthouseSection : ConfigurationSection
    {
        private const string ConfigPath = "c1MonitoringTools/Lighthouse";

        [ConfigurationProperty("", IsDefaultCollection = true)]
        public LighthouseCollection Pages
        {
            get => (LighthouseCollection)this[""];
            set => this[""] = value;
        }

        public static LighthouseSection GetSection()
        {
            return ConfigurationManager.GetSection(ConfigPath) as LighthouseSection;
        }
    }
}