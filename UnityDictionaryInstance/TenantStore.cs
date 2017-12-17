using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDictionaryInstance
{
    public class TenantStore : ITenantStore
    {
        public TenantStore(Dictionary<string, string> dictionary)
        {
                
        }

        public IEnumerable<string> GetTenantNames()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void UploadLogo(string tenant, byte[] logo)
        {
            throw new NotImplementedException();
        }
    }
}
