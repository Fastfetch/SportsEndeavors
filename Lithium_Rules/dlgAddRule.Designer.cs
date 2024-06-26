namespace Lithium_Rules
{
    partial class dlgAddRule
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
            this.lblGrp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbItemType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRoute = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkShipAlone = new System.Windows.Forms.CheckBox();
            this.tbOrderType = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudGrp = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGrp
            // 
            this.lblGrp.AutoSize = true;
            this.lblGrp.Location = new System.Drawing.Point(78, 42);
            this.lblGrp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrp.Name = "lblGrp";
            this.lblGrp.Size = new System.Drawing.Size(58, 20);
            this.lblGrp.TabIndex = 0;
            this.lblGrp.Text = "Group:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Type:";
            // 
            // tbItemType
            // 
            this.tbItemType.Location = new System.Drawing.Point(230, 86);
            this.tbItemType.Name = "tbItemType";
            this.tbItemType.Size = new System.Drawing.Size(139, 26);
            this.tbItemType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Route:";
            // 
            // tbRoute
            // 
            this.tbRoute.Location = new System.Drawing.Point(230, 136);
            this.tbRoute.Name = "tbRoute";
            this.tbRoute.Size = new System.Drawing.Size(139, 26);
            this.tbRoute.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Order Type:";
            // 
            // chkShipAlone
            // 
            this.chkShipAlone.AutoSize = true;
            this.chkShipAlone.Location = new System.Drawing.Point(230, 246);
            this.chkShipAlone.Name = "chkShipAlone";
            this.chkShipAlone.Size = new System.Drawing.Size(105, 24);
            this.chkShipAlone.TabIndex = 6;
            this.chkShipAlone.Text = "Ship Alone";
            this.chkShipAlone.UseVisualStyleBackColor = true;
            // 
            // tbOrderType
            // 
            this.tbOrderType.Location = new System.Drawing.Point(230, 187);
            this.tbOrderType.Name = "tbOrderType";
            this.tbOrderType.Size = new System.Drawing.Size(139, 26);
            this.tbOrderType.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(565, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 40);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Update";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudGrp
            // 
            this.nudGrp.Location = new System.Drawing.Point(230, 41);
            this.nudGrp.Name = "nudGrp";
            this.nudGrp.Size = new System.Drawing.Size(120, 26);
            this.nudGrp.TabIndex = 9;
            // 
            // dlgAddRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 426);
            this.Controls.Add(this.nudGrp);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbOrderType);
            this.Controls.Add(this.chkShipAlone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRoute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbItemType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGrp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "dlgAddRule";
            this.Text = "Add Rule";
            ((System.ComponentModel.ISupportInitialize)(this.nudGrp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbItemType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRoute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkShipAlone;
        private System.Windows.Forms.TextBox tbOrderType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudGrp;
    }
}