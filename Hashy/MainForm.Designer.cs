namespace Hashy
{
    partial class MainForm
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
			this.cbxAlgorithm = new System.Windows.Forms.ComboBox();
			this.txtSource = new System.Windows.Forms.TextBox();
			this.lblTarget = new System.Windows.Forms.Label();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.chkToLower = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// cbxAlgorithm
			// 
			this.cbxAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxAlgorithm.FormattingEnabled = true;
			this.cbxAlgorithm.Items.AddRange(new object[] {
            "MD5",
            "SHA-1",
            "SHA-256",
            "SHA-512"});
			this.cbxAlgorithm.Location = new System.Drawing.Point(16, 16);
			this.cbxAlgorithm.Margin = new System.Windows.Forms.Padding(4);
			this.cbxAlgorithm.Name = "cbxAlgorithm";
			this.cbxAlgorithm.Size = new System.Drawing.Size(147, 32);
			this.cbxAlgorithm.TabIndex = 0;
			this.cbxAlgorithm.TabStop = false;
			this.cbxAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cbxAlgorithm_SelectedIndexChanged);
			// 
			// txtSource
			// 
			this.txtSource.Location = new System.Drawing.Point(172, 16);
			this.txtSource.Margin = new System.Windows.Forms.Padding(4);
			this.txtSource.Name = "txtSource";
			this.txtSource.Size = new System.Drawing.Size(393, 32);
			this.txtSource.TabIndex = 1;
			this.txtSource.UseSystemPasswordChar = true;
			this.txtSource.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSource_MouseDown);
			this.txtSource.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtSource_MouseUp);
			// 
			// lblTarget
			// 
			this.lblTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTarget.Location = new System.Drawing.Point(16, 64);
			this.lblTarget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTarget.Name = "lblTarget";
			this.lblTarget.Size = new System.Drawing.Size(549, 60);
			this.lblTarget.TabIndex = 2;
			this.lblTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblTarget.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTarget_MouseDown);
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(412, 140);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(153, 32);
			this.btnGenerate.TabIndex = 3;
			this.btnGenerate.Text = "&Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// chkToLower
			// 
			this.chkToLower.AutoSize = true;
			this.chkToLower.Location = new System.Drawing.Point(16, 147);
			this.chkToLower.Name = "chkToLower";
			this.chkToLower.Size = new System.Drawing.Size(169, 28);
			this.chkToLower.TabIndex = 4;
			this.chkToLower.TabStop = false;
			this.chkToLower.Text = "Use &Lowercase";
			this.chkToLower.UseVisualStyleBackColor = true;
			this.chkToLower.CheckedChanged += new System.EventHandler(this.chkToLower_CheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 184);
			this.Controls.Add(this.chkToLower);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.lblTarget);
			this.Controls.Add(this.txtSource);
			this.Controls.Add(this.cbxAlgorithm);
			this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hashy";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.ComboBox cbxAlgorithm;
		private System.Windows.Forms.TextBox txtSource;
		private System.Windows.Forms.Label lblTarget;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.CheckBox chkToLower;
    }
}

