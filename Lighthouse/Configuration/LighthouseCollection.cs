using System.Configuration;

namespace Lighthouse.Configuration
{
    public class LighthouseCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new LighthouseElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((LighthouseElement) element).Url;
        }
    }
}