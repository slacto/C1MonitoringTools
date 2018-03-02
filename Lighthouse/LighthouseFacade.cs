using System.Collections.Generic;
using System.Linq;
using Lighthouse.Configuration;

namespace Lighthouse
{
    public static class LighthouseFacade
    {
        public static void RunLighthouseAndSaveJson()
        {
            foreach (var page in GetPages())
            {
                var url = page.Url;

                //
            }
        }

        public static IEnumerable<LighthouseElement> GetPages()
        {
            return LighthouseSection.GetSection().Pages.Cast<LighthouseElement>();
        }
    }
}