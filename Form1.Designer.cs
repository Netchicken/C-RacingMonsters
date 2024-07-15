namespace C_RacingMonsters
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
            this.btnRace = new System.Windows.Forms.Button();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.lblWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRace
            // 
            this.btnRace.Location = new System.Drawing.Point(471, 13);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(191, 50);
            this.btnRace.TabIndex = 4;
            this.btnRace.Text = "Race!";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // pbx2
            // 
            this.pbx2.Image = global::C_RacingMonsters.Resource1.Igor;
            this.pbx2.Location = new System.Drawing.Point(44, 131);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(77, 70);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 3;
            this.pbx2.TabStop = false;
            this.pbx2.Tag = "Igor";
            // 
            // pbx3
            // 
            this.pbx3.Image = global::C_RacingMonsters.Resource1.Ogor;
            this.pbx3.Location = new System.Drawing.Point(44, 207);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(77, 70);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 2;
            this.pbx3.TabStop = false;
            this.pbx3.Tag = "Ogor";
            // 
            // pbx4
            // 
            this.pbx4.Image = global::C_RacingMonsters.Resource1.Ugor;
            this.pbx4.Location = new System.Drawing.Point(44, 283);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(77, 70);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx4.TabIndex = 1;
            this.pbx4.TabStop = false;
            this.pbx4.Tag = "Ugor";
            // 
            // pbx1
            // 
            this.pbx1.Image = global::C_RacingMonsters.Resource1.Agor;
            this.pbx1.Location = new System.Drawing.Point(44, 55);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(77, 70);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            this.pbx1.Tag = "Agor";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(68, 12);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(35, 13);
            this.lblWinner.TabIndex = 5;
            this.lblWinner.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 393);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.pbx2);
            this.Controls.Add(this.pbx3);
            this.Controls.Add(this.pbx4);
            this.Controls.Add(this.pbx1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Label lblWinner;
    }
}

