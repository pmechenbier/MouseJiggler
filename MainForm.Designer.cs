namespace MouseJiggle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.jiggleTimer = new System.Windows.Forms.Timer(this.components);
            this.cbEnabled = new System.Windows.Forms.CheckBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.cbZenJiggle = new System.Windows.Forms.CheckBox();
            this.btnToTray = new System.Windows.Forms.Button();
            this.nifMin = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // jiggleTimer
            // 
            this.jiggleTimer.Interval = 1000;
            this.jiggleTimer.Tick += new System.EventHandler(this.jiggleTimer_Tick);
            // 
            // cbEnabled
            // 
            this.cbEnabled.AutoSize = true;
            this.cbEnabled.Location = new System.Drawing.Point(17, 16);
            this.cbEnabled.Margin = new System.Windows.Forms.Padding(4);
            this.cbEnabled.Name = "cbEnabled";
            this.cbEnabled.Size = new System.Drawing.Size(111, 21);
            this.cbEnabled.TabIndex = 0;
            this.cbEnabled.Text = "Enable jiggle";
            this.cbEnabled.UseVisualStyleBackColor = true;
            this.cbEnabled.CheckedChanged += new System.EventHandler(this.cbEnabled_CheckedChanged);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(148, 9);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(44, 28);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "?";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // cbZenJiggle
            // 
            this.cbZenJiggle.AutoSize = true;
            this.cbZenJiggle.Location = new System.Drawing.Point(33, 44);
            this.cbZenJiggle.Margin = new System.Windows.Forms.Padding(4);
            this.cbZenJiggle.Name = "cbZenJiggle";
            this.cbZenJiggle.Size = new System.Drawing.Size(92, 21);
            this.cbZenJiggle.TabIndex = 2;
            this.cbZenJiggle.Text = "Zen jiggle";
            this.cbZenJiggle.UseVisualStyleBackColor = true;
            this.cbZenJiggle.CheckedChanged += new System.EventHandler(this.cbZenJiggle_CheckedChanged);
            // 
            // btnToTray
            // 
            this.btnToTray.Image = ((System.Drawing.Image)(resources.GetObject("btnToTray.Image")));
            this.btnToTray.Location = new System.Drawing.Point(148, 39);
            this.btnToTray.Margin = new System.Windows.Forms.Padding(4);
            this.btnToTray.Name = "btnToTray";
            this.btnToTray.Size = new System.Drawing.Size(44, 28);
            this.btnToTray.TabIndex = 3;
            this.btnToTray.UseVisualStyleBackColor = true;
            this.btnToTray.Click += new System.EventHandler(this.btnToTray_Click);
            // 
            // nifMin
            // 
            this.nifMin.Icon = ((System.Drawing.Icon)(resources.GetObject("nifMin.Icon")));
            this.nifMin.Text = "Mouse Jiggler";
            this.nifMin.DoubleClick += new System.EventHandler(this.nifMin_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 73);
            this.Controls.Add(this.btnToTray);
            this.Controls.Add(this.cbZenJiggle);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.cbEnabled);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MouseJiggle";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer jiggleTimer;
        private System.Windows.Forms.CheckBox cbEnabled;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.CheckBox cbZenJiggle;
        private System.Windows.Forms.Button btnToTray;
        private System.Windows.Forms.NotifyIcon nifMin;
    }
}