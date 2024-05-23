
namespace IC4128LS
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.LabelNotFound = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.LabelFound = new System.Windows.Forms.Label();
            this.mainWorker = new System.ComponentModel.BackgroundWorker();
            this.LabelDiff = new System.Windows.Forms.Label();
            this.LabelRoute = new System.Windows.Forms.Label();
            this.LabelMiss = new System.Windows.Forms.Label();
            this.LabelBomb = new System.Windows.Forms.Label();
            this.LabelGold = new System.Windows.Forms.Label();
            this.LabelSilver = new System.Windows.Forms.Label();
            this.LabelBronze = new System.Windows.Forms.Label();
            this.LabelISCORE = new System.Windows.Forms.Label();
            this.ValueDiff = new System.Windows.Forms.Label();
            this.ValueRoute = new System.Windows.Forms.Label();
            this.ValueMiss = new System.Windows.Forms.Label();
            this.ValueBomb = new System.Windows.Forms.Label();
            this.ValueGold = new System.Windows.Forms.Label();
            this.ValueSilver = new System.Windows.Forms.Label();
            this.ValueBronze = new System.Windows.Forms.Label();
            this.ValueISCORE = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelNotFound
            // 
            resources.ApplyResources(this.LabelNotFound, "LabelNotFound");
            this.LabelNotFound.ForeColor = System.Drawing.Color.Red;
            this.LabelNotFound.Name = "LabelNotFound";
            // 
            // FindButton
            // 
            resources.ApplyResources(this.FindButton, "FindButton");
            this.FindButton.Name = "FindButton";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // LabelFound
            // 
            resources.ApplyResources(this.LabelFound, "LabelFound");
            this.LabelFound.ForeColor = System.Drawing.Color.LimeGreen;
            this.LabelFound.Name = "LabelFound";
            // 
            // mainWorker
            // 
            this.mainWorker.WorkerReportsProgress = true;
            this.mainWorker.WorkerSupportsCancellation = true;
            this.mainWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            this.mainWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Worker_ProgressChanged);
            this.mainWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
            // 
            // LabelDiff
            // 
            this.LabelDiff.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LabelDiff, "LabelDiff");
            this.LabelDiff.ForeColor = System.Drawing.Color.White;
            this.LabelDiff.Name = "LabelDiff";
            // 
            // LabelRoute
            // 
            this.LabelRoute.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LabelRoute, "LabelRoute");
            this.LabelRoute.ForeColor = System.Drawing.Color.White;
            this.LabelRoute.Name = "LabelRoute";
            // 
            // LabelMiss
            // 
            this.LabelMiss.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LabelMiss, "LabelMiss");
            this.LabelMiss.ForeColor = System.Drawing.Color.Fuchsia;
            this.LabelMiss.Name = "LabelMiss";
            // 
            // LabelBomb
            // 
            this.LabelBomb.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LabelBomb, "LabelBomb");
            this.LabelBomb.ForeColor = System.Drawing.Color.Lime;
            this.LabelBomb.Name = "LabelBomb";
            // 
            // LabelGold
            // 
            this.LabelGold.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LabelGold, "LabelGold");
            this.LabelGold.ForeColor = System.Drawing.Color.Yellow;
            this.LabelGold.Name = "LabelGold";
            // 
            // LabelSilver
            // 
            this.LabelSilver.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LabelSilver, "LabelSilver");
            this.LabelSilver.ForeColor = System.Drawing.Color.Silver;
            this.LabelSilver.Name = "LabelSilver";
            // 
            // LabelBronze
            // 
            this.LabelBronze.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LabelBronze, "LabelBronze");
            this.LabelBronze.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LabelBronze.Name = "LabelBronze";
            // 
            // LabelISCORE
            // 
            this.LabelISCORE.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LabelISCORE, "LabelISCORE");
            this.LabelISCORE.ForeColor = System.Drawing.Color.White;
            this.LabelISCORE.Name = "LabelISCORE";
            // 
            // ValueDiff
            // 
            this.ValueDiff.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ValueDiff, "ValueDiff");
            this.ValueDiff.ForeColor = System.Drawing.Color.White;
            this.ValueDiff.Name = "ValueDiff";
            // 
            // ValueRoute
            // 
            this.ValueRoute.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ValueRoute, "ValueRoute");
            this.ValueRoute.ForeColor = System.Drawing.Color.White;
            this.ValueRoute.Name = "ValueRoute";
            // 
            // ValueMiss
            // 
            this.ValueMiss.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ValueMiss, "ValueMiss");
            this.ValueMiss.ForeColor = System.Drawing.Color.Fuchsia;
            this.ValueMiss.Name = "ValueMiss";
            // 
            // ValueBomb
            // 
            this.ValueBomb.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ValueBomb, "ValueBomb");
            this.ValueBomb.ForeColor = System.Drawing.Color.Lime;
            this.ValueBomb.Name = "ValueBomb";
            // 
            // ValueGold
            // 
            this.ValueGold.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ValueGold, "ValueGold");
            this.ValueGold.ForeColor = System.Drawing.Color.Yellow;
            this.ValueGold.Name = "ValueGold";
            // 
            // ValueSilver
            // 
            this.ValueSilver.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ValueSilver, "ValueSilver");
            this.ValueSilver.ForeColor = System.Drawing.Color.Silver;
            this.ValueSilver.Name = "ValueSilver";
            // 
            // ValueBronze
            // 
            this.ValueBronze.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ValueBronze, "ValueBronze");
            this.ValueBronze.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ValueBronze.Name = "ValueBronze";
            // 
            // ValueISCORE
            // 
            this.ValueISCORE.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ValueISCORE, "ValueISCORE");
            this.ValueISCORE.ForeColor = System.Drawing.Color.White;
            this.ValueISCORE.Name = "ValueISCORE";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tableLayoutPanel2.Controls.Add(this.ValueISCORE, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.LabelSilver, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.ValueBronze, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.LabelDiff, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ValueSilver, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.ValueDiff, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.LabelISCORE, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.LabelRoute, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LabelBronze, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.LabelMiss, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ValueGold, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.ValueRoute, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.ValueBomb, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.ValueMiss, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.LabelBomb, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.LabelGold, 0, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.LabelFound);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.LabelNotFound);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LabelNotFound;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label LabelFound;
        private System.ComponentModel.BackgroundWorker mainWorker;
        private System.Windows.Forms.Label LabelDiff;
        private System.Windows.Forms.Label LabelRoute;
        private System.Windows.Forms.Label LabelMiss;
        private System.Windows.Forms.Label LabelBomb;
        private System.Windows.Forms.Label LabelGold;
        private System.Windows.Forms.Label LabelSilver;
        private System.Windows.Forms.Label LabelBronze;
        private System.Windows.Forms.Label LabelISCORE;
        private System.Windows.Forms.Label ValueDiff;
        private System.Windows.Forms.Label ValueRoute;
        private System.Windows.Forms.Label ValueMiss;
        private System.Windows.Forms.Label ValueBomb;
        private System.Windows.Forms.Label ValueGold;
        private System.Windows.Forms.Label ValueSilver;
        private System.Windows.Forms.Label ValueBronze;
        private System.Windows.Forms.Label ValueISCORE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

