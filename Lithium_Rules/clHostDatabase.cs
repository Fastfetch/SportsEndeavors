using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FFInternal;

namespace Lithium_Rules
{
    
    class clHostDatabase
    {
        internal clUserPswd.enumAuthLevel FindUpdateAuthorityLevel()
        {
            FFInternal.clUserPswd.enumAuthLevel eRtn
                = FFInternal.clUserPswd.enumAuthLevel.None;
      
            try
            {
                using (HostDataClassesDataContext ctx = new HostDataClassesDataContext(clGlobal.HostConnection))
                {
                    ctx.ObjectTrackingEnabled = false;
                    var Req = (from o in ctx.RequiredAuthorities
                                where o.RAProgram.ToUpper() == "LITHIUMRULES"
                                && o.RATask.ToUpper() == "UPDATE"
                                select o.RAReqAuthority.ToUpper()).FirstOrDefault();
                    if (Req != null && Req.Count() > 0)
                    {
                        switch (Req)
                        {
                            case "LEAD":
                                eRtn = FFInternal.clUserPswd.enumAuthLevel.Lead;
                                break;
                            case "SUPERVISOR":
                                eRtn = FFInternal.clUserPswd.enumAuthLevel.Supervisor;
                                break;
                            case "ADMIN":
                                eRtn = FFInternal.clUserPswd.enumAuthLevel.Admin;
                                break;
                            case "SA":
                                eRtn = FFInternal.clUserPswd.enumAuthLevel.Sa;
                                break;

                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //FFLogging.LogWriter.WriteLog(ex, "FindUpdateAuthorityLevel");
            }
            return eRtn;

        }
 
    }
}
