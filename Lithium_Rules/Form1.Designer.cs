namespace Lithium_Rules
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAllRules = new System.Windows.Forms.DataGridView();
            this.lithiumGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lithiumTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LithiumRoute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lithiumOrderTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lithiumShipAloneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lithiumRulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sOIFDBNewDataSet = new Lithium_Rules.SOIFDBNewDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewGrp = new System.Windows.Forms.Button();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lithiumGroupDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lithiumTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lithiumOrderTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lithiumShipAloneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lithiumRulesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sOIFDBNewDataSet1 = new Lithium_Rules.SOIFDBNewDataSet1();
            this.lithiumRulesTableAdapter = new Lithium_Rules.SOIFDBNewDataSetTableAdapters.LithiumRulesTableAdapter();
            this.lithiumRulesTableAdapter1 = new Lithium_Rules.SOIFDBNewDataSet1TableAdapters.LithiumRulesTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRules)).BeginInit();
            this.ctxEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lithiumRulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOIFDBNewDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lithiumRulesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOIFDBNewDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 692);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1192, 659);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Groups";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvAllRules);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 541);
            this.panel2.TabIndex = 1;
            // 
            // dgvAllRules
            // 
            this.dgvAllRules.AutoGenerateColumns = false;
            this.dgvAllRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lithiumGroupDataGridViewTextBoxColumn,
            this.lithiumTypeDataGridViewTextBoxColumn,
            this.LithiumRoute,
            this.lithiumOrderTypeDataGridViewTextBoxColumn,
            this.lithiumShipAloneDataGridViewTextBoxColumn});
            this.dgvAllRules.ContextMenuStrip = this.ctxEdit;
            this.dgvAllRules.DataSource = this.lithiumRulesBindingSource;
            this.dgvAllRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllRules.Location = new System.Drawing.Point(0, 0);
            this.dgvAllRules.Name = "dgvAllRules";
            this.dgvAllRules.ReadOnly = true;
            this.dgvAllRules.Size = new System.Drawing.Size(1184, 541);
            this.dgvAllRules.TabIndex = 0;
            // 
            // lithiumGroupDataGridViewTextBoxColumn
            // 
            this.lithiumGroupDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lithiumGroupDataGridViewTextBoxColumn.DataPropertyName = "LithiumGroup";
            this.lithiumGroupDataGridViewTextBoxColumn.HeaderText = "Grp";
            this.lithiumGroupDataGridViewTextBoxColumn.Name = "lithiumGroupDataGridViewTextBoxColumn";
            this.lithiumGroupDataGridViewTextBoxColumn.ReadOnly = true;
            this.lithiumGroupDataGridViewTextBoxColumn.Width = 61;
            // 
            // lithiumTypeDataGridViewTextBoxColumn
            // 
            this.lithiumTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lithiumTypeDataGridViewTextBoxColumn.DataPropertyName = "LithiumType";
            this.lithiumTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.lithiumTypeDataGridViewTextBoxColumn.Name = "lithiumTypeDataGridViewTextBoxColumn";
            this.lithiumTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lithiumTypeDataGridViewTextBoxColumn.ToolTipText = "Lithium Item Type";
            this.lithiumTypeDataGridViewTextBoxColumn.Width = 68;
            // 
            // LithiumRoute
            // 
            this.LithiumRoute.DataPropertyName = "LithiumRoute";
            this.LithiumRoute.HeaderText = "Route";
            this.LithiumRoute.Name = "LithiumRoute";
            this.LithiumRoute.ReadOnly = true;
            // 
            // lithiumOrderTypeDataGridViewTextBoxColumn
            // 
            this.lithiumOrderTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lithiumOrderTypeDataGridViewTextBoxColumn.DataPropertyName = "LithiumOrderType";
            this.lithiumOrderTypeDataGridViewTextBoxColumn.HeaderText = "OrderType";
            this.lithiumOrderTypeDataGridViewTextBoxColumn.Name = "lithiumOrderTypeDataGridViewTextBoxColumn";
            this.lithiumOrderTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lithiumOrderTypeDataGridViewTextBoxColumn.ToolTipText = "Applies only to this order type";
            this.lithiumOrderTypeDataGridViewTextBoxColumn.Width = 108;
            // 
            // lithiumShipAloneDataGridViewTextBoxColumn
            // 
            this.lithiumShipAloneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lithiumShipAloneDataGridViewTextBoxColumn.DataPropertyName = "LithiumShipAlone";
            this.lithiumShipAloneDataGridViewTextBoxColumn.HeaderText = "Ship Alone";
            this.lithiumShipAloneDataGridViewTextBoxColumn.Name = "lithiumShipAloneDataGridViewTextBoxColumn";
            this.lithiumShipAloneDataGridViewTextBoxColumn.ReadOnly = true;
            this.lithiumShipAloneDataGridViewTextBoxColumn.ToolTipText = "\'T\'=>Must not mix with tools, \'F\' otherwise";
            this.lithiumShipAloneDataGridViewTextBoxColumn.Width = 111;
            // 
            // ctxEdit
            // 
            this.ctxEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRuleToolStripMenuItem,
            this.updateRuleToolStripMenuItem,
            this.deleteRuleToolStripMenuItem});
            this.ctxEdit.Name = "ctxEdit";
            this.ctxEdit.Size = new System.Drawing.Size(139, 70);
            // 
            // addRuleToolStripMenuItem
            // 
            this.addRuleToolStripMenuItem.Name = "addRuleToolStripMenuItem";
            this.addRuleToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.addRuleToolStripMenuItem.Text = "Add Rule";
            this.addRuleToolStripMenuItem.Click += new System.EventHandler(this.addRuleToolStripMenuItem_Click);
            // 
            // updateRuleToolStripMenuItem
            // 
            this.updateRuleToolStripMenuItem.Name = "updateRuleToolStripMenuItem";
            this.updateRuleToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.updateRuleToolStripMenuItem.Text = "Update Rule";
            this.updateRuleToolStripMenuItem.Click += new System.EventHandler(this.updateRuleToolStripMenuItem_Click);
            // 
            // deleteRuleToolStripMenuItem
            // 
            this.deleteRuleToolStripMenuItem.Name = "deleteRuleToolStripMenuItem";
            this.deleteRuleToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.deleteRuleToolStripMenuItem.Text = "Delete Rule";
            this.deleteRuleToolStripMenuItem.Click += new System.EventHandler(this.deleteRuleToolStripMenuItem_Click);
            // 
            // lithiumRulesBindingSource
            // 
            this.lithiumRulesBindingSource.DataMember = "LithiumRules";
            this.lithiumRulesBindingSource.DataSource = this.sOIFDBNewDataSet;
            // 
            // sOIFDBNewDataSet
            // 
            this.sOIFDBNewDataSet.DataSetName = "SOIFDBNewDataSet";
            this.sOIFDBNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNewGrp);
            this.panel1.Controls.Add(this.cbGroup);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 108);
            this.panel1.TabIndex = 0;
            // 
            // btnNewGrp
            // 
            this.btnNewGrp.Location = new System.Drawing.Point(516, 30);
            this.btnNewGrp.Name = "btnNewGrp";
            this.btnNewGrp.Size = new System.Drawing.Size(100, 40);
            this.btnNewGrp.TabIndex = 2;
            this.btnNewGrp.Text = "Update Page";
            this.btnNewGrp.UseVisualStyleBackColor = true;
            this.btnNewGrp.Click += new System.EventHandler(this.btnNewGrp_Click);
            // 
            // cbGroup
            // 
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(161, 37);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(121, 28);
            this.cbGroup.TabIndex = 1;
            this.cbGroup.SelectedValueChanged += new System.EventHandler(this.cbGroup_SelectedValueChanged);
            this.cbGroup.TextChanged += new System.EventHandler(this.cbGroup_TextChanged);
            this.cbGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbGroup_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1192, 659);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All Rules";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lithiumGroupDataGridViewTextBoxColumn1,
            this.lithiumTypeDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.lithiumOrderTypeDataGridViewTextBoxColumn1,
            this.lithiumShipAloneDataGridViewTextBoxColumn1});
            this.dataGridView2.ContextMenuStrip = this.ctxEdit;
            this.dataGridView2.DataSource = this.lithiumRulesBindingSource1;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1184, 649);
            this.dataGridView2.TabIndex = 0;
            // 
            // lithiumGroupDataGridViewTextBoxColumn1
            // 
            this.lithiumGroupDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lithiumGroupDataGridViewTextBoxColumn1.DataPropertyName = "LithiumGroup";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.lithiumGroupDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.lithiumGroupDataGridViewTextBoxColumn1.HeaderText = "Group";
            this.lithiumGroupDataGridViewTextBoxColumn1.Name = "lithiumGroupDataGridViewTextBoxColumn1";
            this.lithiumGroupDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lithiumGroupDataGridViewTextBoxColumn1.Width = 79;
            // 
            // lithiumTypeDataGridViewTextBoxColumn1
            // 
            this.lithiumTypeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lithiumTypeDataGridViewTextBoxColumn1.DataPropertyName = "LithiumType";
            this.lithiumTypeDataGridViewTextBoxColumn1.HeaderText = "Type";
            this.lithiumTypeDataGridViewTextBoxColumn1.Name = "lithiumTypeDataGridViewTextBoxColumn1";
            this.lithiumTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lithiumTypeDataGridViewTextBoxColumn1.Width = 68;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LithiumPromoRule";
            this.dataGridViewTextBoxColumn1.HeaderText = "LithiumPromoRule";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LithiumRouteRule";
            this.dataGridViewTextBoxColumn2.HeaderText = "LithiumRouteRule";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LithiumRoute";
            this.dataGridViewTextBoxColumn3.HeaderText = "Route";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 78;
            // 
            // lithiumOrderTypeDataGridViewTextBoxColumn1
            // 
            this.lithiumOrderTypeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lithiumOrderTypeDataGridViewTextBoxColumn1.DataPropertyName = "LithiumOrderType";
            this.lithiumOrderTypeDataGridViewTextBoxColumn1.HeaderText = "OrderType";
            this.lithiumOrderTypeDataGridViewTextBoxColumn1.Name = "lithiumOrderTypeDataGridViewTextBoxColumn1";
            this.lithiumOrderTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lithiumOrderTypeDataGridViewTextBoxColumn1.Width = 108;
            // 
            // lithiumShipAloneDataGridViewTextBoxColumn1
            // 
            this.lithiumShipAloneDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lithiumShipAloneDataGridViewTextBoxColumn1.DataPropertyName = "LithiumShipAlone";
            this.lithiumShipAloneDataGridViewTextBoxColumn1.HeaderText = "Ship Alone";
            this.lithiumShipAloneDataGridViewTextBoxColumn1.Name = "lithiumShipAloneDataGridViewTextBoxColumn1";
            this.lithiumShipAloneDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lithiumShipAloneDataGridViewTextBoxColumn1.ToolTipText = "\'F\'=> can chip with tools";
            this.lithiumShipAloneDataGridViewTextBoxColumn1.Width = 111;
            // 
            // lithiumRulesBindingSource1
            // 
            this.lithiumRulesBindingSource1.DataMember = "LithiumRules";
            this.lithiumRulesBindingSource1.DataSource = this.sOIFDBNewDataSet1;
            // 
            // sOIFDBNewDataSet1
            // 
            this.sOIFDBNewDataSet1.DataSetName = "SOIFDBNewDataSet1";
            this.sOIFDBNewDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lithiumRulesTableAdapter
            // 
            this.lithiumRulesTableAdapter.ClearBeforeFill = true;
            // 
            // lithiumRulesTableAdapter1
            // 
            this.lithiumRulesTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Lithium Rules";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRules)).EndInit();
            this.ctxEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lithiumRulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOIFDBNewDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lithiumRulesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOIFDBNewDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNewGrp;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAllRules;
        private SOIFDBNewDataSet sOIFDBNewDataSet;
        private System.Windows.Forms.BindingSource lithiumRulesBindingSource;
        private SOIFDBNewDataSetTableAdapters.LithiumRulesTableAdapter lithiumRulesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lithiumPromoRuleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lithiumRouteRuleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lithumRouteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private SOIFDBNewDataSet1 sOIFDBNewDataSet1;
        private System.Windows.Forms.BindingSource lithiumRulesBindingSource1;
        private SOIFDBNewDataSet1TableAdapters.LithiumRulesTableAdapter lithiumRulesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lithumRouteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ContextMenuStrip ctxEdit;
        private System.Windows.Forms.ToolStripMenuItem addRuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRuleToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn lithiumGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lithiumTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LithiumRoute;
        private System.Windows.Forms.DataGridViewTextBoxColumn lithiumOrderTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lithiumShipAloneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lithiumGroupDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lithiumTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn lithiumOrderTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lithiumShipAloneDataGridViewTextBoxColumn1;
    }
}

