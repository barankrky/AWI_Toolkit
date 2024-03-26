
namespace AWI_Toolkit.Controls
{
    partial class Template
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblControlName = new System.Windows.Forms.Label();
            this.lblControlDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblControlName
            // 
            this.lblControlName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblControlName.Font = new System.Drawing.Font("SF Pro Text", 14F, System.Drawing.FontStyle.Bold);
            this.lblControlName.ForeColor = System.Drawing.Color.White;
            this.lblControlName.Location = new System.Drawing.Point(0, 0);
            this.lblControlName.Name = "lblControlName";
            this.lblControlName.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblControlName.Size = new System.Drawing.Size(171, 40);
            this.lblControlName.TabIndex = 0;
            this.lblControlName.Text = "ControlName";
            this.lblControlName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblControlDescription
            // 
            this.lblControlDescription.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblControlDescription.Font = new System.Drawing.Font("SF Pro Text", 12F);
            this.lblControlDescription.ForeColor = System.Drawing.Color.DarkGray;
            this.lblControlDescription.Location = new System.Drawing.Point(177, 0);
            this.lblControlDescription.Name = "lblControlDescription";
            this.lblControlDescription.Size = new System.Drawing.Size(513, 40);
            this.lblControlDescription.TabIndex = 1;
            this.lblControlDescription.Text = "ControlDescription";
            this.lblControlDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblControlName);
            this.panel1.Controls.Add(this.lblControlDescription);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 40);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 412);
            this.panel2.TabIndex = 3;
            // 
            // template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "template";
            this.Size = new System.Drawing.Size(690, 452);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblControlName;
        private System.Windows.Forms.Label lblControlDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
