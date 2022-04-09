namespace Rectangular
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Information = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnMax = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.DrawButton = new System.Windows.Forms.Button();
            this.BtnMin = new System.Windows.Forms.Button();
            this.TitleBars = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TitleBars.SuspendLayout();
            this.SuspendLayout();
            // 
            // Information
            // 
            this.Information.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Information.Location = new System.Drawing.Point(285, 330);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(224, 23);
            this.Information.TabIndex = 5;
            this.Information.Text = "More Further About Rectangular";
            this.Information.UseVisualStyleBackColor = true;
            this.Information.Click += new System.EventHandler(this.InformationRect);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = global::Rectangular.Properties.Resources.rectangular;
            this.pictureBox1.Image = global::Rectangular.Properties.Resources.rectangular;
            this.pictureBox1.Location = new System.Drawing.Point(255, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BtnMax
            // 
            this.BtnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMax.BackgroundImage = global::Rectangular.Properties.Resources.minimize;
            this.BtnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMax.FlatAppearance.BorderSize = 0;
            this.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMax.Location = new System.Drawing.Point(730, 3);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(28, 26);
            this.BtnMax.TabIndex = 4;
            this.BtnMax.UseVisualStyleBackColor = true;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // Create
            // 
            this.Create.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Create.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.Image = ((System.Drawing.Image)(resources.GetObject("Create.Image")));
            this.Create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Create.Location = new System.Drawing.Point(313, 253);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(160, 42);
            this.Create.TabIndex = 1;
            this.Create.Text = "Created By";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Creator);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackgroundImage = global::Rectangular.Properties.Resources.exit;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Location = new System.Drawing.Point(764, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(28, 26);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // DrawButton
            // 
            this.DrawButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DrawButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DrawButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrawButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawButton.Image")));
            this.DrawButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DrawButton.Location = new System.Drawing.Point(313, 179);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(160, 42);
            this.DrawButton.TabIndex = 0;
            this.DrawButton.Text = "Drawing";
            this.DrawButton.UseVisualStyleBackColor = false;
            this.DrawButton.Click += new System.EventHandler(this.DrawingShape);
            // 
            // BtnMin
            // 
            this.BtnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMin.BackgroundImage = global::Rectangular.Properties.Resources.minus_button;
            this.BtnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Location = new System.Drawing.Point(696, 3);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(28, 26);
            this.BtnMin.TabIndex = 2;
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // TitleBars
            // 
            this.TitleBars.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TitleBars.Controls.Add(this.label4);
            this.TitleBars.Controls.Add(this.BtnClose);
            this.TitleBars.Controls.Add(this.BtnMin);
            this.TitleBars.Controls.Add(this.BtnMax);
            this.TitleBars.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBars.Location = new System.Drawing.Point(0, 0);
            this.TitleBars.Name = "TitleBars";
            this.TitleBars.Size = new System.Drawing.Size(800, 30);
            this.TitleBars.TabIndex = 7;
            this.TitleBars.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBars_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rectangular App";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.TitleBars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Rectangular  App";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TitleBars.ResumeLayout(false);
            this.TitleBars.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Information;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel TitleBars;
        private System.Windows.Forms.Label label4;
    }
}

