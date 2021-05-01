
namespace IC4128LS
{
    partial class Lang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lang));
            this.LabelLanguage = new System.Windows.Forms.Label();
            this.BtnEn = new System.Windows.Forms.Button();
            this.BtnJp = new System.Windows.Forms.Button();
            this.BtnZh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelLanguage
            // 
            this.LabelLanguage.AutoSize = true;
            this.LabelLanguage.Location = new System.Drawing.Point(12, 9);
            this.LabelLanguage.Name = "LabelLanguage";
            this.LabelLanguage.Size = new System.Drawing.Size(87, 13);
            this.LabelLanguage.TabIndex = 0;
            this.LabelLanguage.Text = "Select language:";
            // 
            // BtnEn
            // 
            this.BtnEn.Location = new System.Drawing.Point(12, 33);
            this.BtnEn.Name = "BtnEn";
            this.BtnEn.Size = new System.Drawing.Size(75, 23);
            this.BtnEn.TabIndex = 1;
            this.BtnEn.Text = "English";
            this.BtnEn.UseVisualStyleBackColor = true;
            this.BtnEn.Click += new System.EventHandler(this.BtnEn_Click);
            // 
            // BtnJp
            // 
            this.BtnJp.Location = new System.Drawing.Point(93, 33);
            this.BtnJp.Name = "BtnJp";
            this.BtnJp.Size = new System.Drawing.Size(75, 23);
            this.BtnJp.TabIndex = 2;
            this.BtnJp.Text = "日本語";
            this.BtnJp.UseVisualStyleBackColor = true;
            this.BtnJp.Click += new System.EventHandler(this.BtnJp_Click);
            // 
            // BtnZh
            // 
            this.BtnZh.Location = new System.Drawing.Point(174, 33);
            this.BtnZh.Name = "BtnZh";
            this.BtnZh.Size = new System.Drawing.Size(75, 23);
            this.BtnZh.TabIndex = 3;
            this.BtnZh.Text = "简体中文";
            this.BtnZh.UseVisualStyleBackColor = true;
            this.BtnZh.Click += new System.EventHandler(this.BtnZh_Click);
            // 
            // Lang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 68);
            this.ControlBox = false;
            this.Controls.Add(this.BtnZh);
            this.Controls.Add(this.BtnJp);
            this.Controls.Add(this.BtnEn);
            this.Controls.Add(this.LabelLanguage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Language";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelLanguage;
        private System.Windows.Forms.Button BtnEn;
        private System.Windows.Forms.Button BtnJp;
        private System.Windows.Forms.Button BtnZh;
    }
}