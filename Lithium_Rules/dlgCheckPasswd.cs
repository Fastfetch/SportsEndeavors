using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FFInternal;

namespace Lithium_Rules
{
    public partial class dlgCheckPasswd : Form
    {
        string sConnection;
        internal string sRslt;
        internal string sAuthUser;
        internal string sAuthLvl;
        /// <summary>
        /// Constructor for UserPassword check
        /// </summary>
        /// <param name="sCs"></param>
        public dlgCheckPasswd(string sCs)
        {
            InitializeComponent();
            sConnection = sCs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sRslt = string.Empty;
            FFInternal.clUserPswd.enumAuthLevel chkLvl =
                clGlobal.HostDB.FindUpdateAuthorityLevel();
            using (HostDataClassesDataContext ctx = new HostDataClassesDataContext(clGlobal.HostConnection))
            {
                string sAuth = (from a in ctx.tblUsers
                                where a.UserID.ToUpper() == tbAuthUser.Text.Trim().ToUpper()
                                select a.MenuPrivilege.ToUpper()).FirstOrDefault();
                if (!string.IsNullOrEmpty(sAuth)
                    && FFInternal.clUserPswd.CheckAuthLevel(sAuth,chkLvl))
                {
                    sRslt = "Invalid Password";
                    sAuthUser = tbAuthUser.Text;
                    sAuthLvl = sAuth;
                    UserPswd P = (from u in ctx.UserPswds
                                  where u.UPUserID == tbAuthUser.Text.Trim()
                                  select u).FirstOrDefault();
                    if (P != null)
                    {
                        if (P.UPPswd == null)
                        {
                            int iCnt = (from t in ctx.UserPswds
                                        where t.UPPswd != null
                                        select t).Count();
                            DialogResult = (iCnt == 0) ? DialogResult.OK : DialogResult.Cancel;
                        }
                        else
                        {
                            
                            FFInternal.clUserPswd chk = new FFInternal.clUserPswd(P.UPUserID, P.UPPswd.ToArray());
                            DialogResult = (chk.PasswordEquals(tbAuthPswd.Text.Trim())) ? DialogResult.OK : DialogResult.Cancel;
                        }
                    }
                    else
                    {
                        DialogResult = DialogResult.Cancel;
                    }
                }
                else
                {
                    sRslt = "Insufficient Authority";
                    DialogResult = DialogResult.Cancel;
                }

            }
        }
    }
}
