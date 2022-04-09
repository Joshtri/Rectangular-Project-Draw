namespace Rectangular
{
    partial class Drawingg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drawingg));
            this.DrawingButton = new System.Windows.Forms.Button();
            this.PictureDraws = new System.Windows.Forms.PictureBox();
            this.x_point = new System.Windows.Forms.TextBox();
            this.y_point = new System.Windows.Forms.TextBox();
            this.rect_height = new System.Windows.Forms.TextBox();
            this.rect_weight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDraws)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawingButton
            // 
            this.DrawingButton.Location = new System.Drawing.Point(570, 330);
            this.DrawingButton.Name = "DrawingButton";
            this.DrawingButton.Size = new System.Drawing.Size(152, 33);
            this.DrawingButton.TabIndex = 1;
            this.DrawingButton.Text = "Draw";
            this.DrawingButton.UseVisualStyleBackColor = true;
            this.DrawingButton.Click += new System.EventHandler(this.DrawingButton_Click);
            // 
            // PictureDraws
            // 
            this.PictureDraws.Location = new System.Drawing.Point(12, 36);
            this.PictureDraws.Name = "PictureDraws";
            this.PictureDraws.Size = new System.Drawing.Size(491, 402);
            this.PictureDraws.TabIndex = 2;
            this.PictureDraws.TabStop = false;
            this.PictureDraws.Click += new System.EventHandler(this.PictureDraws_Click);
            // 
            // x_point
            // 
            this.x_point.Location = new System.Drawing.Point(531, 93);
            this.x_point.Name = "x_point";
            this.x_point.Size = new System.Drawing.Size(70, 20);
            this.x_point.TabIndex = 3;
            // 
            // y_point
            // 
            this.y_point.Location = new System.Drawing.Point(687, 95);
            this.y_point.Name = "y_point";
            this.y_point.Size = new System.Drawing.Size(71, 20);
            this.y_point.TabIndex = 4;
            // 
            // rect_height
            // 
            this.rect_height.Location = new System.Drawing.Point(531, 167);
            this.rect_height.Name = "rect_height";
            this.rect_height.Size = new System.Drawing.Size(70, 20);
            this.rect_height.TabIndex = 5;
            // 
            // rect_weight
            // 
            this.rect_weight.Location = new System.Drawing.Point(693, 167);
            this.rect_weight.Name = "rect_weight";
            this.rect_weight.Size = new System.Drawing.Size(70, 20);
            this.rect_weight.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "H";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(659, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "W";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 13;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::Rectangular.Properties.Resources.exit;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(764, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 26);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = global::Rectangular.Properties.Resources.minus_button;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(696, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 26);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackgroundImage = global::Rectangular.Properties.Resources.minimize;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(730, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 26);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rectangular App";
            // 
            // Drawingg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rect_weight);
            this.Controls.Add(this.rect_height);
            this.Controls.Add(this.y_point);
            this.Controls.Add(this.x_point);
            this.Controls.Add(this.PictureDraws);
            this.Controls.Add(this.DrawingButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Drawingg";
            this.Text = "Drawing";
            ((System.ComponentModel.ISupportInitialize)(this.PictureDraws)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DrawingButton;
        private System.Windows.Forms.PictureBox PictureDraws;
        private System.Windows.Forms.TextBox x_point;
        private System.Windows.Forms.TextBox y_point;
        private System.Windows.Forms.TextBox rect_height;
        private System.Windows.Forms.TextBox rect_weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
    }
}