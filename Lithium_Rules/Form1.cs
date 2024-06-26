using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StringExtensions;

namespace Lithium_Rules
{
    public partial class Form1 : Form
    {
        string sConn = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FFInternal.clEncryptDes DES = new FFInternal.clEncryptDes(Application.CompanyName);
            sConn = DES.ConnectionString2;
            clGlobal.IFConnection = sConn;
            clGlobal.HostConnection = DES.ConnectionString;
            DES = null;
            Properties.Settings.Default["SOIFDBNewConnectionString"] = sConn;
            FillData();
            //this.lithiumRulesTableAdapter.Fill(this.sOIFDBNewDataSet.LithiumRules);

        }
        internal void FillData()
        {             
            try
            {
                cbGroup.DataSource = null;
                using (IFDBDataDataContext ctx = new IFDBDataDataContext(sConn))
                {
                    var Grps = (from r in ctx.LithiumRules
                                orderby r.LithiumGroup
                                select r.LithiumGroup).Distinct();
                    if (Grps != null)
                    {
                        cbGroup.Items.Clear();
                        cbGroup.DataSource = Grps.ToList();
                        
                        
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void RefreshGrid(int grp)
        {
            this.lithiumRulesTableAdapter.Fill(this.sOIFDBNewDataSet.LithiumRules, grp);
           // this.lithiumRulesTableAdapter.Fill(this.sOIFDBNewDataSet.LithiumRules,grp);
        }

        private void cbGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            } 
        }

        private void cbGroup_SelectedValueChanged(object sender, EventArgs e)
        {
            int iGrp = cbGroup.Text.StrToIntDef(-1);
            if (iGrp > -1)
            {
                RefreshGrid(iGrp);
            }
        }

        private bool CheckAuthorized()
        {
            bool bAuthorized = false;
            using (dlgCheckPasswd dlg = new dlgCheckPasswd(sConn))
            {
                bAuthorized = (dlg.ShowDialog() == DialogResult.OK);
            }
            clGlobal.bUpdateAuthorized = bAuthorized;
            return bAuthorized;
        }
        private void btnNewGrp_Click(object sender, EventArgs e)
        {
            int iGrp = cbGroup.Text.StrToIntDef(-1);
            if (iGrp > 0)
            {
                if (CheckAuthorized())
                { 
                
                    using (dlgAddRule dlg = new dlgAddRule(iGrp))
                    {
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            FillData();
                        }
                    }
                    this.lithiumRulesTableAdapter1.Fill(this.sOIFDBNewDataSet1.LithiumRules);
                }
                else
                {
                   MessageBox.Show("You are not authorized to add rules");
                }
            }
            else
            {

               MessageBox.Show("Please enter a valid group number");
            }   

        }

        private void cbGroup_TextChanged(object sender, EventArgs e)
        {
            cbGroup_SelectedValueChanged(sender, e);
        }

        private void addRuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckAuthorized())
            {

                using (dlgAddRule dlg = new dlgAddRule(-1))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                       // FillData();
                    }
                }
                this.lithiumRulesTableAdapter1.Fill(this.sOIFDBNewDataSet1.LithiumRules);
            }
            else
            {
                MessageBox.Show("You are not authorized to add rules");
            }
            
        }
        private void updateRuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iGrp = -1;
            if (tabControl1.SelectedIndex == 1 && dataGridView2.SelectedRows.Count > 0)
            {
                if (dataGridView2.SelectedRows[0].DataBoundItem is DataRowView)
                {
                    DataRowView drv = dataGridView2.SelectedRows[0].DataBoundItem as DataRowView;
                    if (drv != null)
                    {
                        iGrp = drv.Row.Field<int>("LithiumGroup");
                        string sLth = drv.Row.Field<string>("LithiumType");
                        string sRt = drv.Row.Field<string>("LithiumRoute");  
                        string sOT = drv.Row.Field<string>("LithiumOrderType");
                        string sSA = drv.Row.Field<string>("LithiumShipAlone");
                        if (iGrp > 0)
                        {
                            if (CheckAuthorized())
                            {
                                using (dlgAddRule dlg = new dlgAddRule(iGrp))
                                {
                                    dlg.LoadRule(iGrp,sLth, sRt,sOT,sSA);
                                    if (dlg.ShowDialog() == DialogResult.OK)
                                    {
                                        //FillData();

                                    }
                                }
                                this.lithiumRulesTableAdapter1.Fill(this.sOIFDBNewDataSet1.LithiumRules);
                            }
                            else
                            {
                                MessageBox.Show("You are not authorized to add rules");
                            }
                        }
                    }
                }
            }
        }


        private void deleteRuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1 && dataGridView2.SelectedRows.Count > 0)
            {
                if (dataGridView2.SelectedRows[0].DataBoundItem is DataRowView)
                {
                    DataRowView drv = dataGridView2.SelectedRows[0].DataBoundItem as DataRowView;
                    if (drv != null)
                    {
                        if (CheckAuthorized())
                        {
                            int iGrp = drv.Row.Field<int>("LithiumGroup");
                            string sLth = drv.Row.Field<string>("LithiumType").ToUpper();
                            string sRt = drv.Row.Field<string>("LithiumRoute");
                            string sOT = drv.Row.Field<string>("LithiumOrderType");
                            string sSA = drv.Row.Field<string>("LithiumShipAlone");
                            try
                            {
                                using (IFDBDataDataContext ctx = new IFDBDataDataContext(clGlobal.IFConnection))
                                {
                                    var oR = ctx.LithiumRules.Where(r => r.LithiumGroup == iGrp
                                      && r.LithiumType == sLth).FirstOrDefault();
                                    if (oR != null)
                                    {
                                        if (MessageBox.Show($"Delete Rule {iGrp}/{sLth}?", "Delete Rule", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                        {
                                            ctx.LithiumRules.DeleteOnSubmit(oR);
                                            ctx.SubmitChanges();
                                            this.lithiumRulesTableAdapter1.Fill(this.sOIFDBNewDataSet1.LithiumRules);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Rule not found for {iGrp}/{sLth}");
                                    }

                                    ctx.SubmitChanges();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a rule to delete");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a rule to delete");
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = tabControl1.SelectedIndex;
            if (selectedIndex == 0)
            {
                FillData();
                int iGrp = cbGroup.Text.StrToIntDef(-1);
                if (iGrp > -1)
                {
                    RefreshGrid(iGrp);
                }
            }
            else
            {
                this.lithiumRulesTableAdapter1.Fill(this.sOIFDBNewDataSet1.LithiumRules);   //(this.sOIFDBNewDataSet.LithiumRules);
            }
        }
    }
}
