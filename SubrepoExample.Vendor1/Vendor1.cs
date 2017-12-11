using System;
using SubrepoExample.Common;

namespace SubrepoExample.Vendor1
{
    public class Vendor1 : IVendor
    {
        public string GetName()
        {
            return "Vendor1";
        }
    }
}
