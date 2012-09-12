using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enyim.Caching.Web
{
  class MemcachedSessionStateProvider : MembaseSessionStateProvider
  {
    protected override void InitializeClient(string name, System.Collections.Specialized.NameValueCollection config)
    {
      this.client = ProviderHelper.GetClient(name, config, () => (IMemcachedClientFactory)new DefaultClientFactory());
    }
  }
}
