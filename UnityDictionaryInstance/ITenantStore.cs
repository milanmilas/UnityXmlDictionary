using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDictionaryInstance
{
    public interface ITenantStore
    {
        void Initialize();
        IEnumerable<string> GetTenantNames();
        void UploadLogo(string tenant, byte[] logo);
    }
}
