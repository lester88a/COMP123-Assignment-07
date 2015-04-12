namespace COMP123_Assignment07
{
    partial class StreamForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.TankLabel = new System.Windows.Forms.Label();
            this.CreditChargedLabel = new System.Windows.Forms.Label();
            this.BeginStreamingLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(178, 211);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(114, 32);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // TankLabel
            // 
            this.TankLabel.AutoSize = true;
            this.TankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TankLabel.Location = new System.Drawing.Point(55, 9);
            this.TankLabel.Name = "TankLabel";
            this.TankLabel.Size = new System.Drawing.Size(363, 25);
            this.TankLabel.TabIndex = 1;
            this.TankLabel.Text = "Thank you for choosing Movie Bonanza!";
            // 
            // CreditChargedLabel
            // 
            this.CreditChargedLabel.AutoSize = true;
            this.CreditChargedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditChargedLabel.Location = new System.Drawing.Point(12, 144);
            this.CreditChargedLabel.Name = "CreditChargedLabel";
            this.CreditChargedLabel.Size = new System.Drawing.Size(23, 25);
            this.CreditChargedLabel.TabIndex = 2;
            this.CreditChargedLabel.Text = "0";
            // 
            // BeginStreamingLabel
            // 
            this.BeginStreamingLabel.AutoSize = true;
            this.BeginStreamingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginStreamingLabel.Location = new System.Drawing.Point(12, 169);
            this.BeginStreamingLabel.Name = "BeginStreamingLabel";
            this.BeginStreamingLabel.Size = new System.Drawing.Size(23, 25);
            this.BeginStreamingLabel.TabIndex = 3;
            this.BeginStreamingLabel.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::COMP123_Assignment07.Properties.Resources.done1;
            this.pictureBox1.Location = new System.Drawing.Point(186, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 255);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BeginStreamingLabel);
            this.Controls.Add(this.CreditChargedLabel);
            this.Controls.Add(this.TankLabel);
            this.Controls.Add(this.OKButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your movie is about to start!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label TankLabel;
        private System.Windows.Forms.Label CreditChargedLabel;
        private System.Windows.Forms.Label BeginStreamingLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}