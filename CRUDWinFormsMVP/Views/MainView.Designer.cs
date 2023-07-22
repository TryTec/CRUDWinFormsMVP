namespace CRUDWinFormsMVP.Views
{
    partial class MainView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnPets = new System.Windows.Forms.Button();
            this.LinkSource = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LinkSource);
            this.panel1.Controls.Add(this.BtnPets);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 561);
            this.panel1.TabIndex = 0;
            // 
            // BtnPets
            // 
            this.BtnPets.Location = new System.Drawing.Point(3, 29);
            this.BtnPets.Name = "BtnPets";
            this.BtnPets.Size = new System.Drawing.Size(194, 45);
            this.BtnPets.TabIndex = 0;
            this.BtnPets.Text = "Pets";
            this.BtnPets.UseVisualStyleBackColor = true;
            // 
            // LinkSource
            // 
            this.LinkSource.AutoEllipsis = true;
            this.LinkSource.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LinkSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkSource.Location = new System.Drawing.Point(0, 542);
            this.LinkSource.Name = "LinkSource";
            this.LinkSource.Size = new System.Drawing.Size(200, 19);
            this.LinkSource.TabIndex = 2;
            this.LinkSource.TabStop = true;
            this.LinkSource.Text = "Github Source: RJCodeAdvance";
            this.LinkSource.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSource_LinkClicked);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainView";
            this.Text = "MainView";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnPets;
        private System.Windows.Forms.LinkLabel LinkSource;
    }
}