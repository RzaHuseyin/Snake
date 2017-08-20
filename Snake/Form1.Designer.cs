namespace Snake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-8, 378);
            this.label1.MaximumSize = new System.Drawing.Size(550, 350);
            this.label1.MinimumSize = new System.Drawing.Size(630, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 13);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(220, 418);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.MinimumSize = new System.Drawing.Size(93, 35);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(93, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Up";
            this.label2.Click += new System.EventHandler(this.ClickLable);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(220, 453);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.MinimumSize = new System.Drawing.Size(64, 35);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(93, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Down";
            this.label3.Click += new System.EventHandler(this.ClickLable);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(135, 453);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.MinimumSize = new System.Drawing.Size(85, 35);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(85, 35);
            this.label4.TabIndex = 7;
            this.label4.Text = "Left";
            this.label4.Click += new System.EventHandler(this.ClickLable);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Location = new System.Drawing.Point(313, 453);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.MinimumSize = new System.Drawing.Size(85, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 35);
            this.label5.TabIndex = 8;
            this.label5.Text = "Right";
            this.label5.Click += new System.EventHandler(this.ClickLable);
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label6.Location = new System.Drawing.Point(9, 401);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.MinimumSize = new System.Drawing.Size(0, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 35);
            this.label6.TabIndex = 9;
            this.label6.Text = "New Game";
            this.label6.Click += new System.EventHandler(this.RefreshClickMethod);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Location = new System.Drawing.Point(426, 401);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.MinimumSize = new System.Drawing.Size(122, 35);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(122, 35);
            this.label7.TabIndex = 10;
            this.label7.Text = "Score:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label8.Location = new System.Drawing.Point(546, 401);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.MinimumSize = new System.Drawing.Size(64, 35);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(64, 35);
            this.label8.TabIndex = 11;
            this.label8.Text = "0";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label9.Location = new System.Drawing.Point(546, 453);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.MinimumSize = new System.Drawing.Size(64, 35);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(64, 35);
            this.label9.TabIndex = 13;
            this.label9.Text = "0";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label10.Location = new System.Drawing.Point(426, 453);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.MinimumSize = new System.Drawing.Size(122, 35);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(122, 35);
            this.label10.TabIndex = 12;
            this.label10.Text = "Record:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(619, 497);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

