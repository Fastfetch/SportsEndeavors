using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lithium_Rules
{
    public partial class dlgAddRule : Form
    {
        int iGrp = 0;
        public dlgAddRule(int iGroup = -1)
        {
            InitializeComponent();
            
            if (iGrp > 0)
            {
                iGrp = iGroup;
                
            }
            nudGrp.Value = (iGrp > 0) ? iGrp : 0;

        }

        internal void LoadRule(int iCurGrp, string sType, string sRt, string sOT, string sSA )
        {

            nudGrp.Value = (iCurGrp > 0) ? iCurGrp : 0;
            iGrp = iCurGrp;
            tbItemType.Text = sType;
            tbRoute.Text = sRt;
            tbOrderType.Text = sOT;
            chkShipAlone.Checked = sSA == "T" ? true : false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (nudGrp.Value > 0)
            {
                iGrp = (int)nudGrp.Value;
            }
            else
            {
                MessageBox.Show("Group must be greater than 0");
                return;
            }
            if (tbItemType.Text.Length == 4 && tbItemType.Text.StartsWith("L"))
            {
                LithiumRule lr = new LithiumRule();
                lr.LithiumGroup = iGrp;
                lr.LithiumType = tbItemType.Text.ToUpper();
                lr.LithiumRoute = tbRoute.Text.ToUpper();
                lr.LithiumOrderType = tbOrderType.Text.ToUpper();
                if (!string.IsNullOrEmpty(lr.LithiumRoute))
                {
                    lr.LithiumRouteRule = 'T';
                    if (string.IsNullOrEmpty(lr.LithiumOrderType))
                    {
                        lr.LithiumOrderType = "*";
                    }
                }
                if (!string.IsNullOrEmpty(lr.LithiumOrderType))
                {
                    lr.LithiumRouteRule = 'T';
                    if (string.IsNullOrEmpty(lr.LithiumRoute))
                    {
                        lr.LithiumRoute = "*";
                    }
                }
                lr.LithiumShipAlone = chkShipAlone.Checked ? 'T' : 'F';
                lr.LithiumPromoRule = 'F';
                try
                {
                    using (IFDBDataDataContext ctx = new IFDBDataDataContext(clGlobal.IFConnection))
                    {
                        var oR = ctx.LithiumRules.Where(r => r.LithiumGroup == lr.LithiumGroup
                          && r.LithiumType == lr.LithiumType).FirstOrDefault();
                        if (oR != null)
                        { 
                            oR.LithiumRoute = lr.LithiumRoute;
                            oR.LithiumOrderType = lr.LithiumOrderType;
                            oR.LithiumRouteRule = lr.LithiumRouteRule;
                            oR.LithiumShipAlone = lr.LithiumShipAlone;
                            oR.LithiumPromoRule = lr.LithiumPromoRule;
                        }
                        
                        else
                        {
                            ctx.LithiumRules.InsertOnSubmit(lr);
                        }
                        
                        ctx.SubmitChanges();
                        DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);    
                }
            }
            else
            {
                MessageBox.Show("Item Type must be 4 characters and start with 'L'");
                return;
            }
        }
    }
}
