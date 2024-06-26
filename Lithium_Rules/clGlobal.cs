using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lithium_Rules
{
    internal static class clGlobal
    {
        internal static string HostConnection = string.Empty;
        internal static clHostDatabase HostDB = new clHostDatabase();
        internal static bool bUpdateAuthorized = false;
        internal static string IFConnection;
    }
}
