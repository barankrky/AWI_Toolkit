namespace AWI_Toolkit
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.appTopBar = new System.Windows.Forms.Panel();
            this.appClose = new System.Windows.Forms.Button();
            this.appMinimize = new System.Windows.Forms.Button();
            this.appSidePanel = new System.Windows.Forms.Panel();
            this.appNavBar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCleanup = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.appContainer = new System.Windows.Forms.Panel();
            this.appTopBar.SuspendLayout();
            this.appSidePanel.SuspendLayout();
            this.appNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // appTopBar
            // 
            this.appTopBar.BackColor = System.Drawing.Color.Transparent;
            this.appTopBar.Controls.Add(this.appClose);
            this.appTopBar.Controls.Add(this.appMinimize);
            this.appTopBar.Location = new System.Drawing.Point(0, 0);
            this.appTopBar.Name = "appTopBar";
            this.appTopBar.Size = new System.Drawing.Size(901, 30);
            this.appTopBar.TabIndex = 0;
            this.appTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.appTopBar_MouseDown);
            // 
            // appClose
            // 
            this.appClose.BackgroundImage = global::AWI_Toolkit.Properties.Resources.close;
            this.appClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.appClose.FlatAppearance.BorderSize = 0;
            this.appClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appClose.Location = new System.Drawing.Point(864, 0);
            this.appClose.Name = "appClose";
            this.appClose.Size = new System.Drawing.Size(37, 30);
            this.appClose.TabIndex = 2;
            this.appClose.UseVisualStyleBackColor = true;
            this.appClose.Click += new System.EventHandler(this.appClose_Click);
            // 
            // appMinimize
            // 
            this.appMinimize.BackgroundImage = global::AWI_Toolkit.Properties.Resources.minimize;
            this.appMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.appMinimize.FlatAppearance.BorderSize = 0;
            this.appMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appMinimize.Location = new System.Drawing.Point(830, 0);
            this.appMinimize.Name = "appMinimize";
            this.appMinimize.Size = new System.Drawing.Size(34, 30);
            this.appMinimize.TabIndex = 1;
            this.appMinimize.UseVisualStyleBackColor = true;
            this.appMinimize.Click += new System.EventHandler(this.appMinimize_Click);
            // 
            // appSidePanel
            // 
            this.appSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.appSidePanel.Controls.Add(this.appNavBar);
            this.appSidePanel.Controls.Add(this.pictureBox1);
            this.appSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.appSidePanel.Location = new System.Drawing.Point(0, 0);
            this.appSidePanel.Name = "appSidePanel";
            this.appSidePanel.Size = new System.Drawing.Size(192, 500);
            this.appSidePanel.TabIndex = 1;
            // 
            // appNavBar
            // 
            this.appNavBar.Controls.Add(this.btnCleanup);
            this.appNavBar.Controls.Add(this.btnAbout);
            this.appNavBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appNavBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.appNavBar.Location = new System.Drawing.Point(0, 169);
            this.appNavBar.Name = "appNavBar";
            this.appNavBar.Size = new System.Drawing.Size(192, 331);
            this.appNavBar.TabIndex = 4;
            // 
            // btnCleanup
            // 
            this.btnCleanup.AutoSize = true;
            this.btnCleanup.FlatAppearance.BorderSize = 0;
            this.btnCleanup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanup.Font = new System.Drawing.Font("SF Pro Text", 13F);
            this.btnCleanup.ForeColor = System.Drawing.Color.White;
            this.btnCleanup.Location = new System.Drawing.Point(3, 3);
            this.btnCleanup.Name = "btnCleanup";
            this.btnCleanup.Size = new System.Drawing.Size(189, 40);
            this.btnCleanup.TabIndex = 4;
            this.btnCleanup.Text = "Cleanup";
            this.btnCleanup.UseVisualStyleBackColor = true;
            this.btnCleanup.Click += new System.EventHandler(this.btnCleanup_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.AutoSize = true;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("SF Pro Text", 13F);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(3, 49);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(189, 40);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // appContainer
            // 
            this.appContainer.Location = new System.Drawing.Point(198, 36);
            this.appContainer.Name = "appContainer";
            this.appContainer.Size = new System.Drawing.Size(690, 452);
            this.appContainer.TabIndex = 2;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.appContainer);
            this.Controls.Add(this.appSidePanel);
            this.Controls.Add(this.appTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AWI Toolkit";
            this.appTopBar.ResumeLayout(false);
            this.appSidePanel.ResumeLayout(false);
            this.appNavBar.ResumeLayout(false);
            this.appNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button appMinimize;
        private System.Windows.Forms.Button appClose;
        private System.Windows.Forms.Panel appTopBar;
        private System.Windows.Forms.Panel appSidePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel appContainer;
        private System.Windows.Forms.FlowLayoutPanel appNavBar;
        private System.Windows.Forms.Button btnCleanup;
    }
}