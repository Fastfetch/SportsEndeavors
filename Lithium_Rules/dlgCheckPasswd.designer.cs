
namespace Lithium_Rules
{
    partial class dlgCheckPasswd
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbAuthUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAuthPswd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID";
            // 
            // tbAuthUser
            // 
            this.tbAuthUser.Location = new System.Drawing.Point(127, 53);
            this.tbAuthUser.Name = "tbAuthUser";
            this.tbAuthUser.Size = new System.Drawing.Size(207, 26);
            this.tbAuthUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pswd";
            // 
            // tbAuthPswd
            // 
            this.tbAuthPswd.Location = new System.Drawing.Point(127, 109);
            this.tbAuthPswd.Name = "tbAuthPswd";
            this.tbAuthPswd.PasswordChar = '*';
            this.tbAuthPswd.Size = new System.Drawing.Size(207, 26);
            this.tbAuthPswd.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dlgCheckPasswd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbAuthPswd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAuthUser);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "dlgCheckPasswd";
            this.Text = "Enter your password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAuthUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAuthPswd;
        private System.Windows.Forms.Button button1;
    }
}