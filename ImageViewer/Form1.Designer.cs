namespace ImageViewer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkHide = new System.Windows.Forms.CheckBox();
            this.btnPanelty = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBox = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lstBoxPriority = new System.Windows.Forms.ListBox();
            this.lstBoxFiles = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUnPrioritise = new System.Windows.Forms.Button();
            this.btnPrioritise = new System.Windows.Forms.Button();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.chkHide);
            this.panel1.Controls.Add(this.btnLaunch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(308, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 415);
            this.panel1.TabIndex = 0;
            // 
            // chkHide
            // 
            this.chkHide.AutoSize = true;
            this.chkHide.Location = new System.Drawing.Point(6, 288);
            this.chkHide.Name = "chkHide";
            this.chkHide.Size = new System.Drawing.Size(59, 21);
            this.chkHide.TabIndex = 7;
            this.chkHide.Text = "Hide";
            this.chkHide.UseVisualStyleBackColor = true;
            this.chkHide.CheckedChanged += new System.EventHandler(this.ChkHide_CheckedChanged);
            // 
            // btnPanelty
            // 
            this.btnPanelty.BackColor = System.Drawing.Color.Red;
            this.btnPanelty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelty.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelty.ForeColor = System.Drawing.Color.White;
            this.btnPanelty.Location = new System.Drawing.Point(198, 183);
            this.btnPanelty.Name = "btnPanelty";
            this.btnPanelty.Size = new System.Drawing.Size(104, 52);
            this.btnPanelty.TabIndex = 6;
            this.btnPanelty.Text = "Panelty";
            this.btnPanelty.UseVisualStyleBackColor = false;
            this.btnPanelty.Click += new System.EventHandler(this.BtnPanelty_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLaunch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLaunch.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunch.Location = new System.Drawing.Point(0, 317);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(104, 98);
            this.btnLaunch.TabIndex = 2;
            this.btnLaunch.Text = "LAUNCH";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.BtnLaunch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblBox);
            this.panel2.Controls.Add(this.btnPanelty);
            this.panel2.Controls.Add(this.progress);
            this.panel2.Controls.Add(this.lblInstruction);
            this.panel2.Controls.Add(this.lstBoxPriority);
            this.panel2.Controls.Add(this.lstBoxFiles);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 415);
            this.panel2.TabIndex = 1;
            // 
            // lblBox
            // 
            this.lblBox.AutoSize = true;
            this.lblBox.BackColor = System.Drawing.Color.Indigo;
            this.lblBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBox.ForeColor = System.Drawing.Color.Indigo;
            this.lblBox.Location = new System.Drawing.Point(12, 137);
            this.lblBox.Name = "lblBox";
            this.lblBox.Size = new System.Drawing.Size(81, 91);
            this.lblBox.TabIndex = 4;
            this.lblBox.Text = "  ";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(10, 178);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(280, 39);
            this.progress.Step = 1;
            this.progress.TabIndex = 3;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(2, 134);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(0, 24);
            this.lblInstruction.TabIndex = 2;
            // 
            // lstBoxPriority
            // 
            this.lstBoxPriority.BackColor = System.Drawing.Color.Gray;
            this.lstBoxPriority.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstBoxPriority.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxPriority.FormattingEnabled = true;
            this.lstBoxPriority.ItemHeight = 25;
            this.lstBoxPriority.Location = new System.Drawing.Point(0, 236);
            this.lstBoxPriority.Name = "lstBoxPriority";
            this.lstBoxPriority.Size = new System.Drawing.Size(308, 179);
            this.lstBoxPriority.TabIndex = 1;
            this.lstBoxPriority.SelectedIndexChanged += new System.EventHandler(this.LstBoxPriority_SelectedIndexChanged);
            // 
            // lstBoxFiles
            // 
            this.lstBoxFiles.BackColor = System.Drawing.Color.Gray;
            this.lstBoxFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstBoxFiles.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxFiles.FormattingEnabled = true;
            this.lstBoxFiles.ItemHeight = 25;
            this.lstBoxFiles.Location = new System.Drawing.Point(0, 0);
            this.lstBoxFiles.Name = "lstBoxFiles";
            this.lstBoxFiles.Size = new System.Drawing.Size(308, 129);
            this.lstBoxFiles.TabIndex = 0;
            this.lstBoxFiles.SelectedIndexChanged += new System.EventHandler(this.LstBoxFiles_SelectedIndexChanged);
            this.lstBoxFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstBoxFiles_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUnPrioritise);
            this.panel3.Controls.Add(this.btnPrioritise);
            this.panel3.Controls.Add(this.btnAnalyse);
            this.panel3.Controls.Add(this.btnBrowse);
            this.panel3.Controls.Add(this.txtDir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(104, 180);
            this.panel3.TabIndex = 9;
            // 
            // btnUnPrioritise
            // 
            this.btnUnPrioritise.BackColor = System.Drawing.Color.Coral;
            this.btnUnPrioritise.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnPrioritise.Location = new System.Drawing.Point(52, 126);
            this.btnUnPrioritise.Name = "btnUnPrioritise";
            this.btnUnPrioritise.Size = new System.Drawing.Size(52, 52);
            this.btnUnPrioritise.TabIndex = 13;
            this.btnUnPrioritise.Text = "-";
            this.btnUnPrioritise.UseVisualStyleBackColor = false;
            this.btnUnPrioritise.Click += new System.EventHandler(this.BtnUnPrioritise_Click);
            // 
            // btnPrioritise
            // 
            this.btnPrioritise.BackColor = System.Drawing.Color.YellowGreen;
            this.btnPrioritise.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrioritise.Location = new System.Drawing.Point(0, 126);
            this.btnPrioritise.Name = "btnPrioritise";
            this.btnPrioritise.Size = new System.Drawing.Size(53, 52);
            this.btnPrioritise.TabIndex = 12;
            this.btnPrioritise.Text = "+";
            this.btnPrioritise.UseVisualStyleBackColor = false;
            this.btnPrioritise.Click += new System.EventHandler(this.BtnPrioritise_Click);
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnalyse.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyse.ForeColor = System.Drawing.Color.Black;
            this.btnAnalyse.Location = new System.Drawing.Point(0, 74);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(104, 52);
            this.btnAnalyse.TabIndex = 11;
            this.btnAnalyse.Text = "ANALYSE";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.BtnAnalyse_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.Black;
            this.btnBrowse.Location = new System.Drawing.Point(0, 22);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(104, 52);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "BROWSE";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // txtDir
            // 
            this.txtDir.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDir.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDir.Enabled = false;
            this.txtDir.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDir.ForeColor = System.Drawing.Color.Black;
            this.txtDir.Location = new System.Drawing.Point(0, 0);
            this.txtDir.Multiline = true;
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(104, 22);
            this.txtDir.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(412, 415);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Image Viewer";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstBoxPriority;
        private System.Windows.Forms.ListBox lstBoxFiles;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPanelty;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblBox;
        private System.Windows.Forms.CheckBox chkHide;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUnPrioritise;
        private System.Windows.Forms.Button btnPrioritise;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtDir;
    }
}

