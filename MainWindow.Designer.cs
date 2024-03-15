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
            this.panel1 = new System.Windows.Forms.Panel();
            this.appClose = new System.Windows.Forms.Button();
            this.appMinimize = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.appContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.appClose);
            this.panel1.Controls.Add(this.appMinimize);
            this.panel1.Location = new System.Drawing.Point(173, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 30);
            this.panel1.TabIndex = 0;
            // 
            // appClose
            // 
            this.appClose.BackgroundImage = global::AWI_Toolkit.Properties.Resources.close;
            this.appClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.appClose.FlatAppearance.BorderSize = 0;
            this.appClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appClose.Location = new System.Drawing.Point(691, 0);
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
            this.appMinimize.Location = new System.Drawing.Point(657, 0);
            this.appMinimize.Name = "appMinimize";
            this.appMinimize.Size = new System.Drawing.Size(34, 30);
            this.appMinimize.TabIndex = 1;
            this.appMinimize.UseVisualStyleBackColor = true;
            this.appMinimize.Click += new System.EventHandler(this.appMinimize_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.btnAbout);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 500);
            this.panel2.TabIndex = 1;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("SF Pro Text", 13F);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(0, 169);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(192, 40);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AWI Toolkit";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button appMinimize;
        private System.Windows.Forms.Button appClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel appContainer;
    }
}