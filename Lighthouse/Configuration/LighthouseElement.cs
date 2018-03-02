using System.Configuration;

namespace Lighthouse.Configuration
{
    public class LighthouseElement : ConfigurationElement
    {
        [ConfigurationProperty("url")]
        public string Url
        {
            get => (string) this["url"];
            set => this["url"] = value;
        }

        [ConfigurationProperty("title")]
        public string Title
        {
            get => (string) this["title"];
            set => this["title"] = value;
        }

        [ConfigurationProperty("description")]
        public string Description
        {
            get => (string) this["description"];
            set => this["description"] = value;
        }
    }
}